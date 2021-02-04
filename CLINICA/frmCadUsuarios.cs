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
    public partial class frmCadUsuarios : Form
    {
        private Usuarios usuarios;
                
        private Boolean alterar = false; 
                           
        public frmCadUsuarios(Usuarios paramUsuario)
        {
        
            InitializeComponent();

            usuarios = paramUsuario;

            if (usuarios != null)
            {
                usuarios.CodUsuario = paramUsuario.CodUsuario;
                usuarios.NomUsuario = paramUsuario.NomUsuario;
                usuarios.Login = paramUsuario.Login;
                usuarios.Senha = paramUsuario.Senha;
                usuarios.IdfAtivo = paramUsuario.IdfAtivo;
                txtnomusuario.Enabled = false;
                txtlogin.Enabled = false;
                alterar = true;
            }
            else
                usuarios = new Usuarios();

            
        }

        private void frmCadUsuarios_Load(object sender, EventArgs e)
        {

            if (alterar)
              txtcodusuario.DataBindings.Add("Text", usuarios, "CodUsuario");

            txtnomusuario.DataBindings.Add("Text", usuarios, "NomUsuario");
            txtlogin.DataBindings.Add("Text", usuarios, "Login");
            txtsenha.DataBindings.Add("Text", usuarios, "Senha");

            if (!alterar)
            {
                cbxAtivo_Click(sender, e);
            }
            else 
            {
                if (usuarios.IdfAtivo == Convert.ToChar("N"))
                    cbxAtivo.Checked = false;

                btnAlterarSenha.Enabled = true;
                txtsenha.Enabled = false;
                txtvalidasenha.Enabled = false;
                txtvalidasenha.Text = usuarios.Senha;

            }
                
           

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {           
            if (!alterar && usuarios.usuarioJaCadastrado(txtlogin.Text) == true)
            {   
                lblUsuarioCadastrado.Visible = true;
                txtlogin.Focus();
                return;
            }

            if (txtnomusuario.Text.Trim() == "")
            {

                txtnomusuario.BackColor = Color.LightGray;
                txtnomusuario.Focus();

            }
            else if (txtlogin.Text.Trim() == "")
            {

                txtlogin.BackColor = Color.LightGray;
                txtlogin.Focus();

            }
            else if(txtsenha.Text.Trim() == "")
            {

                txtsenha.BackColor = Color.LightGray;
                txtsenha.Focus();

            }
            else if (txtvalidasenha.Text.Trim() == "")
            {

                txtvalidasenha.BackColor = Color.LightGray;
                txtvalidasenha.Focus();
            }
            else
            {

                if (txtsenha.Text != txtvalidasenha.Text)
                {
                    MessageBox.Show("As senhas digitadas são diferentes! Redigite as senhas.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtsenha.Clear();
                    txtvalidasenha.Clear();
                    txtsenha.Focus();
                }
                else
                {
                    try
                    {
                        if (!alterar)
                        {
                            usuarios.cadastrarUsuario(usuarios);
                            MessageBox.Show("Usuário cadastrado com sucesso!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            usuarios.alterarUsuario(usuarios);
                            MessageBox.Show("Usuário alterado com sucesso!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    catch
                    {
                        MessageBox.Show("Entre em contato com o suporte técnico!",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        limparTela();

                        if (alterar)
                            Close();
                    }

                }

            }
        }

        private void cbxAtivo_Click(object sender, EventArgs e)
        {            
            if (cbxAtivo.Checked)
                usuarios.IdfAtivo = Convert.ToChar("S");
            else
                usuarios.IdfAtivo = Convert.ToChar("N");

        }

        private void cbxAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CorrigiCor_TextChanged(object sender, EventArgs e)
        {
            
            lblUsuarioCadastrado.Visible = false;           
            
            txtnomusuario.BackColor = Color.White;
            txtlogin.BackColor = Color.White;
            txtsenha.BackColor = Color.White;
            txtvalidasenha.BackColor = Color.White;           

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmCadUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void limparTela()
        {
            //Limpar o conteúdo das texts e prepara a tela para um novo cadastro
            txtcodusuario.Clear();
            txtnomusuario.Clear();
            txtlogin.Clear();
            txtsenha.Clear();
            txtvalidasenha.Clear();
            txtnomusuario.Focus();

            usuarios.CodUsuario = 0;
            usuarios.NomUsuario = "";
            usuarios.Login = "";
            usuarios.Senha = "";
            usuarios.DtaCadastro = DateTime.Now.Date;
        }

        private void txtlogin_Leave(object sender, EventArgs e)
        {
         //   if (txtlogin.Text.Trim() != "")
       //     {
                if (usuarios.usuarioJaCadastrado(txtlogin.Text) == true)
                {
                    lblUsuarioCadastrado.Visible = true;
                    txtlogin.Focus();
                }
         //   }

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            txtsenha.Enabled = true;
            txtvalidasenha.Enabled = true;
            txtsenha.Focus();
        }

    }
}
