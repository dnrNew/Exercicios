using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//MySQL
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;


namespace Vendas_Diego_Nogueira
{
    class ConexaoBD
    {
        private MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection("Persist Security info = false; server = localhost; database = bd_Vendas; user = root; pwd = ;");
                conexao.Open();
            }

            catch (Exception)
            {
                throw;
            }
        }

        //Insert - Delete - Update
        public int Alterar(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                return cmd.ExecuteNonQuery();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                conexao.Close();
            }

        }

        // Select
        public DataTable Consultar(string sql)
        {
            try
            {
                Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao); // da variável para o select
                DataTable dt = new DataTable(); // dt resultado select
                da.Fill(dt);
                return dt;
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                conexao.Close();
            }
        }


    }
}
