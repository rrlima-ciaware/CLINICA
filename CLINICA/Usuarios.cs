using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CLINICA
{
    public class Usuarios
    {

        #region Atributos e propriedades

        public DataTable dtAux = new DataTable();

        private int codusuario;

        public int CodUsuario
        {
            get { return codusuario; }
            set { codusuario = value; }
        }


        private string nomusuario;

        public string NomUsuario
        {
            get { return nomusuario; }
            set { nomusuario = value; }
        }

        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }


        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private char idfativo;

        public char IdfAtivo
        {
            get { return idfativo; }
            set { idfativo = value; }
        }

        private DateTime dtacadastro;

        public DateTime DtaCadastro
        {
            get { return dtacadastro; }
            set { dtacadastro = value; }
        }

        #endregion

        #region Métodos
        public DataTable listarUsuarios()
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                if (Conexao.conectarBanco())
                {
                    da.SelectCommand = new SqlCommand();
                    da.SelectCommand.Connection = Conexao.con;
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.SelectCommand.CommandText = "SELECT COD_USUARIO, NOM_USUARIO, LOGIN, " +
                        " SENHA, IDF_ATIVO, DTA_CADASTRO FROM TBL_USUARIO";
                    da.Fill(dt);
                    dtAux = dt;
                }

                return dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar usuários." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }


        public void cadastrarUsuario(Usuarios usuarios)
        {
            try
            {
                if (Conexao.conectarBanco())
                {
                    using(var cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Conexao.con;
                        cmd.CommandText = "INSERT INTO TBL_USUARIO( " +
                            " NOM_USUARIO, LOGIN, SENHA, IDF_ATIVO, DTA_CADASTRO) " +
                            "VALUES(@NOM_USUARIO, @LOGIN, @SENHA, @IDF_ATIVO, GETDATE())";

                        cmd.Parameters.AddWithValue("@NOM_USUARIO", usuarios.NomUsuario);
                        cmd.Parameters.AddWithValue("@LOGIN", usuarios.Login);
                        cmd.Parameters.AddWithValue("@SENHA", usuarios.Senha);
                        cmd.Parameters.AddWithValue("@IDF_ATIVO", usuarios.IdfAtivo);
                        cmd.ExecuteNonQuery();
                        
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }


        public bool usuarioJaCadastrado(string login)
        {
            int qtd = 1;

            try
            {
                using (var cmd = new SqlCommand())
                {
                    if (Conexao.conectarBanco())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Conexao.con;
                        cmd.CommandText = "SELECT COUNT(*) FROM TBL_USUARIO " +
                            " WHERE LOGIN = @LOGIN ";

                        cmd.Parameters.AddWithValue("@LOGIN", login);
                        qtd = (int)cmd.ExecuteScalar();

                        if (qtd == 0)
                            return false;
                        else
                            return true;

                    }
                    else
                        return true;
                }
            }
            catch
            {
                return true;
            }
        }


        public bool excluirUsuario(int codUsuario)
        {
            try
            {
                Conexao.conectarBanco();

                using (var cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = Conexao.con;
                    cmd.CommandText = "DELETE FROM TBL_USUARIO WHERE COD_USUARIO = @COD_USUARIO";
                    cmd.Parameters.AddWithValue("@COD_USUARIO", codusuario);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }


        public void alterarUsuario(Usuarios usuarios)
        {
            try
            {
                if (Conexao.conectarBanco())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Conexao.con;
                        cmd.CommandText = "UPDATE TBL_USUARIO " +
                            " SET SENHA = @SENHA, IDF_ATIVO = @IDF_ATIVO " +
                            "WHERE COD_USUARIO = @COD_USUARIO";

                        cmd.Parameters.AddWithValue("@COD_USUARIO", usuarios.codusuario);
                        cmd.Parameters.AddWithValue("@SENHA", usuarios.Senha);
                        cmd.Parameters.AddWithValue("@IDF_ATIVO", usuarios.IdfAtivo);
                        cmd.ExecuteNonQuery();

                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
                
        #endregion



    }
}
