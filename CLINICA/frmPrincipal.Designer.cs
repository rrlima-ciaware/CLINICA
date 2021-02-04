namespace CLINICA
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sstSistema = new System.Windows.Forms.StatusStrip();
            this.sslNomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslDataHoraLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mniCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUsuários = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mniEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.sstSistema.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // sstSistema
            // 
            this.sstSistema.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sstSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslNomeUsuario,
            this.sslLogin,
            this.sslDataHoraLogin});
            this.sstSistema.Location = new System.Drawing.Point(0, 240);
            this.sstSistema.Name = "sstSistema";
            this.sstSistema.Size = new System.Drawing.Size(284, 22);
            this.sstSistema.TabIndex = 0;
            // 
            // sslNomeUsuario
            // 
            this.sslNomeUsuario.Name = "sslNomeUsuario";
            this.sslNomeUsuario.Size = new System.Drawing.Size(83, 17);
            this.sslNomeUsuario.Text = "NomeUsuario";
            // 
            // sslLogin
            // 
            this.sslLogin.Name = "sslLogin";
            this.sslLogin.Size = new System.Drawing.Size(37, 17);
            this.sslLogin.Text = "Login";
            // 
            // sslDataHoraLogin
            // 
            this.sslDataHoraLogin.Name = "sslDataHoraLogin";
            this.sslDataHoraLogin.Size = new System.Drawing.Size(90, 17);
            this.sslDataHoraLogin.Text = "DataHoraLogin";
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCadastros,
            this.mniAgendamento});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(284, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mniCadastros
            // 
            this.mniCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniUsuários,
            this.mniPacientes,
            this.mniCargos,
            this.mniFuncionarios,
            this.mniEspecialidades});
            this.mniCadastros.Name = "mniCadastros";
            this.mniCadastros.Size = new System.Drawing.Size(71, 20);
            this.mniCadastros.Text = "&Cadastros";
            // 
            // mniUsuários
            // 
            this.mniUsuários.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mniUsuários.Name = "mniUsuários";
            this.mniUsuários.Size = new System.Drawing.Size(150, 22);
            this.mniUsuários.Text = "&Usuários";
            this.mniUsuários.Click += new System.EventHandler(this.mniUsuários_Click);
            // 
            // mniPacientes
            // 
            this.mniPacientes.Name = "mniPacientes";
            this.mniPacientes.Size = new System.Drawing.Size(150, 22);
            this.mniPacientes.Text = "Clientes";
            this.mniPacientes.Click += new System.EventHandler(this.mniPacientes_Click);
            // 
            // mniCargos
            // 
            this.mniCargos.Name = "mniCargos";
            this.mniCargos.Size = new System.Drawing.Size(150, 22);
            this.mniCargos.Text = "Cargos";
            this.mniCargos.Click += new System.EventHandler(this.mniCargos_Click);
            // 
            // mniFuncionarios
            // 
            this.mniFuncionarios.Name = "mniFuncionarios";
            this.mniFuncionarios.Size = new System.Drawing.Size(150, 22);
            this.mniFuncionarios.Text = "Funcionários";
            this.mniFuncionarios.Click += new System.EventHandler(this.mniFuncionarios_Click);
            // 
            // mniEspecialidades
            // 
            this.mniEspecialidades.Name = "mniEspecialidades";
            this.mniEspecialidades.Size = new System.Drawing.Size(150, 22);
            this.mniEspecialidades.Text = "Especialidades";
            this.mniEspecialidades.Click += new System.EventHandler(this.mniEspecialidades_Click);
            // 
            // mniAgendamento
            // 
            this.mniAgendamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAgenda});
            this.mniAgendamento.Name = "mniAgendamento";
            this.mniAgendamento.Size = new System.Drawing.Size(95, 20);
            this.mniAgendamento.Text = "Agendamento";
            this.mniAgendamento.Click += new System.EventHandler(this.agendamentoToolStripMenuItem_Click);
            // 
            // mniAgenda
            // 
            this.mniAgenda.Name = "mniAgenda";
            this.mniAgenda.Size = new System.Drawing.Size(152, 22);
            this.mniAgenda.Text = "Agenda";
            this.mniAgenda.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.sstSistema);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.sstSistema.ResumeLayout(false);
            this.sstSistema.PerformLayout();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sstSistema;
        private System.Windows.Forms.ToolStripStatusLabel sslNomeUsuario;
        private System.Windows.Forms.ToolStripStatusLabel sslLogin;
        private System.Windows.Forms.ToolStripStatusLabel sslDataHoraLogin;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mniCadastros;
        private System.Windows.Forms.ToolStripMenuItem mniUsuários;
        private System.Windows.Forms.ToolStripMenuItem mniPacientes;
        private System.Windows.Forms.ToolStripMenuItem mniCargos;
        private System.Windows.Forms.ToolStripMenuItem mniFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem mniEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem mniAgendamento;
        private System.Windows.Forms.ToolStripMenuItem mniAgenda;

    }
}