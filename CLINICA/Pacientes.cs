using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CLINICA
{
    public class Pacientes
    {
        
        public int CodPaciente { get; set; }
        public string NomPaciente { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public DataTable dtPesquisa;

        public DataTable pesquisaPacientes()
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter();
                dtPesquisa= new DataTable();

                if (Conexao.conectarBanco())
                {
                    da.SelectCommand = new SqlCommand();
                    da.SelectCommand.Connection = Conexao.con;
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.SelectCommand.CommandText = "SELECT COD_PACIENTE, NOM_PACIENTE, CPF FROM TBL_PACIENTE";
                    da.Fill(dtPesquisa);

                }

                return dtPesquisa;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar pacientes." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }


        public DataTable listarPacientes(bool pesquisa = false)
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
                    da.SelectCommand.CommandText = "SELECT COD_PACIENTE, NOM_PACIENTE, ENDERECO, " +
                        " TELEFONE, EMAIL, CPF FROM TBL_PACIENTE";
                    da.Fill(dt);

                    if (pesquisa)
                        dtPesquisa = dt;
                    
                }
                                
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar pacientes." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }

        public void cadastrarPaciente(Pacientes pacientes)
        {
            try
            {
                if (Conexao.conectarBanco())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Conexao.con;
                        cmd.CommandText = "INSERT INTO TBL_PACIENTE( " +
                            " NOM_PACIENTE, ENDERECO, TELEFONE, EMAIL, CPF) " +
                            "VALUES(@NOM_PACIENTE, @ENDERECO, @TELEFONE, @EMAIL, @CPF)";

                        cmd.Parameters.AddWithValue("@NOM_PACIENTE", pacientes.NomPaciente);
                        cmd.Parameters.AddWithValue("@ENDERECO", pacientes.Endereco);
                        cmd.Parameters.AddWithValue("@TELEFONE", pacientes.Telefone);
                        cmd.Parameters.AddWithValue("@EMAIL", pacientes.Email);
                        cmd.Parameters.AddWithValue("@CPF", pacientes.CPF);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Paciente cadastrado com sucesso!",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar paciente." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }


        public void alterarPaciente(Pacientes pacientes)
        {
            try
            {
                if (Conexao.conectarBanco())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Conexao.con;
                        cmd.CommandText = "UPDATE TBL_PACIENTE " +
                            " SET NOM_PACIENTE = @NOM_PACIENTE, ENDERECO = @ENDERECO, " +
                            " TELEFONE = @TELEFONE, EMAIL = @EMAIL, CPF = @CPF " +
                            "WHERE COD_PACIENTE = @COD_PACIENTE";

                        cmd.Parameters.AddWithValue("@COD_PACIENTE", pacientes.CodPaciente);
                        cmd.Parameters.AddWithValue("@NOM_PACIENTE", pacientes.NomPaciente);
                        cmd.Parameters.AddWithValue("@ENDERECO", pacientes.Endereco);
                        cmd.Parameters.AddWithValue("@TELEFONE", pacientes.Telefone);
                        cmd.Parameters.AddWithValue("@EMAIL", pacientes.Email);
                        cmd.Parameters.AddWithValue("@CPF", pacientes.CPF);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Paciente alterado com sucesso!",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao alterar paciente." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }



        



    }
}
