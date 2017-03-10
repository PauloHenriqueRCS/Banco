using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class CadastroCliente : Form
    {
        private const string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BancoDB.mdf;Integrated Security = True";
            //"Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\k\\Meus documentos\\Visual Studio 2015\\Projects\\Banco\\Banco\\BancoDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        private List<Cliente> clientes = new List<Cliente>();
        Cliente cliente = new Cliente();
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
            return conn;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            var conn = Conectar();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT IDCLIENTE, NOME, CPF, RG, IDADE, SEXO, NACIONALIDADE FROM CLIENTE";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt16(reader["IDCLIENTE"]);
                cliente.Nome = reader["NOME"].ToString();
                cliente.Cpf = reader["CPF"].ToString();
                cliente.Rg = reader["RG"].ToString();
                cliente.Idade = Convert.ToInt16(reader["IDADE"]);
                cliente.Sexo = reader["SEXO"].ToString();
                cliente.Nacionalidade = reader["NACIONALIDADE"].ToString();
                clientes.Add(cliente);
            }
            conn.Close();
        }

        private void ClearFull()
        {
            nomeClientetextbox.Text = "";
            cpfClientetextbox.Text = "";
            rgCLientetextbox.Text = "";
            idadeClientetextbox.Text = "";
            sexoClientetextbox.Text = "";
            nacionalidadeClientetextbox.Text = "";
        }

        private void cadastraClientebutton_Click(object sender, EventArgs e)
        {
            clientes.ForEach(i =>
            {
                if (i.Cpf == cpfClientetextbox.Text)
                {
                    MessageBox.Show("CPF inválido!");
                    cadastraClientebutton_Click( sender, e);
                }
                else
                {
                    cliente.Nome = nomeClientetextbox.Text;
                    cliente.Cpf = cpfClientetextbox.Text;
                    cliente.Rg = rgCLientetextbox.Text;
                    cliente.Idade = Convert.ToInt16(idadeClientetextbox.Text);
                    cliente.Sexo = sexoClientetextbox.Text;
                    cliente.Nacionalidade = nacionalidadeClientetextbox.Text;
                    clientes.Add(cliente);
                    AddTableCliente();
                    MessageBox.Show("Cadastrado com Sucesso!");             
                }
            });      
        }     

       private void AddTableCliente()
        {
            var conn = Conectar();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO CLIENTE (NOME,CPF,RG,IDADE,SEXO,NACIONALIDADE) VALUES (@NOME,@CPF,@RG,@IDADE,@SEXO,@NACIONALIDADE)";
            cmd.Parameters.Add(new SqlParameter("@NOME", cliente.Nome));
            cmd.Parameters.Add(new SqlParameter("@CPF", cliente.Cpf));
            cmd.Parameters.Add(new SqlParameter("@RG", cliente.Rg));
            cmd.Parameters.Add(new SqlParameter("@IDADE", cliente.Idade));
            cmd.Parameters.Add(new SqlParameter("@SEXO", cliente.Sexo));
            cmd.Parameters.Add(new SqlParameter("@NACIONALIDADE", cliente.Nacionalidade));
            cmd.ExecuteNonQuery();
            ClearFull();
        }
        

        

        private void viewbutton_Click(object sender, EventArgs e)
        {
            string nomes = "";
            foreach (Cliente c in clientes)
                nomes += c.Nome + " " + c.Cpf + "\n";
            MessageBox.Show(nomes);
        }
    }
}
