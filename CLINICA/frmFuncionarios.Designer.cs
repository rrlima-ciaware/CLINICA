namespace CLINICA
{
    partial class frmFuncionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tstBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.tsbPesquisar = new System.Windows.Forms.ToolStripButton();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clncodcargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodEspecialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomEspecialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tstBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
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
            this.tstBotoes.Size = new System.Drawing.Size(697, 57);
            this.tstBotoes.TabIndex = 2;
            this.tstBotoes.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
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
            // txtPesquisa
            // 
            this.txtPesquisa.AutoSize = false;
            this.txtPesquisa.BackColor = System.Drawing.Color.Yellow;
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(200, 23);
            this.txtPesquisa.Visible = false;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigo,
            this.clnNome,
            this.clnEndereco,
            this.clncodcargo,
            this.clnCodEspecialidade,
            this.clnTelefone,
            this.clnCargo,
            this.clnNomEspecialidade,
            this.clnNumDoc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFuncionarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFuncionarios.Location = new System.Drawing.Point(0, 60);
            this.dgvFuncionarios.MultiSelect = false;
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(697, 310);
            this.dgvFuncionarios.TabIndex = 3;
            this.dgvFuncionarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFuncionarios_CellMouseClick);
            // 
            // clnCodigo
            // 
            this.clnCodigo.DataPropertyName = "cod_funcionario";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clnCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnCodigo.Frozen = true;
            this.clnCodigo.HeaderText = "Código";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.Width = 50;
            // 
            // clnNome
            // 
            this.clnNome.DataPropertyName = "nom_funcionario";
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 200;
            // 
            // clnEndereco
            // 
            this.clnEndereco.DataPropertyName = "endereco";
            this.clnEndereco.HeaderText = "Endereço";
            this.clnEndereco.Name = "clnEndereco";
            this.clnEndereco.ReadOnly = true;
            this.clnEndereco.Width = 300;
            // 
            // clncodcargo
            // 
            this.clncodcargo.DataPropertyName = "cod_cargo";
            this.clncodcargo.HeaderText = "CodCargo";
            this.clncodcargo.Name = "clncodcargo";
            this.clncodcargo.ReadOnly = true;
            this.clncodcargo.Visible = false;
            this.clncodcargo.Width = 50;
            // 
            // clnCodEspecialidade
            // 
            this.clnCodEspecialidade.DataPropertyName = "cod_especialidade";
            this.clnCodEspecialidade.HeaderText = "Cod. Especialidade";
            this.clnCodEspecialidade.Name = "clnCodEspecialidade";
            this.clnCodEspecialidade.ReadOnly = true;
            this.clnCodEspecialidade.Visible = false;
            // 
            // clnTelefone
            // 
            this.clnTelefone.DataPropertyName = "telefone";
            this.clnTelefone.HeaderText = "Telefone";
            this.clnTelefone.Name = "clnTelefone";
            this.clnTelefone.ReadOnly = true;
            // 
            // clnCargo
            // 
            this.clnCargo.DataPropertyName = "nom_cargo";
            this.clnCargo.FillWeight = 150F;
            this.clnCargo.HeaderText = "Cargo";
            this.clnCargo.Name = "clnCargo";
            this.clnCargo.ReadOnly = true;
            this.clnCargo.Width = 150;
            // 
            // clnNomEspecialidade
            // 
            this.clnNomEspecialidade.DataPropertyName = "nom_especialidade";
            this.clnNomEspecialidade.HeaderText = "Especialidade";
            this.clnNomEspecialidade.Name = "clnNomEspecialidade";
            this.clnNomEspecialidade.ReadOnly = true;
            // 
            // clnNumDoc
            // 
            this.clnNumDoc.DataPropertyName = "num_doc";
            this.clnNumDoc.HeaderText = "Doc. Profissional";
            this.clnNumDoc.Name = "clnNumDoc";
            this.clnNumDoc.ReadOnly = true;
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 370);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.tstBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.tstBotoes.ResumeLayout(false);
            this.tstBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clncodcargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodEspecialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomEspecialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumDoc;
    }
}