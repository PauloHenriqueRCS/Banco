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
     
       // CommandSQL commandsql = new CommandSQL();      
        public Home()
        {
            InitializeComponent();
        }      
        private void Home_Load(object sender, EventArgs e)
        {
            CommandSQL.SelectCliente();
        }
        private void loginHomebutton_Click(object sender, EventArgs e)
        {         
            //string NOME = nomeHometextBox.Text;
            string CPF = cpfHometextBox.Text;

            CommandSQL.clientes.ForEach(i =>
            {
                if (i.Cpf == CPF)
                {
                    MessageBox.Show("Login com Sucesso!");
                    //ConsultaConta formconsultaconta = new ConsultaConta(this);
                    //formconsultaconta.ShowDialog();

                    ConsultaConta formconsultaconta = new ConsultaConta();
                    formconsultaconta.home = this;
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

