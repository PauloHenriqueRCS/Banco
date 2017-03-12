using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Banco
{
    public class CommandSQL
    {
        private const string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BancoDB.mdf;Integrated Security = True";
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Conta> contas = new List<Conta>();
        public static Cliente cliente = new Cliente();
        public static Conta conta = new Conta();
        private static SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
            return conn;
        }

        public static void SelectCliente()
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

        public static void SelectConta()
        {
            var conn = Conectar();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TITULAR, TIPO, NUMERO, SALDO FROM CONTA";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Conta conta = new Conta();
                conta.Titular = reader["TITULAR"].ToString();
                conta.Tipo = Convert.ToInt16(reader["TIPO"]);
                conta.Numero = Convert.ToInt16(reader["NUMERO"]);
                conta.Saldo = Convert.ToDouble(reader["IDADE"]);
                contas.Add(conta);
            }
            conn.Close();
        }

        public static void InsertCliente()
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
            conn.Close();
        }

        public static void InsertConta()
        {
            var conn = Conectar();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO CONTA ( TITULAR, TIPO, NUMERO, SALDO ) VALUES ( @TITULAR, @TIPO, @NUMERO, @SALDO )";
            cmd.Parameters.Add(new SqlParameter("@TITULAR", conta.Titular));
            cmd.Parameters.Add(new SqlParameter("@TIPO", conta.Tipo));
            cmd.Parameters.Add(new SqlParameter("@NUMERO", conta.Numero));
            cmd.Parameters.Add(new SqlParameter("@SALDO", conta.Saldo));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DepositaConta()
        {
            var conn = Conectar();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE CONTA SET SALDO = SALDO";
            cmd.Parameters.Add(new SqlParameter("@SALDO", conta.Saldo));
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}
