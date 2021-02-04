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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Conexao.efetuarLogin(txtLogin.Text, txtSenha.Text))
            {
                if (Conexao.IdfAtivo.ToString() == "N")
                {
                    MessageBox.Show("Seu login está desativado! Procure o administrador do sistema.", 
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLogin.Focus();
                    return;
                }

                Hide();
                frmPrincipal principal = new frmPrincipal();
                principal.ShowDialog();
                Close();
            }
            else
            {
                if (Conexao.Login == "")
                {
                    MessageBox.Show("Login não cadastrado!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLogin.Focus();
                }
                else
                {
                    MessageBox.Show("Senha incorreta!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSenha.Focus();
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
