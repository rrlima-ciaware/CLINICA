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
    public partial class frmCargos : Form
    {
        public Cargos cargos = new Cargos();

        public frmCargos()
        {
            InitializeComponent();
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void tsbCadastrar_Click(object sender, EventArgs e)
        {
            frmCadCargos cadcargos = new frmCadCargos(null);
            cadcargos.ShowDialog();
            dgvCargos.DataSource = cargos.listarCargos();

        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            if (cargos.CodCargo == 0)
            {

                MessageBox.Show("Selecione o cargo que deseja alterar!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmCadCargos cadcargos = new frmCadCargos(cargos);
            cadcargos.ShowDialog();
            dgvCargos.DataSource = cargos.listarCargos();

        }

        private void frmCargos_Load(object sender, EventArgs e)
        {
            dgvCargos.DataSource = cargos.listarCargos();
        }

        private void dgvCargos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cargos.CodCargo = (int)dgvCargos[clnCodigo.Name, dgvCargos.CurrentRow.Index].Value;
            cargos.NomCargo = dgvCargos[clnnome.Name, dgvCargos.CurrentRow.Index].Value.ToString();
            cargos.DocCargo = dgvCargos[clnDoc.Name, dgvCargos.CurrentRow.Index].Value.ToString();
        }
    }
}
