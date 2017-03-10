using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banco
{
    public partial class Home : Form
    {
        private const string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BancoDB.mdf;Integrated Security = True";
        private List<Cliente> clientes = new List<Cliente>();
        
        public Home()
        {
            InitializeComponent();
        }

        private SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
            return conn;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var conn = Conectar();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT NOME, CPF, RG, IDADE, SEXO, NACIONALIDADE FROM CLIENTE";       
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
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


        private void loginHomebutton_Click(object sender, EventArgs e)
        {

            
            string NOME = nomeHometextBox.Text;
            string CPF = cpfHometextBox.Text;

            clientes.ForEach(i =>
            {
                if (i.Cpf == CPF)
                    MessageBox.Show("CPF inválido!");
                else
                {
                    MessageBox.Show("Login com Sucesso!");
                    ConsultaConta formconsultaconta = new ConsultaConta();
                    formconsultaconta.ShowDialog();
                }
            
            });  


        }

        private void cadastrocHomebutton_Click(object sender, EventArgs e)
        {
            CadastroCliente forcadastrocliente = new CadastroCliente();
            forcadastrocliente.ShowDialog();

        }
    }
}

