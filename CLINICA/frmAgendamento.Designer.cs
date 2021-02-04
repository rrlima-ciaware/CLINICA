namespace CLINICA
{
    partial class frmAgendamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNrDiaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeDiaSeman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtdVagas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnDisponibilidade = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisaPaciente = new System.Windows.Forms.Button();
            this.txtNomPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxPeriodo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProfissional = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbxPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnData,
            this.clnNrDiaSemana,
            this.clnNomeDiaSeman,
            this.clnHorario,
            this.clnQtdVagas});
            this.dgvHorarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHorarios.Location = new System.Drawing.Point(0, 102);
            this.dgvHorarios.MultiSelect = false;
            this.dgvHorarios.Name = "dgvHorarios";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvHorarios.RowHeadersVisible = false;
            this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarios.Size = new System.Drawing.Size(856, 357);
            this.dgvHorarios.TabIndex = 2;
            this.dgvHorarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHorarios_CellMouseClick);
            // 
            // clnData
            // 
            this.clnData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnData.DataPropertyName = "Data";
            this.clnData.HeaderText = "Data";
            this.clnData.Name = "clnData";
            // 
            // clnNrDiaSemana
            // 
            this.clnNrDiaSemana.DataPropertyName = "DiaSemana";
            this.clnNrDiaSemana.HeaderText = "Nr. Dia Semana";
            this.clnNrDiaSemana.Name = "clnNrDiaSemana";
            this.clnNrDiaSemana.Visible = false;
            // 
            // clnNomeDiaSeman
            // 
            this.clnNomeDiaSeman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnNomeDiaSeman.DataPropertyName = "NomeDiaSemana";
            this.clnNomeDiaSeman.HeaderText = "Dia da Semana";
            this.clnNomeDiaSeman.Name = "clnNomeDiaSeman";
            // 
            // clnHorario
            // 
            this.clnHorario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnHorario.DataPropertyName = "horario";
            this.clnHorario.HeaderText = "Horário";
            this.clnHorario.Name = "clnHorario";
            // 
            // clnQtdVagas
            // 
            this.clnQtdVagas.DataPropertyName = "QtdVagas";
            this.clnQtdVagas.HeaderText = "Qtd. Vagas";
            this.clnQtdVagas.Name = "clnQtdVagas";
            this.clnQtdVagas.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.btnDisponibilidade);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.btnPesquisaPaciente);
            this.panel2.Controls.Add(this.txtNomPaciente);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.gbxPeriodo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbProfissional);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 102);
            this.panel2.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::CLINICA.Properties.Resources.btConfirma;
            this.btnConfirmar.Location = new System.Drawing.Point(748, 31);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(45, 45);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnDisponibilidade
            // 
            this.btnDisponibilidade.Image = global::CLINICA.Properties.Resources.btCalendario;
            this.btnDisponibilidade.Location = new System.Drawing.Point(697, 31);
            this.btnDisponibilidade.Name = "btnDisponibilidade";
            this.btnDisponibilidade.Size = new System.Drawing.Size(45, 45);
            this.btnDisponibilidade.TabIndex = 19;
            this.btnDisponibilidade.UseVisualStyleBackColor = true;
            this.btnDisponibilidade.Click += new System.EventHandler(this.btnDisponibilidade_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::CLINICA.Properties.Resources.btSai3;
            this.btnSair.Location = new System.Drawing.Point(799, 31);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(45, 45);
            this.btnSair.TabIndex = 18;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnPesquisaPaciente
            // 
            this.btnPesquisaPaciente.Image = global::CLINICA.Properties.Resources.magnifier;
            this.btnPesquisaPaciente.Location = new System.Drawing.Point(382, 71);
            this.btnPesquisaPaciente.Name = "btnPesquisaPaciente";
            this.btnPesquisaPaciente.Size = new System.Drawing.Size(25, 25);
            this.btnPesquisaPaciente.TabIndex = 17;
            this.btnPesquisaPaciente.UseVisualStyleBackColor = true;
            this.btnPesquisaPaciente.Click += new System.EventHandler(this.btnPesquisaPaciente_Click);
            // 
            // txtNomPaciente
            // 
            this.txtNomPaciente.Enabled = false;
            this.txtNomPaciente.Location = new System.Drawing.Point(12, 76);
            this.txtNomPaciente.Name = "txtNomPaciente";
            this.txtNomPaciente.Size = new System.Drawing.Size(364, 20);
            this.txtNomPaciente.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Paciente";
            // 
            // gbxPeriodo
            // 
            this.gbxPeriodo.Controls.Add(this.label2);
            this.gbxPeriodo.Controls.Add(this.label3);
            this.gbxPeriodo.Controls.Add(this.dtpDataInicial);
            this.gbxPeriodo.Controls.Add(this.dtpDataFinal);
            this.gbxPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPeriodo.Location = new System.Drawing.Point(418, 5);
            this.gbxPeriodo.Name = "gbxPeriodo";
            this.gbxPeriodo.Size = new System.Drawing.Size(221, 49);
            this.gbxPeriodo.TabIndex = 14;
            this.gbxPeriodo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dt. Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dt. Final";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(9, 26);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(89, 20);
            this.dtpDataInicial.TabIndex = 5;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(123, 26);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(88, 20);
            this.dtpDataFinal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Profissional";
            // 
            // cbProfissional
            // 
            this.cbProfissional.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProfissional.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProfissional.BackColor = System.Drawing.SystemColors.Window;
            this.cbProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfissional.FormattingEnabled = true;
            this.cbProfissional.Location = new System.Drawing.Point(12, 24);
            this.cbProfissional.Name = "cbProfissional";
            this.cbProfissional.Size = new System.Drawing.Size(364, 21);
            this.cbProfissional.Sorted = true;
            this.cbProfissional.TabIndex = 12;
            this.cbProfissional.SelectedIndexChanged += new System.EventHandler(this.cbProfissional_SelectedIndexChanged_1);
            this.cbProfissional.DropDownClosed += new System.EventHandler(this.cbProfissional_DropDownClosed);
            this.cbProfissional.SelectedValueChanged += new System.EventHandler(this.cbProfissional_SelectedValueChanged);
            this.cbProfissional.Click += new System.EventHandler(this.cbProfissional_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(325, 132);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(570, 132);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 7;
            this.monthCalendar2.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.monthCalendar2_ControlAdded);
            // 
            // frmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 459);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvHorarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAgendamento_FormClosed);
            this.Load += new System.EventHandler(this.frmAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbxPeriodo.ResumeLayout(false);
            this.gbxPeriodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNrDiaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeDiaSeman;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtdVagas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPesquisaPaciente;
        private System.Windows.Forms.TextBox txtNomPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnDisponibilidade;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cbProfissional;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
    }
}