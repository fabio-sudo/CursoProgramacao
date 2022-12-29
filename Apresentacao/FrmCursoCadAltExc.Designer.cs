namespace Apresentacao
{
    partial class FrmCursoCadAltExc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursoCadAltExc));
            this.lbEmenta = new System.Windows.Forms.Label();
            this.tbEmenta = new System.Windows.Forms.TextBox();
            this.lbDuracao = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.pbCurso = new System.Windows.Forms.PictureBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.tbDuracao = new System.Windows.Forms.TextBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmenta
            // 
            this.lbEmenta.AutoSize = true;
            this.lbEmenta.Location = new System.Drawing.Point(9, 221);
            this.lbEmenta.Name = "lbEmenta";
            this.lbEmenta.Size = new System.Drawing.Size(43, 13);
            this.lbEmenta.TabIndex = 7;
            this.lbEmenta.Text = "Ementa";
            // 
            // tbEmenta
            // 
            this.tbEmenta.Location = new System.Drawing.Point(87, 110);
            this.tbEmenta.Multiline = true;
            this.tbEmenta.Name = "tbEmenta";
            this.tbEmenta.Size = new System.Drawing.Size(305, 124);
            this.tbEmenta.TabIndex = 6;
            // 
            // lbDuracao
            // 
            this.lbDuracao.AutoSize = true;
            this.lbDuracao.Location = new System.Drawing.Point(9, 91);
            this.lbDuracao.Name = "lbDuracao";
            this.lbDuracao.Size = new System.Drawing.Size(48, 13);
            this.lbDuracao.TabIndex = 4;
            this.lbDuracao.Text = "Duração";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(87, 58);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(183, 20);
            this.tbNome.TabIndex = 3;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(9, 65);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // pbCurso
            // 
            this.pbCurso.Image = global::Apresentacao.Properties.Resources.CursoLogo;
            this.pbCurso.Location = new System.Drawing.Point(7, 12);
            this.pbCurso.Name = "pbCurso";
            this.pbCurso.Size = new System.Drawing.Size(45, 40);
            this.pbCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurso.TabIndex = 48;
            this.pbCurso.TabStop = false;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(87, 32);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(43, 20);
            this.tbId.TabIndex = 1;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(63, 39);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID";
            // 
            // tbDuracao
            // 
            this.tbDuracao.Location = new System.Drawing.Point(87, 84);
            this.tbDuracao.Name = "tbDuracao";
            this.tbDuracao.Size = new System.Drawing.Size(183, 20);
            this.tbDuracao.TabIndex = 5;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(308, 250);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(84, 23);
            this.btSair.TabIndex = 11;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(218, 250);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(84, 23);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(102, 250);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(84, 23);
            this.btAlterar.TabIndex = 9;
            this.btAlterar.Text = "F12 Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(12, 250);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(84, 23);
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // FrmCursoCadAltExc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 286);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbDuracao);
            this.Controls.Add(this.lbEmenta);
            this.Controls.Add(this.tbEmenta);
            this.Controls.Add(this.lbDuracao);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.pbCurso);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmCursoCadAltExc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.FrmCursoCadAltExc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCursoCadAltExc_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmenta;
        private System.Windows.Forms.TextBox tbEmenta;
        private System.Windows.Forms.Label lbDuracao;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.PictureBox pbCurso;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbDuracao;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCadastrar;
    }
}