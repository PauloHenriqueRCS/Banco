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
    public partial class CadastroConta : Form
    {
        private const string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BancoDB.mdf;Integrated Security = True";
        private List<Conta> contas = new List<Conta>();
        private List<Cliente> clientes = new List<Cliente>();
        private Conta conta;
        private Cliente cliente;
        public CadastroConta()
        {
            InitializeComponent();
        }

        private SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
            return conn;
        }

        private void CadastroConta_Load(object sender, EventArgs e)
        {
            var conn = Conectar();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TITULAR, NUMERO, SALDO FROM CONTA";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Conta conta = new Conta();  
                conta.Id = Convert.ToInt16(reader["IDCONTA"]);
                conta.Titular = reader["TITULAR"].ToString();
                conta.Numero =  Convert.ToInt16(reader["NUMERO"]);
                conta.Saldo = Convert.ToDouble(reader["SALDO"].ToString());
                contas.Add(conta);
            }              
            conn.Close();
        }

        private void ClearFull()
        {
   
            titularCContatextBox.Text = "";
            numeroCContatextBox.Text = "";
            saldoCContatextBox.Text = "";
        }

        private void cadastraContabutton_Click(object sender, EventArgs e)
        {
            if (titularCContatextBox.Text == "" || numeroCContatextBox.Text == "" || saldoCContatextBox.Text == "")
                MessageBox.Show("Existem Campo em Branco, Por Favor Preencha-os!");
            else
            {
                if (correnteradioButton.Checked)
                {

                    conta = new Corrente();              
                    clientes.ForEach(item =>
                    {
                        if (item.Cpf == titularCContatextBox.Text)  
                        MessageBox.Show("CPF Invalido!");                          
                    
                        else
                        conta.Titular = titularCContatextBox.Text;
                        conta.Numero = Convert.ToInt16(numeroCContatextBox.Text);
                        conta.Saldo = Convert.ToDouble(saldoCContatextBox.Text);                       
                        contas.Add(conta);
                        AddTableConta();
                        MessageBox.Show("Conta Corrente Criada com Sucesso!");
                    });
                   
                    ClearFull();
                }

                else if (poupancaradioButton.Checked)
                {
                    conta = new Poupanca();
                    clientes.ForEach(item =>
                    {
                        if (item.Cpf == titularCContatextBox.Text)
                            MessageBox.Show("CPF Invalido!");

                        else
                        conta.Titular = titularCContatextBox.Text;
                        conta.Numero = Convert.ToInt16(numeroCContatextBox.Text);
                        conta.Saldo = Convert.ToDouble(saldoCContatextBox.Text);                      
                        contas.Add(conta);
                        AddTableConta();
                        MessageBox.Show("Conta Corrente Criada com Sucesso!");
                    });

                    ClearFull();

                }
                else
                {
                    MessageBox.Show("Defina o Tipo de Conta!");
                }
            }
        }

        private void AddTableConta()
        {
            var conn = Conectar();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO CONTA (IDTITULAR,NUMERO,SALDO) VALUES (@IDTITULAR,@NUMERO,@SALDO)";
            cmd.Parameters.Add(new SqlParameter("@IDTITULAR", conta.Titular));
            cmd.Parameters.Add(new SqlParameter("@NUMERO", conta.Numero));
            cmd.Parameters.Add(new SqlParameter("@SALDO", conta.Saldo));
            cmd.ExecuteNonQuery();
            ClearFull();
        }
    }
    
}
