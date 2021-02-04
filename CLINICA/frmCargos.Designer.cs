namespace CLINICA
{
    partial class frmCargos
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
            this.tstBotoes = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.dgvCargos = new System.Windows.Forms.DataGridView();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.tsbPesquisar = new System.Windows.Forms.ToolStripButton();
            this.tstBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // tstBotoes
            // 
            this.tstBotoes.AutoSize = false;
            this.tstBotoes.CanOverflow = false;
            this.tstBotoes.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tstBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadastrar,
            this.tsbAlterar,
            this.tsbExcluir,
            this.toolStripSeparator1,
            this.tsbSair,
            this.tsbPesquisar,
            this.txtPesquisa});
            this.tstBotoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tstBotoes.Location = new System.Drawing.Point(0, 0);
            this.tstBotoes.Name = "tstBotoes";
            this.tstBotoes.Size = new System.Drawing.Size(526, 57);
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
            // dgvCargos
            // 
            this.dgvCargos.AllowUserToAddRows = false;
            this.dgvCargos.AllowUserToDeleteRows = false;
            this.dgvCargos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigo,
            this.clnnome,
            this.clnDoc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCargos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCargos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCargos.Location = new System.Drawing.Point(0, 60);
            this.dgvCargos.MultiSelect = false;
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.ReadOnly = true;
            this.dgvCargos.RowHeadersVisible = false;
            this.dgvCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargos.Size = new System.Drawing.Size(526, 315);
            this.dgvCargos.TabIndex = 4;
            this.dgvCargos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCargos_CellMouseClick);
            // 
            // clnCodigo
            // 
            this.clnCodigo.DataPropertyName = "cod_cargo";
            this.clnCodigo.HeaderText = "Código";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.Width = 50;
            // 
            // clnnome
            // 
            this.clnnome.DataPropertyName = "nom_cargo";
            this.clnnome.HeaderText = "Nome";
            this.clnnome.Name = "clnnome";
            this.clnnome.ReadOnly = true;
            this.clnnome.Width = 250;
            // 
            // clnDoc
            // 
            this.clnDoc.DataPropertyName = "doc_cargo";
            this.clnDoc.HeaderText = "Documento";
            this.clnDoc.Name = "clnDoc";
            this.clnDoc.ReadOnly = true;
            this.clnDoc.Width = 150;
            // 
            // tsbCadastrar
            // 
            this.tsbCadastrar.AutoSize = false;
            this.tsbCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.tsbCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadastrar.Image = global::CLINICA.Properties.Resources.add_32;
            this.tsbCadastrar.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.tsbCadastrar.Name = "tsbCadastrar";
            this.tsbCadastrar.Size = new System.Drawing.Size(40, 40);
            this.tsbCadastrar.Text = "toolStripButton1";
            this.tsbCadastrar.ToolTipText = "Cadastrar";
            this.tsbCadastrar.Click += new System.EventHandler(this.tsbCadastrar_Click);
            // 
            // tsbAlterar
            // 
            this.tsbAlterar.AutoSize = false;
            this.tsbAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlterar.Image = global::CLINICA.Properties.Resources.btAltera;
            this.tsbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterar.Name = "tsbAlterar";
            this.tsbAlterar.Size = new System.Drawing.Size(40, 40);
            this.tsbAlterar.Text = "toolStripButton2";
            this.tsbAlterar.ToolTipText = "Alterar";
            this.tsbAlterar.Click += new System.EventHandler(this.tsbAlterar_Click);
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
            // frmCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 375);
            this.Controls.Add(this.dgvCargos);
            this.Controls.Add(this.tstBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargos";
            this.Load += new System.EventHandler(this.frmCargos_Load);
            this.tstBotoes.ResumeLayout(false);
            this.tstBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstBotoes;
        private System.Windows.Forms.ToolStripButton tsbCadastrar;
        private System.Windows.Forms.ToolStripButton tsbAlterar;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.ToolStripButton tsbPesquisar;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvCargos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDoc;
    }
}