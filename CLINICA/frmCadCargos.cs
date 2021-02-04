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
    public partial class frmCadCargos : Form
    {
        private Cargos cargos;
        private Boolean alterar = false; 

        public frmCadCargos(Cargos paramCargos)
        {
            InitializeComponent();

            cargos = paramCargos;

            if (cargos != null)
            {
                cargos.CodCargo = paramCargos.CodCargo;
                cargos.NomCargo = paramCargos.NomCargo;
                cargos.DocCargo = paramCargos.DocCargo;
                alterar = true;
            }
            else
                cargos = new Cargos();
        }

        private void frmCadCargos_Load(object sender, EventArgs e)
        {
            if (alterar)
                txtCodigo.DataBindings.Add("Text", cargos, "CodCargo");

            txtNomeCargo.DataBindings.Add("Text", cargos, "NomCargo");
            txtDoc.DataBindings.Add("Text", cargos, "DocCargo");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCargo.Text.Trim() == "")
            {

                txtNomeCargo.BackColor = Color.LightGray;
                txtNomeCargo.Focus();

            }
            else
            {


                try
                {
                    if (!alterar)
                    {
                        cargos.cadastrarCargo(cargos);
                        MessageBox.Show("Cargo cadastrado com sucesso!",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cargos.alterarCargo(cargos);
                        MessageBox.Show("Cargo alterado com sucesso!",
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
            txtCodigo.Clear();
            txtNomeCargo.Clear();
            txtDoc.Clear();

            cargos.CodCargo = 0;
            cargos.NomCargo = "";
            cargos.DocCargo = "";
        }

        private void txtNomeCargo_TextChanged(object sender, EventArgs e)
        {
            txtNomeCargo.BackColor = Color.White;
        }

    }
}
