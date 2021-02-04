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
    public partial class frmEspecialidades : Form
    {
        private Especialidades especialidades = new Especialidades();

        public frmEspecialidades()
        {
            InitializeComponent();
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void frmEspecialidades_Load(object sender, EventArgs e)
        {
            dgvEspecialidades.DataSource = especialidades.listarEspecialidades();
        }

        private void dgvEspecialidades_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            especialidades.CodEspecialidade = (int)dgvEspecialidades[clnCodigo.Name, dgvEspecialidades.CurrentRow.Index].Value;
            especialidades.NomEspecialidade = dgvEspecialidades[clnnome.Name, dgvEspecialidades.CurrentRow.Index].Value.ToString();          
        }

        private void tsbCadastrar_Click(object sender, EventArgs e)
        {
            frmCadEspecialidade cadespecialidades = new frmCadEspecialidade(null);
            cadespecialidades.ShowDialog();
            dgvEspecialidades.DataSource = especialidades.listarEspecialidades();
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            if (especialidades.CodEspecialidade == 0)
            {
                
                MessageBox.Show("Selecione a especialidade que deseja alterar!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmCadEspecialidade cadespecialidades = new frmCadEspecialidade(especialidades);
            cadespecialidades.ShowDialog();
            dgvEspecialidades.DataSource = especialidades.listarEspecialidades();

        }
    }
}
