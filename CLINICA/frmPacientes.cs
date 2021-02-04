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
    public partial class frmPacientes : Form
    {
        public Pacientes pacientes = new Pacientes();

        public frmPacientes()
        {
            InitializeComponent();
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = pacientes.listarPacientes();
        }

        private void tsbCadastrar_Click(object sender, EventArgs e)
        {
            frmCadPacientes cadpacientes = new frmCadPacientes(null);
            cadpacientes.ShowDialog();
            dgvPacientes.DataSource = pacientes.listarPacientes();
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            if (pacientes.CodPaciente == 0)
            {
                
                MessageBox.Show("Selecione o paciente que deseja alterar!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmCadPacientes cadpacientes = new frmCadPacientes(pacientes);
            cadpacientes.ShowDialog();
            dgvPacientes.DataSource = pacientes.listarPacientes();
        }

        private void dgvPacientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pacientes.CodPaciente = (int)dgvPacientes[clnCodigo.Name, dgvPacientes.CurrentRow.Index].Value;
            pacientes.NomPaciente = dgvPacientes[clnnome.Name, dgvPacientes.CurrentRow.Index].Value.ToString();
            pacientes.Endereco = dgvPacientes[clnendereco.Name, dgvPacientes.CurrentRow.Index].Value.ToString();
            pacientes.Telefone = dgvPacientes[clnTelefone.Name, dgvPacientes.CurrentRow.Index].Value.ToString();
            pacientes.Email = dgvPacientes[clnemail.Name, dgvPacientes.CurrentRow.Index].Value.ToString();
            pacientes.CPF = dgvPacientes[clnCPF.Name, dgvPacientes.CurrentRow.Index].Value.ToString();

        }
    }
}
