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
    public partial class frmCadPacientes : Form
    {

        private Pacientes pacientes;

        private Boolean alterar = false; 

        public frmCadPacientes(Pacientes paramPacientes)
        {
            InitializeComponent();

            pacientes = paramPacientes;

            if (pacientes != null)
            {
                pacientes.CodPaciente = paramPacientes.CodPaciente;
                pacientes.NomPaciente = paramPacientes.NomPaciente;
                pacientes.Endereco = paramPacientes.Endereco;
                pacientes.Telefone = paramPacientes.Telefone;
                pacientes.Email = paramPacientes.Email;
                pacientes.CPF = paramPacientes.CPF;
                alterar = true;
            }
            else
                pacientes = new Pacientes();

        }

        private void frmCadPacientes_Load(object sender, EventArgs e)
        {

            if (alterar)
                txtCodigo.DataBindings.Add("Text", pacientes, "CodPaciente");

            txtNomPaciente.DataBindings.Add("Text", pacientes, "NomPaciente");
            txtEndereco.DataBindings.Add("Text", pacientes, "Endereco");
            txtTelefone.DataBindings.Add("Text", pacientes, "Telefone");
            txtEmail.DataBindings.Add("Text", pacientes, "Email");
            txtCPF.DataBindings.Add("Text", pacientes, "CPF");


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadPacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmCadPacientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtNomPaciente.Text.Trim() == "")
            {

                txtNomPaciente.BackColor = Color.LightGray;
                txtNomPaciente.Focus();

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
            else if (txtEmail.Text.Trim() == "")
            {

                txtEmail.BackColor = Color.LightGray;
                txtEmail.Focus();
            }
            else if (txtCPF.Text.Trim() == "")
            {

                txtCPF.BackColor = Color.LightGray;
                txtCPF.Focus();
            }

            else
            {

                
                    try
                    {
                        if (!alterar)
                        {
                            pacientes.cadastrarPaciente(pacientes);

                        }
                        else
                        {
                            pacientes.alterarPaciente(pacientes);

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
            txtNomPaciente.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            txtEmail.Clear();

            pacientes.CodPaciente = 0;
            pacientes.NomPaciente = "";
            pacientes.Endereco = "";
            pacientes.Telefone = "";
            pacientes.Email = "";
            pacientes.CPF = "";
        }

        private void CorrigiCor_TextChanged(object sender, EventArgs e)
        {                      
            
            txtNomPaciente.BackColor = Color.White;
            txtEndereco.BackColor = Color.White;
            txtCPF.BackColor = Color.White;
            txtTelefone.BackColor = Color.White;           


        }

    }
}
