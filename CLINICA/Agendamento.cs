using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CLINICA
{
    class Agendamento
    {

  
        public int DiaSemana { get; set; }
        public int NumAgenda { get; set; }
        public int CodPaciente { get; set; }
        public int CodFuncionarioAgenda { get; set; }
        public DateTime DtaConsulta { get; set; }
        public TimeSpan HrConsulta { get; set; }
        public char IdfEncaixe { get; set; }
        public string ObsAtendimento { get; set; }

        public DataTable buscarAgenda(int profissional = 0)
        {
            var dt = new DataTable();

            try
            {

                if (Conexao.conectarBanco())
                {

                    using (var da = new SqlDataAdapter())
                    {

                        da.SelectCommand = new SqlCommand();
                        da.SelectCommand.Connection = Conexao.con;
                        da.SelectCommand.CommandType = CommandType.Text;
                        da.SelectCommand.CommandText = "SELECT A.NUM_AGENDA, A.COD_FUNCIONARIO, A.COD_PACIENTE, F.NOM_FUNCIONARIO, " +
                                                       " P.NOM_PACIENTE, A.DTA_CONSULTA, A.HR_CONSULTA, A.IDF_ENCAIXE " +
                                                       " FROM TBL_AGENDA A, TBL_FUNCIONARIO F, TBL_PACIENTE P " +
                                                       " WHERE F.COD_FUNCIONARIO = A.COD_FUNCIONARIO AND P.COD_PACIENTE = A.COD_FUNCIONARIO " +
                                                       " AND A.COD_FUNCIONARIO = @COD_FUNCIONARIO " +
                                                       " ORDER BY A.DTA_CONSULTA, A.HR_CONSULTA, F.NOM_FUNCIONARIO, P.NOM_PACIENTE";

                        da.SelectCommand.Parameters.AddWithValue("@COD_FUNCIONARIO", profissional);
                        da.Fill(dt);
                        da.SelectCommand.Parameters.Clear();

                    }


                }

                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar agenda!" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;             
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }


        public bool horarioDisponivel(DateTime data, TimeSpan horario, int profissional)
        {
            int i;

            try
            {

                using (var cmd1 = new SqlCommand())
                {

                    cmd1.Connection = Conexao.con;
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "SELECT COUNT(*) FROM TBL_AGENDA A WHERE A.DTA_CONSULTA = @DTA_CONSULTA " +
                                       " AND CONVERT(VARCHAR,A.HR_CONSULTA) = @HR_CONSULTA AND A.COD_FUNCIONARIO = @COD_FUNCIONARIO";


                    cmd1.Parameters.AddWithValue("@DTA_CONSULTA", data);
                    cmd1.Parameters.AddWithValue("@HR_CONSULTA", horario.ToString());
                    cmd1.Parameters.AddWithValue("@COD_FUNCIONARIO", profissional);

                    i = (int)cmd1.ExecuteScalar();
                    cmd1.Parameters.Clear();

                    if (i == 0)
                        return true;
                    else
                        return false;

                }
            }
            catch (SqlException ex)
            {
                i = 1;
                MessageBox.Show("Erro ao verificar disponibilidade do horário!" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }             

        }


        public DataTable DisponibilidadeAgenda(DateTime dtaIni, DateTime dtaFim, int profissional)
        {
            var dt = new DataTable();
            DateTime dtaIniAux = dtaIni;
            DateTime dtaFimAux = dtaFim;
            //var cmdAux = new SqlCommand();

            if (Conexao.conectarBanco())
            {
                TimeSpan hrIni;
                TimeSpan hrFim;
                string intervalo;
                

                dt.Columns.Add("Data", typeof(DateTime));
                dt.Columns.Add("DiaSemana", typeof(int));
                dt.Columns.Add("NomeDiaSemana", typeof(string));
                dt.Columns.Add("Horario", typeof(TimeSpan));
                dt.Columns.Add("QtdVagas", typeof(int));
                
                using (var cmd = new SqlCommand())
                {

                     cmd.Connection = Conexao.con;
                     cmd.CommandType = CommandType.Text;
                     cmd.CommandText = "SELECT F.COD_FUNCIONARIO, F.NOM_FUNCIONARIO, CHA.DIA_SEMANA, " +
                                       " CHA.DTA_INICIO_VIGENCIA, CHA.DTA_FIM_VIGENCIA, CHA.HR_INI_ATENDIMENTO, " +
                                       " CHA.HR_FIM_ATENDIMENTO,  CHA.IDF_ATIVA, CHA.QTD_VAGAS_PERMITIDAS, " +
                                       " CHA.TMP_INTERVALO FROM TBL_FUNCIONARIO F, TBL_CONFIG_AGENDA_MEDICO CAM, " +
                                       " TBL_CONFIG_HORARIO_AGENDA CHA WHERE CHA.COD_AGENDA_MEDICO = CAM.COD_AGENDA_MEDICO " +
                                       " AND CAM.COD_FUNCIONARIO = F.COD_FUNCIONARIO AND CHA.DTA_INICIO_VIGENCIA <= @DTAINI " +
                                       " AND CHA.DTA_FIM_VIGENCIA >= @DTAFIM AND CAM.COD_FUNCIONARIO = @COD_FUNCIONARIO ";

                    
                     cmd.Parameters.AddWithValue("@DTAINI", dtaIni);
                     cmd.Parameters.AddWithValue("@DTAFIM", dtaFim);
                     cmd.Parameters.AddWithValue("@COD_FUNCIONARIO" , profissional);

                     SqlDataReader reader = cmd.ExecuteReader();

                     if (reader.HasRows)
                     {                        

                         while (reader.Read())
                         {

                             dtaIniAux = dtaIni;                            

                             while (dtaIniAux <= dtaFimAux)
                             {
                                 //int diaSemana = ;
                                 //int j = (int)reader["DIA_SEMANA"]; 

                                 if ((int)dtaIniAux.DayOfWeek + 1 == (int)reader["DIA_SEMANA"])
                                 {

                                     hrIni = (TimeSpan)reader["HR_INI_ATENDIMENTO"];
                                     hrFim = (TimeSpan)reader["HR_FIM_ATENDIMENTO"];
                                     intervalo = reader["TMP_INTERVALO"].ToString();

                                     while (hrIni <= hrFim)
                                     {
                                        if (horarioDisponivel(dtaIniAux, hrIni, profissional))
                                         {
                                             DataRow row = dt.NewRow();

                                             row["Data"] = dtaIniAux;
                                             row["DiaSemana"] = (int)reader["DIA_SEMANA"];
                                             row["NomeDiaSemana"] = NomeDiaSemana((int)reader["DIA_SEMANA"]);
                                             row["Horario"] = hrIni;
                                             row["QtdVagas"] = (int)reader["QTD_VAGAS_PERMITIDAS"];
                                             dt.Rows.Add(row);
                                         }

                                         //MessageBox.Show(hrIni.ToString(), "Aviso");
                                         hrIni += TimeSpan.Parse(intervalo);



                                     }
                                 }

                                 dtaIniAux = dtaIniAux.AddDays(1);
                             }
 

                         }

                         cmd.Parameters.Clear();

                     }

                     dt.DefaultView.Sort = "Data";

                }


                

            }

            return dt;

        }


        public string NomeDiaSemana(int dia)
        {
            string nome = "";

            switch (dia)
            {
                case 1: 
                    nome = "DOMINGO";
                    break;
                case 2: 
                    nome = "SEGUNDA-FEIRA";
                    break;
                case 3:
                    nome = "TERÇA-FEIRA";
                    break;
                case 4:
                    nome = "QUARTA-FEIRA";
                    break;
                case 5:
                    nome = "QUINTA-FEIRA";
                    break;
                case 6:
                    nome = "SEXTA-FEIRA";
                    break;
                case 7:
                    nome = "SÁBADO";
                    break;

            }
            
            return nome;
           
        }

        public int NumeroDiaSemana(string dia)
        {
            int num = 0;

            switch (dia)
            {
                case "DOMINGO":
                    num = 1;
                    break;
                case "SEGUNDA-FEIRA":
                    num = 2;
                    break;
                case "TERÇA-FEIRA":
                    num = 3;
                    break;
                case "QUARTA-FEIRA":
                    num = 4;
                    break;
                case "QUINTA-FEIRA":
                    num = 5;
                    break;
                case "SEXTA-FEIRA":
                    num = 6;
                    break;
                case "SÁBADO":
                    num = 7;
                    break;

            }

            return num;

        }

        public void agendarPaciente(Agendamento agendamento)
        {
            try
            {
                if (Conexao.conectarBanco())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Conexao.con;
                        cmd.CommandText = "INSERT INTO TBL_AGENDA( " +
                            " COD_PACIENTE, COD_FUNCIONARIO, DTA_CONSULTA, HR_CONSULTA, IDF_ENCAIXE, DIA_SEMANA) " +
                            "VALUES(@COD_PACIENTE, @COD_FUNCIONARIO, @DTA_CONSULTA, @HR_CONSULTA, @IDF_ENCAIXE, @DIASEMANA)";


                        cmd.Parameters.AddWithValue("@COD_FUNCIONARIO", agendamento.CodFuncionarioAgenda);
                        cmd.Parameters.AddWithValue("@COD_PACIENTE", agendamento.CodPaciente);
                        cmd.Parameters.AddWithValue("@DTA_CONSULTA", agendamento.DtaConsulta);
                        cmd.Parameters.AddWithValue("@HR_CONSULTA", agendamento.HrConsulta);
                        cmd.Parameters.AddWithValue("@IDF_ENCAIXE", agendamento.IdfEncaixe);
                        cmd.Parameters.AddWithValue("@DIASEMANA", agendamento.DiaSemana);                       
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Paciente agendado com sucesso!",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao agendar paciente!" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
    }
}
