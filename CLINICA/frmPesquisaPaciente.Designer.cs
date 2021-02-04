namespace CLINICA
{
    partial class frmPesquisaPaciente
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
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.tstBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbSelecionar = new System.Windows.Forms.ToolStripButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clnCodPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.tstBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.AllowUserToAddRows = false;
            this.dgvPaciente.AllowUserToDeleteRows = false;
            this.dgvPaciente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodPaciente,
            this.clnNomPaciente,
            this.clnCPF});
            this.dgvPaciente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPaciente.Location = new System.Drawing.Point(0, 67);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.RowHeadersVisible = false;
            this.dgvPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaciente.Size = new System.Drawing.Size(653, 302);
            this.dgvPaciente.TabIndex = 0;
            this.dgvPaciente.VirtualMode = true;
            this.dgvPaciente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaciente_CellDoubleClick);
            this.dgvPaciente.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPaciente_CellMouseClick);
            // 
            // tstBotoes
            // 
            this.tstBotoes.AutoSize = false;
            this.tstBotoes.CanOverflow = false;
            this.tstBotoes.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tstBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSelecionar,
            this.toolStripSeparator1,
            this.tsbSair,
            this.txtPesquisa});
            this.tstBotoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tstBotoes.Location = new System.Drawing.Point(0, 0);
            this.tstBotoes.Name = "tstBotoes";
            this.tstBotoes.Size = new System.Drawing.Size(653, 57);
            this.tstBotoes.TabIndex = 5;
            this.tstBotoes.Text = "toolStrip1";
            // 
            // tsbSelecionar
            // 
            this.tsbSelecionar.AutoSize = false;
            this.tsbSelecionar.BackColor = System.Drawing.SystemColors.Control;
            this.tsbSelecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbSelecionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSelecionar.Image = global::CLINICA.Properties.Resources.btConfirma;
            this.tsbSelecionar.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.tsbSelecionar.Name = "tsbSelecionar";
            this.tsbSelecionar.Size = new System.Drawing.Size(40, 40);
            this.tsbSelecionar.Text = "toolStripButton1";
            this.tsbSelecionar.ToolTipText = "Cadastrar";
            this.tsbSelecionar.Click += new System.EventHandler(this.tsbSelecionar_Click);
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
            // txtPesquisa
            // 
            this.txtPesquisa.AutoSize = false;
            this.txtPesquisa.BackColor = System.Drawing.Color.Yellow;
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(250, 23);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // clnCodPaciente
            // 
            this.clnCodPaciente.DataPropertyName = "cod_paciente";
            this.clnCodPaciente.HeaderText = "Código";
            this.clnCodPaciente.Name = "clnCodPaciente";
            this.clnCodPaciente.Width = 80;
            // 
            // clnNomPaciente
            // 
            this.clnNomPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnNomPaciente.DataPropertyName = "nom_paciente";
            this.clnNomPaciente.HeaderText = "Nome";
            this.clnNomPaciente.Name = "clnNomPaciente";
            // 
            // clnCPF
            // 
            this.clnCPF.DataPropertyName = "cpf";
            this.clnCPF.HeaderText = "CPF";
            this.clnCPF.Name = "clnCPF";
            // 
            // frmPesquisaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 369);
            this.Controls.Add(this.tstBotoes);
            this.Controls.Add(this.dgvPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmPesquisaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Paciente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPesquisaPaciente_FormClosed);
            this.Load += new System.EventHandler(this.frmPesquisaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.tstBotoes.ResumeLayout(false);
            this.tstBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.ToolStrip tstBotoes;
        private System.Windows.Forms.ToolStripButton tsbSelecionar;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCPF;
    }
}