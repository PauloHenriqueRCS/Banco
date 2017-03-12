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
        public CadastroCliente()
        {           
            InitializeComponent();
        }
        private void Cadastro_Load(object sender, EventArgs e)
        {
            CommandSQL.SelectCliente();
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
            CommandSQL.clientes.ForEach(i =>
            {
                if (i.Cpf == cpfClientetextbox.Text)
                {
                    MessageBox.Show("CPF inválido!");
                    cadastraClientebutton_Click( sender, e);
                }
                else
                {
                    CommandSQL.cliente.Nome = nomeClientetextbox.Text;
                    CommandSQL.cliente.Cpf = cpfClientetextbox.Text;
                    CommandSQL.cliente.Rg = rgCLientetextbox.Text;
                    CommandSQL.cliente.Idade = Convert.ToInt16(idadeClientetextbox.Text);
                    CommandSQL.cliente.Sexo = sexoClientetextbox.Text;
                    CommandSQL.cliente.Nacionalidade = nacionalidadeClientetextbox.Text;
                    CommandSQL.clientes.Add(CommandSQL.cliente);              
                    CommandSQL.InsertCliente();
                    ClearFull();
                    MessageBox.Show("Cadastrado com Sucesso!");             
                }
            });      
        }     
        private void viewbutton_Click(object sender, EventArgs e)
        {
            string nomes = "";
            foreach (Cliente c in CommandSQL.clientes)
                nomes += c.Nome + " " + c.Cpf + "\n";
            MessageBox.Show(nomes);
        }
    }
}
