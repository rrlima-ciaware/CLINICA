using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CLINICA
{
    public class Cargos
    {

        public int CodCargo { get; set; }
        public string NomCargo { get; set; }
        public string DocCargo { get; set; }

        public DataTable listarCargos()
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
                    da.SelectCommand.CommandText = "SELECT COD_CARGO, NOM_CARGO, DOC_CARGO " +
                        " FROM TBL_CARGO";
                    da.Fill(dt);

                }

                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar cargos." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }

        public void cadastrarCargo(Cargos cargos)
        {
            try
            {
                if (Conexao.conectarBanco())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Conexao.con;
                        cmd.CommandText = "INSERT INTO TBL_CARGO( " +
                            " NOM_CARGO, DOC_CARGO) " +
                            " VALUES(@NOM_CARGO, @DOC_CARGO)";

                        
                        cmd.Parameters.AddWithValue("@NOM_CARGO", cargos.NomCargo);
                        cmd.Parameters.AddWithValue("@DOC_CARGO", cargos.DocCargo);
                        cmd.ExecuteNonQuery();

                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar cargo." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }


        public void alterarCargo(Cargos cargos)
        {
            try
            {
                if (Conexao.conectarBanco())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Conexao.con;
                        cmd.CommandText = "UPDATE TBL_CARGO " +
                            " SET NOM_CARGO = @NOM_CARGO, DOC_CARGO = @DOC_CARGO " +
                            " WHERE COD_CARGO = @COD_CARGO";

                        cmd.Parameters.AddWithValue("@COD_CARGO", cargos.CodCargo);
                        cmd.Parameters.AddWithValue("@NOM_CARGO", cargos.NomCargo);
                        cmd.Parameters.AddWithValue("@DOC_CARGO", cargos.DocCargo);
                        cmd.ExecuteNonQuery();

                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao alterar cargo." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexao.fecharConexao();
            }
        }


    }
}
