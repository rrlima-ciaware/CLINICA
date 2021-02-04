using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CLINICA
{
    public class Funcionarios
    {

        public int CodFuncionario { get; set; }
        public string NomFuncionario { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int CodCargo { get; set; }
        public string Cargo { get; set; }
        public int CodEspecialidade { get; set; }
        public string Especialidade { get; set; }
        public string NumDoc { get; set; }

        public DataTable listarFuncionarios()
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
                    da.SelectCommand.CommandText = "SELECT TBL_FUNCIONARIO.COD_FUNCIONARIO, TBL_FUNCIONARIO.NOM_FUNCIONARIO, TBL_FUNCIONARIO.ENDERECO, " +
                        " TBL_FUNCIONARIO.TELEFONE, TBL_FUNCIONARIO.COD_CARGO, TBL_FUNCIONARIO.COD_ESPECIALIDADE, TBL_ESPECIALIDADES.NOM_ESPECIALIDADE, " +
                        " TBL_FUNCIONARIO.NUM_DOC, TBL_CARGO.NOM_CARGO FROM TBL_FUNCIONARIO, TBL_CARGO, TBL_ESPECIALIDADES " +
                        " WHERE TBL_FUNCIONARIO.COD_CARGO = TBL_CARGO.COD_CARGO AND " +
                        " TBL_FUNCIONARIO.COD_ESPECIALIDADE = TBL_ESPECIALIDADES.COD_ESPECIALIDADE ";
                    da.Fill(dt);

                }

                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar funcionários." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }

        public void cadastrarFuncionario(Funcionarios funcionarios)
        {
            try
            {
                if (Conexao.conectarBanco())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Conexao.con;
                        cmd.CommandText = "INSERT INTO TBL_FUNCIONARIO( " +
                            " NOM_FUNCIONARIO, ENDERECO, TELEFONE, COD_CARGO, COD_ESPECIALIDADE, NUM_DOC) " +
                            "VALUES(@NOM_FUNCIONARIO, @ENDERECO, @TELEFONE, @COD_CARGO, @COD_ESPECIALIDADE, @NUM_DOC)";

                        cmd.Parameters.AddWithValue("@NOM_FUNCIONARIO", funcionarios.NomFuncionario);
                        cmd.Parameters.AddWithValue("@ENDERECO", funcionarios.Endereco);
                        cmd.Parameters.AddWithValue("@TELEFONE", funcionarios.Telefone);
                        cmd.Parameters.AddWithValue("@COD_CARGO", funcionarios.CodCargo);
                        cmd.Parameters.AddWithValue("@COD_ESPECIALIDADE", funcionarios.CodEspecialidade);
                        cmd.Parameters.AddWithValue("@NUM_DOC", funcionarios.NumDoc);
                        
                        cmd.ExecuteNonQuery();
                  
                        MessageBox.Show("Funcionário cadastrado com sucesso!",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


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


        public void alterarFuncionario(Funcionarios funcionarios)
        {
            try
            {
                if (Conexao.conectarBanco())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Conexao.con;
                        cmd.CommandText = "UPDATE TBL_FUNCIONARIO " +
                            " SET NOM_FUNCIONARIO = @NOM_FUNCIONARIO, ENDERECO = @ENDERECO, " +
                            " TELEFONE = @TELEFONE, COD_CARGO = @COD_CARGO, COD_ESPECIALIDADE = @COD_ESPECIALIDADE, " +
                            " NUM_DOC = @NUM_DOC WHERE COD_FUNCIONARIO = @COD_FUNCIONARIO";

                        cmd.Parameters.AddWithValue("@COD_FUNCIONARIO", funcionarios.CodFuncionario);
                        cmd.Parameters.AddWithValue("@NOM_FUNCIONARIO", funcionarios.NomFuncionario);
                        cmd.Parameters.AddWithValue("@ENDERECO", funcionarios.Endereco);
                        cmd.Parameters.AddWithValue("@TELEFONE", funcionarios.Telefone);
                        cmd.Parameters.AddWithValue("@COD_CARGO", funcionarios.CodCargo);
                        cmd.Parameters.AddWithValue("@COD_ESPECIALIDADE", funcionarios.CodEspecialidade);
                        cmd.Parameters.AddWithValue("@NUM_DOC", funcionarios.NumDoc);
                        cmd.ExecuteNonQuery();
                     
                        MessageBox.Show("Funcionário alterado com sucesso!",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao alterar funcionário." + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexao.fecharConexao();
            }
        }


    }
}
