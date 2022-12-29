namespace Apresentacao
{
    partial class FrmPeriodoCadAltExc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeriodoCadAltExc));
            this.btSair = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbHorarioInicial = new System.Windows.Forms.Label();
            this.dtpHorarioInicial = new System.Windows.Forms.DateTimePicker();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.pbAluno = new System.Windows.Forms.PictureBox();
            this.lbHorarioFinal = new System.Windows.Forms.Label();
            this.dtpHorarioFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(282, 169);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(84, 23);
            this.btSair.TabIndex = 76;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(192, 169);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(84, 23);
            this.btExcluir.TabIndex = 75;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(102, 169);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(84, 23);
            this.btAlterar.TabIndex = 74;
            this.btAlterar.Text = "F12 Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(12, 169);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(84, 23);
            this.btCadastrar.TabIndex = 73;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lbHorarioInicial
            // 
            this.lbHorarioInicial.AutoSize = true;
            this.lbHorarioInicial.Location = new System.Drawing.Point(9, 91);
            this.lbHorarioInicial.Name = "lbHorarioInicial";
            this.lbHorarioInicial.Size = new System.Drawing.Size(45, 13);
            this.lbHorarioInicial.TabIndex = 72;
            this.lbHorarioInicial.Text = "H.Inicial";
            // 
            // dtpHorarioInicial
            // 
            this.dtpHorarioInicial.CustomFormat = "HH:mm";
            this.dtpHorarioInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorarioInicial.Location = new System.Drawing.Point(87, 84);
            this.dtpHorarioInicial.Name = "dtpHorarioInicial";
            this.dtpHorarioInicial.ShowUpDown = true;
            this.dtpHorarioInicial.Size = new System.Drawing.Size(90, 20);
            this.dtpHorarioInicial.TabIndex = 71;
            this.dtpHorarioInicial.Value = new System.DateTime(2022, 12, 23, 0, 0, 0, 0);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(87, 58);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(183, 20);
            this.tbNome.TabIndex = 62;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(9, 65);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 61;
            this.lbNome.Text = "Nome";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(87, 32);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(43, 20);
            this.tbId.TabIndex = 59;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(63, 39);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 58;
            this.lbId.Text = "ID";
            // 
            // pbAluno
            // 
            this.pbAluno.Image = global::Apresentacao.Properties.Resources.PeriodoLogo;
            this.pbAluno.Location = new System.Drawing.Point(12, 12);
            this.pbAluno.Name = "pbAluno";
            this.pbAluno.Size = new System.Drawing.Size(45, 40);
            this.pbAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAluno.TabIndex = 60;
            this.pbAluno.TabStop = false;
            // 
            // lbHorarioFinal
            // 
            this.lbHorarioFinal.AutoSize = true;
            this.lbHorarioFinal.Location = new System.Drawing.Point(9, 120);
            this.lbHorarioFinal.Name = "lbHorarioFinal";
            this.lbHorarioFinal.Size = new System.Drawing.Size(40, 13);
            this.lbHorarioFinal.TabIndex = 77;
            this.lbHorarioFinal.Text = "H.Final";
            // 
            // dtpHorarioFinal
            // 
            this.dtpHorarioFinal.CustomFormat = "HH:mm";
            this.dtpHorarioFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorarioFinal.Location = new System.Drawing.Point(87, 113);
            this.dtpHorarioFinal.Name = "dtpHorarioFinal";
            this.dtpHorarioFinal.ShowUpDown = true;
            this.dtpHorarioFinal.Size = new System.Drawing.Size(90, 20);
            this.dtpHorarioFinal.TabIndex = 78;
            this.dtpHorarioFinal.Value = new System.DateTime(2022, 12, 23, 0, 0, 0, 0);
            // 
            // FrmPeriodoCadAltExc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 218);
            this.Controls.Add(this.dtpHorarioFinal);
            this.Controls.Add(this.lbHorarioFinal);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbHorarioInicial);
            this.Controls.Add(this.dtpHorarioInicial);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.pbAluno);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmPeriodoCadAltExc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Período";
            this.Load += new System.EventHandler(this.FrmPeriodoCadAltExc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lbHorarioInicial;
        private System.Windows.Forms.DateTimePicker dtpHorarioInicial;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.PictureBox pbAluno;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbHorarioFinal;
        private System.Windows.Forms.DateTimePicker dtpHorarioFinal;
    }
}