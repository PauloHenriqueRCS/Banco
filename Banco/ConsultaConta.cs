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
    public partial class ConsultaConta : Form
    {
        private const string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BancoDB.mdf;Integrated Security = True";
        private List<Conta> contas = new List<Conta>();
        private List<Cliente> clientes = new List<Cliente>();
        private Conta conta;
        private Cliente cliente;
        Home home;

        private SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
            return conn;
        }

        public ConsultaConta()
        {
            InitializeComponent();
            
        }

        private void ConsultaConta_Load(object sender, EventArgs e)
        {
            var conn = Conectar();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TITULAR, TIPO, NUMERO, SALDO FROM CONTA";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Conta conta = new Conta();
                conta.Titular = reader["TITULAR"].ToString();
                conta.Numero = Convert.ToInt16(reader["NUMERO"]);
                conta.Saldo = Convert.ToDouble(reader["IDADE"]);
                contas.Add(conta);
            }

         /*   home = form;
            titularContatextbox.Text = home.cpfHometextBox.Text.ToString();

            contas.ForEach(item =>
            {
                if (item.Titular == titularContatextbox.Text)
                {
                    buscacomboBox.Items.Add(conta.Titular);

                }

                else
                {

                }


            });*/
        }

        private void depositabutton_Click(object sender, EventArgs e)
        {
            if (valorContatextbox.Text == "")
                MessageBox.Show("Declare um Valor!");
            else
            {
                conta.Deposita(Convert.ToDouble(valorContatextbox.Text));
                saldoContatextbox.Text = Convert.ToString(conta.Saldo);
                var conn = Conectar();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE CONTA SET SALDO += SALDO WHERE TITULAR = @TITULAR;";               
                cmd.Parameters.Add(new SqlParameter("@SALDO", conta.Saldo));
                cmd.ExecuteNonQuery();
                valorContatextbox.Text = "";
                MessageBox.Show("Deposito Realizado com Sucesso!");
            }
        }

        private void sacabutton_Click(object sender, EventArgs e)
        {
            if (valorContatextbox.Text == "")
                MessageBox.Show("Declare um Valor!");
            else
            {
                conta.Saca(Convert.ToDouble(valorContatextbox.Text));
                saldoContatextbox.Text = Convert.ToString(conta.Saldo);
                var conn = Conectar();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE CONTA SET SALDO -= SALDO WHERE TITULAR = @TITULAR;";
                cmd.Parameters.Add(new SqlParameter("@SALDO", conta.Saldo));
                cmd.ExecuteNonQuery();
                valorContatextbox.Text = "";
                MessageBox.Show("Saque Realizado com Sucesso!");
            }
        }

        private void numerocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           

/*
            foreach (Conta conta in contas)
            {
                buscacomboBox.Items.Add(conta.Titular.nome);
            }
            titularContatextbox.Text = conta.Titular.cpf;
            numeroContatextbox.Text = Convert.ToString(conta.Numero);
            saldoContatextbox.Text = Convert.ToString(conta.Saldo);*/
        }
    }
}
