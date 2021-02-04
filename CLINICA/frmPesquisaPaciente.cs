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
    public partial class frmPesquisaPaciente : Form
    {
        private Pacientes pacientes = new Pacientes();
        public int codPaciente = 0;
        public string nomPaciente = "";

        public frmPesquisaPaciente()
        {
            InitializeComponent();
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPesquisaPaciente_FormClosed(object sender, FormClosedEventArgs e)
        {
            pacientes.dtPesquisa.Dispose();
            Dispose();
        }

        private void frmPesquisaPaciente_Load(object sender, EventArgs e)
        {
            dgvPaciente.DataSource = pacientes.pesquisaPacientes();
            txtPesquisa.Focus();

        }

        private void dgvPaciente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void tsbSelecionar_Click(object sender, EventArgs e)
        {
            codPaciente = (int)dgvPaciente[clnCodPaciente.Name, dgvPaciente.CurrentRow.Index].Value;
            nomPaciente = (string)dgvPaciente[clnNomPaciente.Name, dgvPaciente.CurrentRow.Index].Value;
            Close();
        }

        private void dgvPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbSelecionar_Click(sender, e);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                pacientes.dtPesquisa.DefaultView.RowFilter = "nom_paciente like '%" + txtPesquisa.Text + "%'";
            }
            else
            {
                pacientes.dtPesquisa.DefaultView.RowFilter = "";
            }
        }
    }
}
