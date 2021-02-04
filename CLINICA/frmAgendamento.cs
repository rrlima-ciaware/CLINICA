using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLINICA
{
    public partial class frmAgendamento : Form
    {
        private Funcionarios funcionarios = new Funcionarios();
        private Agendamento agendamento = new Agendamento();

        int CodPaciente = 0;
        string NomPaciente = "";               
        
        public frmAgendamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            

        }

        private void frmAgendamento_Load(object sender, EventArgs e)
        {
            agendamento.CodFuncionarioAgenda = 0;
            agendamento.CodPaciente = 0;
            cbProfissional.DataSource = funcionarios.listarFuncionarios();
            cbProfissional.DisplayMember = "NOM_FUNCIONARIO";
            cbProfissional.ValueMember = "COD_FUNCIONARIO";
            cbProfissional.SelectedIndex = -1;
            dtpDataFinal.Value = DateTime.Now.AddDays(30);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDataInicial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpDataFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gbxPeriodo_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisaPaciente_Click(object sender, EventArgs e)
        {
            frmPesquisaPaciente pesquisaPaciente = new frmPesquisaPaciente();
            pesquisaPaciente.ShowDialog();
            agendamento.CodPaciente = CodPaciente;
            CodPaciente = pesquisaPaciente.codPaciente;
            NomPaciente = pesquisaPaciente.nomPaciente;            
            txtNomPaciente.Text = NomPaciente;
            agendamento.CodPaciente = CodPaciente;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           
        }

        private void frmAgendamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            
        }

        private void tbsDisponibilidade_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDisponibilidade_Click(object sender, EventArgs e)
        {
            dgvHorarios.DataSource = agendamento.DisponibilidadeAgenda(Convert.ToDateTime(monthCalendar1.SelectionStart.Date), Convert.ToDateTime(monthCalendar2.SelectionStart.Date), 1);
            //dtpDataInicial.Value.Date, dtpDataFinal.Value.Date, agendamento.CodFuncionarioAgenda
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void tbsAgendar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            agendamento.IdfEncaixe = Convert.ToChar( "N");            
            if (agendamento.CodPaciente != 0 && agendamento.CodFuncionarioAgenda != 0)
              agendamento.agendarPaciente(agendamento);

        }

        private void dgvHorarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            agendamento.DtaConsulta = (DateTime)dgvHorarios[clnData.Name, dgvHorarios.CurrentRow.Index].Value;
            agendamento.HrConsulta = (TimeSpan)dgvHorarios[clnHorario.Name, dgvHorarios.CurrentRow.Index].Value;
            agendamento.DiaSemana = (int)dgvHorarios[clnNrDiaSemana.Name, dgvHorarios.CurrentRow.Index].Value;
        }

        private void cbProfissional_SelectedValueChanged(object sender, EventArgs e)
        {
            
              
            
        }

        private void cbProfissional_Click(object sender, EventArgs e)
        {
        }

        private void cbProfissional_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cbProfissional_DropDownClosed(object sender, EventArgs e)
        {
            agendamento.CodFuncionarioAgenda = (int)cbProfissional.SelectedValue;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar2_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
