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
    public partial class frmCadEspecialidade : Form
    {
        private Especialidades especialidades;
        private Boolean alterar = false;

        public frmCadEspecialidade(Especialidades paramEspecialidades)
        {
            InitializeComponent();

            especialidades = paramEspecialidades;

            if (especialidades != null)
            {
                especialidades.CodEspecialidade = paramEspecialidades.CodEspecialidade;
                especialidades.NomEspecialidade = paramEspecialidades.NomEspecialidade;                
                alterar = true;
            }
            else
                especialidades = new Especialidades();
        }

        private void frmCadEspecialidade_Load(object sender, EventArgs e)
        {

            if (alterar)
                txtCodEspecialidade.DataBindings.Add("Text", especialidades, "CodEspecialidade");

            txtNomEspecialidade.DataBindings.Add("Text", especialidades, "NomEspecialidade");


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadEspecialidade_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomEspecialidade.Text.Trim() == "")
            {

                txtNomEspecialidade.Focus();

            }
            else
            {


                try
                {
                    if (!alterar)
                    {
                        especialidades.cadastrarEspecialide(especialidades);
                        MessageBox.Show("Especialidade cadastrado com sucesso!",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        especialidades.alterarEspecialidade(especialidades);
                        MessageBox.Show("Especialidade alterado com sucesso!",
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

        private void limparTela()
        {
            //Limpar o conteúdo das texts e prepara a tela para um novo cadastro
            txtCodEspecialidade.Clear();
            txtNomEspecialidade.Clear();

            especialidades.CodEspecialidade = 0;
            especialidades.NomEspecialidade = "";

        }

    }
}