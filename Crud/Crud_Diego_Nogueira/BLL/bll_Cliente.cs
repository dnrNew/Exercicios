using System;
using System.Data;
using System.Windows.Forms;
using CamadaTransfDados;
using CamadaDados;

namespace CamadaNegocio
{
    class bll_Cliente
    {
        ConexaoBD bd = new ConexaoBD();
        string sql;

        public void InserirCliente(dto_Cliente d_cliente)
        {
            sql = string.Format("insert into cliente values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                                d_cliente.Nome, d_cliente.Endereco, d_cliente.Bairro, d_cliente.Cidade, d_cliente.Cpf, d_cliente.Cep, d_cliente.Uf, d_cliente.TelefoneRes, d_cliente.TelefoneCel, d_cliente.Email);
            bd.Alterar(sql);
        }

        public void ExcluirCliente(dto_Cliente d_cliente)
        {
            sql = string.Format("delete from cliente where id = '{0}'", d_cliente.Id);
            bd.Alterar(sql);
        }

        public void AlterarCliente(dto_Cliente d_cliente)
        {
            sql = string.Format("update cliente set nome = '{0}', endereco = '{1}', bairro = '{2}', cidade = '{3}', cpf = '{4}', cep = '{5}'," +
                                "uf = '{6}', telefoneResidencial = '{7}', TelefoneCelular = '{8}', email = '{9}' where id = '{10}'",
                               d_cliente.Nome, d_cliente.Endereco, d_cliente.Bairro, d_cliente.Cidade, d_cliente.Cpf, d_cliente.Cep, d_cliente.Uf, d_cliente.TelefoneRes,
                               d_cliente.TelefoneCel, d_cliente.Email, d_cliente.Id);
            bd.Alterar(sql);
        }

        public dto_Cliente BuscarCliente(dto_Cliente d_cliente)
        {
            sql = string.Format("select * from cliente where id = '{0}'", d_cliente.Id);
            DataTable dados = bd.Consultar(sql);

            if (dados.Rows.Count > 0)
            {
                d_cliente.Nome = dados.Rows[0]["nome"].ToString();
                d_cliente.Endereco = dados.Rows[0]["endereco"].ToString();
                d_cliente.Bairro = dados.Rows[0]["bairro"].ToString();
                d_cliente.Cidade = dados.Rows[0]["cidade"].ToString();
                d_cliente.Cpf = long.Parse(dados.Rows[0]["cpf"].ToString());
                d_cliente.Cep = int.Parse(dados.Rows[0]["cep"].ToString());
                d_cliente.Uf = dados.Rows[0]["uf"].ToString();
                d_cliente.TelefoneRes = long.Parse(dados.Rows[0]["telefoneResidencial"].ToString());
                d_cliente.TelefoneCel = long.Parse(dados.Rows[0]["TelefoneCelular"].ToString());
                d_cliente.Email = dados.Rows[0]["email"].ToString();
            }

            else
                d_cliente.Id = 0;

            return d_cliente;
        }

        public DataTable ListarCliente()
        {
            try
            {
                sql = string.Format("select id, nome, endereco, bairro, cidade, lpad(cpf, 11,'0') as cpf,  cep, uf, telefoneCelular, telefoneResidencial, email from cliente");
                DataTable dados = bd.Consultar(sql);

                return dados;
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
                throw erro;               
            }
        }
        
    }
}
