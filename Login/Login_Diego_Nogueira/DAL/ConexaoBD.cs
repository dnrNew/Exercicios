using System;
using System.Data;
using MySql.Data.MySqlClient;


namespace CamadaDados
{
    class ConexaoBD
    {
        private MySqlConnection conexao;

        public void Conectar()
        {
            conexao = new MySqlConnection("Persist Security info = false; server = localhost; database = Cadastro_Produtos; user = root; pwd = ;");
            conexao.Open();
        }

        //Insert - Delete - Update
        public void Alterar(string sql)
        {
            Conectar();
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        // Select
        public DataTable Consultar(string sql)
        {
            Conectar();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao); // da variável para o select
            DataTable dt = new DataTable(); // dt resultado select
            da.Fill(dt);
            conexao.Close();
            return dt;
        }
    }
}
