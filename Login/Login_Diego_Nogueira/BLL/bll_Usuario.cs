using System.Data;
using System.Windows.Forms;
using CamadaDados;
using CamadaTrasferenciaDados;

namespace CamadaNegocio
{
    class bll_Usuario
    {
        ConexaoBD bd = new ConexaoBD();
        string sql;

        public void InserirUsuario(dto_Usuario usuario)
        {
            sql = string.Format("insert into usuarios values(null,'{0}','{1}','{2}')", usuario.Nome, usuario.Login, usuario.Senha);
            bd.Alterar(sql);
        }

        public void ExcluirUsuario(dto_Usuario usuario)
        {
            sql = string.Format("delete from usarios where id = '{0}'", usuario.Id);
            bd.Alterar(sql);
        }

        public DataTable ConsultarUsuario()
        {
            sql = string.Format("select * from usuarios");
            return bd.Consultar(sql);
        }

        public void AlterarUsuario(dto_Usuario usuario)
        {
            sql = string.Format("update usuarios set nome '{0}', login '{1}', senha '{2}' where id = '{3}'",
                                    usuario.Nome, usuario.Login, usuario.Senha, usuario.Id);
            bd.Alterar(sql);
        }

        public dto_Usuario BuscarUsuario(dto_Usuario usuario)
        {
            sql = string.Format("select * from usuarios where id = '{0}'", usuario.Id);
            DataTable dados = bd.Consultar(sql);
            if (dados.Rows.Count > 0)
            {
                usuario.Nome = dados.Rows[0]["nome"].ToString();
                usuario.Login = dados.Rows[0]["login"].ToString();
                usuario.Senha = dados.Rows[0]["senha"].ToString();
            }

            return usuario;
        }

    }
}
