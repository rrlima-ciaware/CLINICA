namespace CLINICA
{
    partial class frmAgenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.tstBotoes = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.tbsAgendamento = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.tsbPesquisar = new System.Windows.Forms.ToolStripButton();
            this.clnNumAgenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDtaConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHrConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdfEncaixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.tstBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AllowUserToDeleteRows = false;
            this.dgvAgenda.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumAgenda,
            this.clnCodFuncionario,
            this.clnCodPaciente,
            this.clnDtaConsulta,
            this.clnHrConsulta,
            this.clnNomFuncionario,
            this.clnNomPaciente,
            this.clnIdfEncaixe});
            this.dgvAgenda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAgenda.Location = new System.Drawing.Point(0, 99);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgenda.RowHeadersVisible = false;
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(926, 349);
            this.dgvAgenda.TabIndex = 0;
            this.dgvAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellContentClick);
            // 
            // tstBotoes
            // 
            this.tstBotoes.AutoSize = false;
            this.tstBotoes.CanOverflow = false;
            this.tstBotoes.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tstBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsAgendamento,
            this.tsbExcluir,
            this.toolStripSeparator1,
            this.tsbSair,
            this.tsbPesquisar,
            this.txtPesquisa});
            this.tstBotoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tstBotoes.Location = new System.Drawing.Point(0, 0);
            this.tstBotoes.Name = "tstBotoes";
            this.tstBotoes.Size = new System.Drawing.Size(926, 57);
            this.tstBotoes.TabIndex = 3;
            this.tstBotoes.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AutoSize = false;
            this.txtPesquisa.BackColor = System.Drawing.Color.Yellow;
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(200, 23);
            this.txtPesquisa.Visible = false;
            // 
            // tbsAgendamento
            // 
            this.tbsAgendamento.AutoSize = false;
            this.tbsAgendamento.BackColor = System.Drawing.SystemColors.Control;
            this.tbsAgendamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbsAgendamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsAgendamento.Image = global::CLINICA.Properties.Resources.btAgenda;
            this.tbsAgendamento.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.tbsAgendamento.Name = "tbsAgendamento";
            this.tbsAgendamento.Size = new System.Drawing.Size(40, 40);
            this.tbsAgendamento.Text = "toolStripButton1";
            this.tbsAgendamento.ToolTipText = "Cadastrar";
            this.tbsAgendamento.Click += new System.EventHandler(this.tbsAgendamento_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.AutoSize = false;
            this.tsbExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluir.Image = global::CLINICA.Properties.Resources.delete_32;
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(40, 40);
            this.tsbExcluir.Text = "toolStripButton3";
            this.tsbExcluir.ToolTipText = "Excluir";
            // 
            // tsbSair
            // 
            this.tsbSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSair.AutoSize = false;
            this.tsbSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSair.Image = global::CLINICA.Properties.Resources.btSai3;
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(40, 40);
            this.tsbSair.Text = "toolStripButton1";
            this.tsbSair.ToolTipText = "Sair";
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // tsbPesquisar
            // 
            this.tsbPesquisar.AutoSize = false;
            this.tsbPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPesquisar.Image = global::CLINICA.Properties.Resources.btFiltro;
            this.tsbPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPesquisar.Name = "tsbPesquisar";
            this.tsbPesquisar.Size = new System.Drawing.Size(40, 40);
            // 
            // clnNumAgenda
            // 
            this.clnNumAgenda.DataPropertyName = "num_agenda";
            this.clnNumAgenda.HeaderText = "Nr. Agenda";
            this.clnNumAgenda.Name = "clnNumAgenda";
            this.clnNumAgenda.ReadOnly = true;
            this.clnNumAgenda.Visible = false;
            // 
            // clnCodFuncionario
            // 
            this.clnCodFuncionario.DataPropertyName = "cod_funcionario";
            this.clnCodFuncionario.HeaderText = "Cod. Funcionario";
            this.clnCodFuncionario.Name = "clnCodFuncionario";
            this.clnCodFuncionario.ReadOnly = true;
            this.clnCodFuncionario.Visible = false;
            // 
            // clnCodPaciente
            // 
            this.clnCodPaciente.DataPropertyName = "cod_paciente";
            this.clnCodPaciente.HeaderText = "Cod. Paciente";
            this.clnCodPaciente.Name = "clnCodPaciente";
            this.clnCodPaciente.ReadOnly = true;
            this.clnCodPaciente.Visible = false;
            // 
            // clnDtaConsulta
            // 
            this.clnDtaConsulta.DataPropertyName = "dta_consulta";
            this.clnDtaConsulta.HeaderText = "Dt. Consulta";
            this.clnDtaConsulta.Name = "clnDtaConsulta";
            this.clnDtaConsulta.ReadOnly = true;
            // 
            // clnHrConsulta
            // 
            this.clnHrConsulta.DataPropertyName = "hr_consulta";
            this.clnHrConsulta.HeaderText = "Horário";
            this.clnHrConsulta.Name = "clnHrConsulta";
            this.clnHrConsulta.ReadOnly = true;
            // 
            // clnNomFuncionario
            // 
            this.clnNomFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnNomFuncionario.DataPropertyName = "nom_funcionario";
            this.clnNomFuncionario.HeaderText = "Profissinal";
            this.clnNomFuncionario.Name = "clnNomFuncionario";
            this.clnNomFuncionario.ReadOnly = true;
            // 
            // clnNomPaciente
            // 
            this.clnNomPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnNomPaciente.DataPropertyName = "nom_paciente";
            this.clnNomPaciente.HeaderText = "Paciente";
            this.clnNomPaciente.Name = "clnNomPaciente";
            this.clnNomPaciente.ReadOnly = true;
            // 
            // clnIdfEncaixe
            // 
            this.clnIdfEncaixe.DataPropertyName = "idf_encaixe";
            this.clnIdfEncaixe.HeaderText = "Encaixe";
            this.clnIdfEncaixe.Name = "clnIdfEncaixe";
            this.clnIdfEncaixe.ReadOnly = true;
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 448);
            this.Controls.Add(this.tstBotoes);
            this.Controls.Add(this.dgvAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Pacientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAgenda_FormClosed);
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.tstBotoes.ResumeLayout(false);
            this.tstBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.ToolStrip tstBotoes;
        private System.Windows.Forms.ToolStripButton tbsAgendamento;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.ToolStripButton tsbPesquisar;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDtaConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHrConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdfEncaixe;
    }
}