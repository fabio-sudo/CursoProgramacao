namespace Apresentacao
{
    partial class FrmProfessorCadAltExc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessorCadAltExc));
            this.btSair = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.tbSobrenome = new System.Windows.Forms.TextBox();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.pbAluno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(282, 237);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(84, 23);
            this.btSair.TabIndex = 57;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(192, 237);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(84, 23);
            this.btExcluir.TabIndex = 56;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(102, 237);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(84, 23);
            this.btAlterar.TabIndex = 55;
            this.btAlterar.Text = "F12 Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(12, 237);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(84, 23);
            this.btCadastrar.TabIndex = 54;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(9, 195);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(63, 13);
            this.lbDataNascimento.TabIndex = 53;
            this.lbDataNascimento.Text = "Nascimento";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(87, 188);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(90, 20);
            this.dtpDataNascimento.TabIndex = 52;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(87, 162);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(183, 20);
            this.tbEndereco.TabIndex = 49;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(9, 169);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 48;
            this.lbEndereco.Text = "Endereço";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Location = new System.Drawing.Point(9, 143);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(39, 13);
            this.lbCelular.TabIndex = 47;
            this.lbCelular.Text = "Celular";
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(87, 136);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(130, 20);
            this.mtbCelular.TabIndex = 46;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(9, 117);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(27, 13);
            this.lbCpf.TabIndex = 45;
            this.lbCpf.Text = "CPF";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(87, 110);
            this.mtbCpf.Mask = "999,999,999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(130, 20);
            this.mtbCpf.TabIndex = 44;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Location = new System.Drawing.Point(87, 84);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(183, 20);
            this.tbSobrenome.TabIndex = 43;
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.Location = new System.Drawing.Point(9, 91);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lbSobrenome.TabIndex = 42;
            this.lbSobrenome.Text = "Sobrenome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(87, 58);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(183, 20);
            this.tbNome.TabIndex = 41;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(9, 65);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 40;
            this.lbNome.Text = "Nome";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(87, 32);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(43, 20);
            this.tbId.TabIndex = 38;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(63, 39);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 37;
            this.lbId.Text = "ID";
            // 
            // pbAluno
            // 
            this.pbAluno.Image = global::Apresentacao.Properties.Resources.Professor;
            this.pbAluno.Location = new System.Drawing.Point(12, 12);
            this.pbAluno.Name = "pbAluno";
            this.pbAluno.Size = new System.Drawing.Size(45, 40);
            this.pbAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAluno.TabIndex = 39;
            this.pbAluno.TabStop = false;
            // 
            // FrmProfessorCadAltExc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 282);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbDataNascimento);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.tbSobrenome);
            this.Controls.Add(this.lbSobrenome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.pbAluno);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmProfessorCadAltExc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professor";
            this.Load += new System.EventHandler(this.FrmProfessorCadAltExc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProfessorCadAltExc_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox tbSobrenome;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.PictureBox pbAluno;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
    }
}