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
    public partial class frmCadFuncionarios : Form
    {
        private Funcionarios funcionarios;
        private Cargos cargos = new Cargos();
        private Especialidades especialidades = new Especialidades();

        private Boolean alterar = false; 

        public frmCadFuncionarios(Funcionarios paramFuncionarios)
        {
            InitializeComponent();

            funcionarios = paramFuncionarios;

            if (funcionarios != null)
            {
                funcionarios.CodFuncionario = paramFuncionarios.CodFuncionario;
                funcionarios.NomFuncionario = paramFuncionarios.NomFuncionario;
                funcionarios.Endereco = paramFuncionarios.Endereco;
                funcionarios.Telefone = paramFuncionarios.Telefone;
                funcionarios.CodCargo = paramFuncionarios.CodCargo;
                funcionarios.Cargo = paramFuncionarios.Cargo;
                funcionarios.CodEspecialidade = paramFuncionarios.CodEspecialidade;
                funcionarios.NumDoc = paramFuncionarios.NumDoc;
                alterar = true;
            }
            else
                funcionarios = new Funcionarios();


        }

        private void frmCadFuncionarios_Load(object sender, EventArgs e)
        {
            cboCargo.DisplayMember = "Nom_Cargo";
            cboCargo.ValueMember = "Cod_Cargo";
            cboCargo.DataSource = cargos.listarCargos();

            cboEspecialidade.DisplayMember = "Nom_Especialidade";
            cboEspecialidade.ValueMember = "Cod_Especialidade";
            cboEspecialidade.DataSource = especialidades.listarEspecialidades();

            if (alterar)
            {
               txtCodigo.DataBindings.Add("Text", funcionarios, "CodFuncionario");

               cboCargo.SelectedValue = funcionarios.CodCargo;
               cboEspecialidade.SelectedValue = funcionarios.CodEspecialidade;

            }

            txtNome.DataBindings.Add("Text", funcionarios, "NomFuncionario");
            txtEndereco.DataBindings.Add("Text", funcionarios, "Endereco");
            txtTelefone.DataBindings.Add("Text", funcionarios, "Telefone");
            txtDoc.DataBindings.Add("Text", funcionarios, "NumDoc");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadFuncionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void limparTela()
        {
            //Limpar o conteúdo das texts e prepara a tela para um novo cadastro
            txtCodigo.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtDoc.Clear();
            cboCargo.SelectedIndex = 0;
            cboCargo.SelectedIndex = 0;

            funcionarios.CodFuncionario = 0;
            funcionarios.NomFuncionario = "";
            funcionarios.Endereco = "";
            funcionarios.Telefone = "";
            funcionarios.CodCargo = 0;
            funcionarios.Cargo = "";
            funcionarios.CodEspecialidade = 0;
            funcionarios.Especialidade = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {

                txtNome.BackColor = Color.LightGray;
                txtNome.Focus();

            }
            else if (txtEndereco.Text.Trim() == "")
            {

                txtEndereco.BackColor = Color.LightGray;
                txtEndereco.Focus();

            }
            else if (txtTelefone.Text.Trim() == "")
            {

                txtTelefone.BackColor = Color.LightGray;
                txtTelefone.Focus();

            }
            else
            {


                try
                {

                    funcionarios.CodCargo = (int)cboCargo.SelectedValue;
                    funcionarios.CodEspecialidade = (int)cboEspecialidade.SelectedValue;

                    if (txtDoc.Text.Trim() == "")
                        funcionarios.NumDoc = "";

                    if (!alterar)
                    {
                        funcionarios.cadastrarFuncionario(funcionarios);
                    }
                    else
                    {
                        funcionarios.alterarFuncionario(funcionarios);

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

        private void cboEspecialidade_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
