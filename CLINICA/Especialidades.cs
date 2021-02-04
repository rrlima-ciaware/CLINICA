using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CLINICA
{
    public class Especialidades
    {
        public int CodEspecialidade { get; set; }
        public string NomEspecialidade { get; set; }

        public DataTable listarEspecialidades()
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
                    da.SelectCommand.CommandText = "SELECT COD_ESPECIALIDADE, NOM_ESPECIALIDADE " +
                        " FROM TBL_ESPECIALIDADES";
                    da.Fill(dt);

                }

                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar especialidades." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }

        public void cadastrarEspecialide(Especialidades especialidades)
        {
            try
            {
                if (Conexao.conectarBanco())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Conexao.con;
                        cmd.CommandText = "INSERT INTO TBL_ESPECIALIDADES( " +
                            " NOM_ESPECIALIDADE) " +
                            " VALUES(@NOM_ESPECIALIDADE)";


                        cmd.Parameters.AddWithValue("@NOM_ESPECIALIDADE", especialidades.NomEspecialidade);
                        cmd.ExecuteNonQuery();

                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar especialidade." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }


        public void alterarEspecialidade(Especialidades especilidades)
        {
            try
            {
                if (Conexao.conectarBanco())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Conexao.con;
                        cmd.CommandText = "UPDATE TBL_ESPECIALIDADES " +
                            " SET NOM_ESPECIALIDADE = @NOM_ESPECIALIDADE" +
                            " WHERE COD_ESPECIALIDADE = @COD_ESPECIALIDADE";

                        cmd.Parameters.AddWithValue("@COD_ESPECIALIDADE", especilidades.CodEspecialidade);
                        cmd.Parameters.AddWithValue("@NOM_ESPECIALIDADE", especilidades.NomEspecialidade);
                        cmd.ExecuteNonQuery();

                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao alterar especilidade." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexao.fecharConexao();
            }
        }


    }
}
