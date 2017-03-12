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
        public CadastroConta()
        {
            InitializeComponent();
        }
        private void CadastroConta_Load(object sender, EventArgs e)
        {
            CommandSQL.SelectConta();
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
                    CommandSQL.conta = new Corrente();
                    CommandSQL.clientes.ForEach(item =>
                    {
                        if (item.Cpf == titularCContatextBox.Text)
                        {

                            CommandSQL.conta.Titular = titularCContatextBox.Text;
                            CommandSQL.conta.Numero = Convert.ToInt16(numeroCContatextBox.Text);
                            CommandSQL.conta.Saldo = Convert.ToDouble(saldoCContatextBox.Text);
                            CommandSQL.contas.Add(CommandSQL.conta);
                            CommandSQL.InsertConta();
                            ClearFull();
                            MessageBox.Show("Conta Corrente Criada com Sucesso!");
                        }
                    });

                    ClearFull();
                }
                else if (poupancaradioButton.Checked)
                {
                    CommandSQL.conta = new Poupanca();
                    CommandSQL.clientes.ForEach(item =>
                    {
                        if (item.Cpf == titularCContatextBox.Text)
                        { 
                        CommandSQL.conta.Titular = titularCContatextBox.Text;
                        CommandSQL.conta.Numero = Convert.ToInt16(numeroCContatextBox.Text);
                        CommandSQL.conta.Saldo = Convert.ToDouble(saldoCContatextBox.Text);
                        CommandSQL.contas.Add(CommandSQL.conta);
                        CommandSQL.InsertConta();
                        ClearFull();
                        MessageBox.Show("Conta Corrente Criada com Sucesso!");
                    }
                    });
                }
                else
                {
                    MessageBox.Show("Defina o Tipo de Conta!");
                }
            }
        }

        private void contasbutton_Click(object sender, EventArgs e)
        {
            string nomes = "";
            //string saldos = "";
            foreach (Conta c in CommandSQL.contas)
                nomes += c.Titular + " " + c.Saldo + "\n";
            MessageBox.Show(nomes);
        }
    }
}
