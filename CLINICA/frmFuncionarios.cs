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
    public partial class frmFuncionarios : Form
    {
        Funcionarios funcionarios = new Funcionarios();

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funcionarios.listarFuncionarios();
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void tsbCadastrar_Click(object sender, EventArgs e)
        {
            frmCadFuncionarios cadfuncionarios = new frmCadFuncionarios(null);
            cadfuncionarios.ShowDialog();
            dgvFuncionarios.DataSource = funcionarios.listarFuncionarios();
        }

        private void dgvFuncionarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            funcionarios.CodFuncionario = (int)dgvFuncionarios[clnCodigo.Name, dgvFuncionarios.CurrentRow.Index].Value;
            funcionarios.NomFuncionario = dgvFuncionarios[clnNome.Name, dgvFuncionarios.CurrentRow.Index].Value.ToString();
            funcionarios.Endereco = dgvFuncionarios[clnEndereco.Name, dgvFuncionarios.CurrentRow.Index].Value.ToString();
            funcionarios.Telefone = dgvFuncionarios[clnTelefone.Name, dgvFuncionarios.CurrentRow.Index].Value.ToString();
            funcionarios.CodCargo = (int)dgvFuncionarios[clncodcargo.Name, dgvFuncionarios.CurrentRow.Index].Value;
            funcionarios.Cargo = dgvFuncionarios[clnCargo.Name, dgvFuncionarios.CurrentRow.Index].Value.ToString();
            funcionarios.Especialidade = dgvFuncionarios[clnNomEspecialidade.Name, dgvFuncionarios.CurrentRow.Index].Value.ToString();
            funcionarios.CodEspecialidade = (int)dgvFuncionarios[clnCodEspecialidade.Name, dgvFuncionarios.CurrentRow.Index].Value;
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            if (funcionarios.CodFuncionario == 0)
            {
                
                MessageBox.Show("Selecione o funcionário que deseja alterar!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmCadFuncionarios cadfuncionarios = new frmCadFuncionarios(funcionarios);
            cadfuncionarios.ShowDialog();
            dgvFuncionarios.DataSource = funcionarios.listarFuncionarios();        
        }
    }
}
