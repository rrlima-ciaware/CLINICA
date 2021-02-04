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
    public partial class frmAgenda : Form
    {

        private Agendamento agendamento = new Agendamento();

        public frmAgenda()
        {
            InitializeComponent();
        }

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            dgvAgenda.DataSource = agendamento.buscarAgenda();
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {

        }

        private void tbsAgendamento_Click(object sender, EventArgs e)
        {
            frmAgendamento formAgendamento = new frmAgendamento();
            formAgendamento.ShowDialog();
            dgvAgenda.DataSource = agendamento.buscarAgenda();
        }
    }
}
