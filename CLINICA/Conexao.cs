using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; //Biblioteca para trabalho com banco de dados
using System.Data.SqlClient; //Biblioteca específica para o SQL SERVER
using System.Windows.Forms;


namespace CLINICA
{
    public static class Conexao
    {
        //Propriedade responsável por armazenar a
        //Conexão com o banco de dados
        public static string stringConexao { get; set; }

        //Propriedade de conexão com o banco
        public static SqlConnection con { get; set; }

        private static int codUsuario;

        public static int CodUsuario
        {
            get { return codUsuario; }
            set { codUsuario = value; }
        }

        private static string nomUsuario;

        public static string NomUsuario
        {
            get { return nomUsuario.ToUpper(); }
            set { nomUsuario = value; }
        }

        private static string login;

        public static string Login
        {
            get { return login.ToUpper(); }
            set { login = value; }
        }

        private static char idfAtivo;

        public static char IdfAtivo
        {
            get { return idfAtivo; }
            set { idfAtivo = value; }
        }

        private static string select;

        public static string Select
        {
            get { return select; }
            set { select = value; }
        }
        

        public static bool conectarBanco()
        {
            //Método que realiza a conexão com o banco de dados
            try
            {
                stringConexao = @"Server=ADMIN-PC\SQLEXPRESS; Database=CLINICA; user=sa; password=admin; MultipleActiveResultSets=True";
                                
                con = new SqlConnection(stringConexao); //Criar/Instância o objeto de conexão com o banco 
                con.Open(); //Abre conexão com banco
                return true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de conexão com o banco. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Dispose(); //Retira o objeto con da memória
                return false;
            }

        }

        public static void fecharConexao()
        {
            //Verificar se a conexão está aberta
            if (con.State == ConnectionState.Open)
            {
                con.Close(); //Fecha a conexão
                con.Dispose(); //Retira objeto con da memória
            }
        }


        public static bool efetuarLogin(string paramLogin, string paramSenha)
        {

            int qtd = 0;
            CodUsuario = 0;
            NomUsuario = "";
            Login = "";

            try
            {
                if (conectarBanco())
                {
                    Select = "SELECT COUNT(*) FROM TBL_USUARIO WHERE LOGIN = @LOGIN";

                    using (var cmd = new SqlCommand(Select, con)) //Classe SqlCommand serve para executar comandos sql no banco
                    {
                        try
                        {
                            //Associa o valor informado pelo usuário na tela de login
                            //ao parâmetro @LOGIN da Select
                            cmd.Parameters.AddWithValue("@LOGIN", paramLogin);
                            qtd = (int)cmd.ExecuteScalar(); //Executa a consulta no banco de dados e retorna um valor determinado
                            cmd.Parameters.Clear();

                            
                            if (qtd == 1)
                            {
                                Login = paramLogin;

                                Select = "SELECT COD_USUARIO, NOM_USUARIO, LOGIN, IDF_ATIVO FROM TBL_USUARIO " +
                                    " WHERE LOGIN = @LOGIN AND SENHA = @SENHA";
                                cmd.CommandText = Select;

                                //Associa o valor informado pelo usuário na tela de login
                                //ao parâmetro @LOGIN e @SENHA da Select 
                                cmd.Parameters.AddWithValue("@LOGIN", paramLogin);
                                cmd.Parameters.AddWithValue("@SENHA", paramSenha);

                                //O componente SqlDataReader armazena o conjunto de
                                //linhas que a consulta do banco de dados retornou
                                SqlDataReader reader = cmd.ExecuteReader();

                                //Verifica se o objeto reader possui linhas, ou seja,
                                //se a consulta "Select" encontrou registro no banco
                                if (reader.HasRows) 
                                {
                                    while (reader.Read())
                                    {
                                        //CodUsuario = reader.GetInt32(0); (Esse comando tem
                                        //a mesma função da comando abaixo)
                                        CodUsuario = (int)reader["COD_USUARIO"];

                                        NomUsuario = (string)reader["NOM_USUARIO"];
                                        Login = (string)reader["LOGIN"];
                                        IdfAtivo = Convert.ToChar(reader["IDF_ATIVO"]);
                                        
                                    }

                                }

                            }

                        }
                        catch(SqlException ex)
                        {
                            MessageBox.Show("Erro ao efetuar login: " + ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            finally
            {
                fecharConexao();
            }

            if (CodUsuario != 0)
                return true;
            else
                return false;

            
        }


    }
}
