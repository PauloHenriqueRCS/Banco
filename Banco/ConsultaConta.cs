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
       public Home home = new Home();

        public ConsultaConta()
        {
            InitializeComponent();
            titularContatextbox.Text = home.cpfHometextBox.Text.ToString();                                
        }

        private void ConsultaConta_Load(object sender, EventArgs e)
        {
            
            CommandSQL.SelectConta();
            CommandSQL.contas.ForEach(item =>
            {
                if (item.Titular == titularContatextbox.Text)
                {
                    numerocomboBox.Items.Add(CommandSQL.conta.Numero);
                    titularContatextbox.Text = CommandSQL.conta.Titular;
                    saldoContatextbox.Text = CommandSQL.conta.Saldo.ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não possui conta!");
                }
            });
        }

        private void depositabutton_Click(object sender, EventArgs e)
        {
            CommandSQL.conta.Deposita(Convert.ToDouble(valorContatextbox.Text));
            CommandSQL.DepositaConta();
        }

        private void sacabutton_Click(object sender, EventArgs e)
        {
           /* if (valorContatextbox.Text == "")
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
            }*/
        }

        private void numerocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void novaContabutton_Click(object sender, EventArgs e)
        {
            CadastroConta cadastroconta = new CadastroConta();
            cadastroconta.ShowDialog();


        }
    }
}
