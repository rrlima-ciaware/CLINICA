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
    public partial class frmUsuarios : Form
    {
        public Usuarios usuarios = new Usuarios();
        
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = usuarios.listarUsuarios();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void tsbCadastrar_Click(object sender, EventArgs e)
        {
            frmCadUsuarios cadusuarios = new frmCadUsuarios(null);
            cadusuarios.ShowDialog();
            dgvUsuarios.DataSource = usuarios.listarUsuarios();

        }

        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            usuarios.CodUsuario = (int)dgvUsuarios[clnCodUsuario.Name, dgvUsuarios.CurrentRow.Index].Value;
            usuarios.NomUsuario = dgvUsuarios[clnNomUsuario.Name, dgvUsuarios.CurrentRow.Index].Value.ToString();
            usuarios.Login = dgvUsuarios[clnLogin.Name, dgvUsuarios.CurrentRow.Index].Value.ToString();
            usuarios.Senha = dgvUsuarios[clnSenha.Name, dgvUsuarios.CurrentRow.Index].Value.ToString();
            usuarios.DtaCadastro = Convert.ToDateTime(dgvUsuarios[clnDtaCadastro.Name, dgvUsuarios.CurrentRow.Index].Value);
            usuarios.IdfAtivo = Convert.ToChar(dgvUsuarios[clnIdfAtivo.Name, dgvUsuarios.CurrentRow.Index].Value);
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (usuarios.CodUsuario == 0)
            {
                //se não foi selecionado nenhum usuário para exclusão, então cancela processo de exclusão
                return;
            }

            if (MessageBox.Show("Deseja excluir o usuário selecionado?", "Aviso", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (usuarios.excluirUsuario(usuarios.CodUsuario))
                {
                    MessageBox.Show("Usuários excluído com sucesso!", "Aviso",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //Atualiza lista de usuários
                    dgvUsuarios.DataSource = usuarios.listarUsuarios();

                    //limpa propriedades da classe Usuarios
                    usuarios.CodUsuario = 0;
                    usuarios.NomUsuario = "";
                    usuarios.Login = "";
                    usuarios.Senha = "";
                    usuarios.DtaCadastro = DateTime.Now.Date;
                    

                }
                else
                {
                    MessageBox.Show("Erro ao excluir usuário!", "Erro",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);       
                }   
            }
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {

            if (usuarios.CodUsuario == 0)
            {
                //se não foi selecionado nenhum usuário para exclusão, então cancela processo de exclusão
                MessageBox.Show("Selecione o usuário que deseja alterar!", "Atenção", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmCadUsuarios cadusuarios = new frmCadUsuarios(usuarios);
            cadusuarios.ShowDialog();
            dgvUsuarios.DataSource = usuarios.listarUsuarios();
        }

        private void tsbPesquisar_Click(object sender, EventArgs e)
        {
            if (!tsbPesquisar.Checked)
            {
                tsbPesquisar.Checked = true;
                txtPesquisa.Visible = true;
                txtPesquisa.Focus();
                dgvUsuarios.DataSource = usuarios.dtAux;
            }
            else
            {
                tsbPesquisar.Checked = false;
                txtPesquisa.Visible = false;
                txtPesquisa.Clear();                

            }
            
                
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                usuarios.dtAux.DefaultView.RowFilter = "nom_usuario like '%" + txtPesquisa.Text + "%'";
            }
            else
            {
                usuarios.dtAux.DefaultView.RowFilter = "";
            }
        }

        private void txtPesquisa_Click(object sender, EventArgs e)
        {

        }
    }
}
