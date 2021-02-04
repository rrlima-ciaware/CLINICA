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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            //Carregando os dados do usuário logado no sistema
        /*    sstSistema.Items[0].Text = "Usuário: " + Conexao.NomUsuario;
            sstSistema.Items[1].Text = "Login: " + Conexao.Login;
            sstSistema.Items[2].Text = "Horário do login: " + DateTime.Now.ToString();

            */
        }

        private void mniUsuários_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();
            usuarios.Dispose();
        }

        private void mniPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes pacientes = new frmPacientes();
            pacientes.ShowDialog();
            pacientes.Dispose();

        }

        private void mniCargos_Click(object sender, EventArgs e)
        {
            frmCargos cargos = new frmCargos();
            cargos.ShowDialog();
            cargos.Dispose();

        }

        private void mniFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios funcionarios = new frmFuncionarios();
            funcionarios.ShowDialog();
            funcionarios.Dispose();

        }

        private void mniEspecialidades_Click(object sender, EventArgs e)
        {
            frmEspecialidades especialidades = new frmEspecialidades();
            especialidades.ShowDialog();
            especialidades.Dispose();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda agenda = new frmAgenda();
            agenda.ShowDialog();
        }
    }
}
