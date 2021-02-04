namespace CLINICA
{
    partial class frmCadUsuarios
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
            this.txtcodusuario = new System.Windows.Forms.TextBox();
            this.txtnomusuario = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtvalidasenha = new System.Windows.Forms.TextBox();
            this.cbxAtivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUsuarioCadastrado = new System.Windows.Forms.Label();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcodusuario
            // 
            this.txtcodusuario.Location = new System.Drawing.Point(12, 23);
            this.txtcodusuario.Name = "txtcodusuario";
            this.txtcodusuario.ReadOnly = true;
            this.txtcodusuario.Size = new System.Drawing.Size(67, 20);
            this.txtcodusuario.TabIndex = 0;
            this.txtcodusuario.TabStop = false;
            // 
            // txtnomusuario
            // 
            this.txtnomusuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtnomusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnomusuario.Location = new System.Drawing.Point(12, 75);
            this.txtnomusuario.MaxLength = 50;
            this.txtnomusuario.Name = "txtnomusuario";
            this.txtnomusuario.Size = new System.Drawing.Size(398, 20);
            this.txtnomusuario.TabIndex = 2;
            this.txtnomusuario.TextChanged += new System.EventHandler(this.CorrigiCor_TextChanged);
            // 
            // txtlogin
            // 
            this.txtlogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtlogin.Location = new System.Drawing.Point(12, 138);
            this.txtlogin.MaxLength = 25;
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(120, 20);
            this.txtlogin.TabIndex = 4;
            this.txtlogin.TextChanged += new System.EventHandler(this.CorrigiCor_TextChanged);
            this.txtlogin.Leave += new System.EventHandler(this.txtlogin_Leave);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(10, 196);
            this.txtsenha.MaxLength = 25;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(120, 20);
            this.txtsenha.TabIndex = 6;
            this.txtsenha.UseSystemPasswordChar = true;
            this.txtsenha.TextChanged += new System.EventHandler(this.CorrigiCor_TextChanged);
            // 
            // txtvalidasenha
            // 
            this.txtvalidasenha.Location = new System.Drawing.Point(149, 196);
            this.txtvalidasenha.MaxLength = 25;
            this.txtvalidasenha.Name = "txtvalidasenha";
            this.txtvalidasenha.Size = new System.Drawing.Size(120, 20);
            this.txtvalidasenha.TabIndex = 8;
            this.txtvalidasenha.UseSystemPasswordChar = true;
            this.txtvalidasenha.TextChanged += new System.EventHandler(this.CorrigiCor_TextChanged);
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.AutoSize = true;
            this.cbxAtivo.Checked = true;
            this.cbxAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAtivo.Location = new System.Drawing.Point(314, 138);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(55, 17);
            this.cbxAtivo.TabIndex = 9;
            this.cbxAtivo.Text = "Ativo";
            this.cbxAtivo.UseVisualStyleBackColor = true;
            this.cbxAtivo.CheckedChanged += new System.EventHandler(this.cbxAtivo_CheckedChanged);
            this.cbxAtivo.Click += new System.EventHandler(this.cbxAtivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Confirma Senha";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::CLINICA.Properties.Resources.btConfirma;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Location = new System.Drawing.Point(219, 240);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(40, 40);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::CLINICA.Properties.Resources.btExclui;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Location = new System.Drawing.Point(273, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblUsuarioCadastrado
            // 
            this.lblUsuarioCadastrado.AutoSize = true;
            this.lblUsuarioCadastrado.ForeColor = System.Drawing.Color.Red;
            this.lblUsuarioCadastrado.Location = new System.Drawing.Point(139, 144);
            this.lblUsuarioCadastrado.Name = "lblUsuarioCadastrado";
            this.lblUsuarioCadastrado.Size = new System.Drawing.Size(133, 13);
            this.lblUsuarioCadastrado.TabIndex = 17;
            this.lblUsuarioCadastrado.Text = "LOGIN NÃO DISPONÍVEL";
            this.lblUsuarioCadastrado.Visible = false;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.BackgroundImage = global::CLINICA.Properties.Resources.btAltera;
            this.btnAlterarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlterarSenha.Enabled = false;
            this.btnAlterarSenha.Location = new System.Drawing.Point(273, 191);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(27, 28);
            this.btnAlterarSenha.TabIndex = 18;
            this.btnAlterarSenha.UseVisualStyleBackColor = true;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // frmCadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.lblUsuarioCadastrado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAtivo);
            this.Controls.Add(this.txtvalidasenha);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtnomusuario);
            this.Controls.Add(this.txtcodusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadUsuarios_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.frmCadUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodusuario;
        private System.Windows.Forms.TextBox txtnomusuario;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtvalidasenha;
        private System.Windows.Forms.CheckBox cbxAtivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUsuarioCadastrado;
        private System.Windows.Forms.Button btnAlterarSenha;
    }
}