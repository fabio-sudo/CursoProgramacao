namespace Apresentacao
{
    partial class FrmCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCurso));
            this.btSair = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btBuscarCurso = new System.Windows.Forms.Button();
            this.tbCurso = new System.Windows.Forms.TextBox();
            this.lbCurso = new System.Windows.Forms.Label();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ementaCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracaoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbCurso = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(487, 399);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(85, 23);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.Location = new System.Drawing.Point(103, 399);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(85, 23);
            this.btSelecionar.TabIndex = 5;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = true;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(12, 399);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(85, 23);
            this.btCadastrar.TabIndex = 4;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btBuscarCurso
            // 
            this.btBuscarCurso.Location = new System.Drawing.Point(287, 31);
            this.btBuscarCurso.Name = "btBuscarCurso";
            this.btBuscarCurso.Size = new System.Drawing.Size(75, 23);
            this.btBuscarCurso.TabIndex = 2;
            this.btBuscarCurso.Text = "Buscar";
            this.btBuscarCurso.UseVisualStyleBackColor = true;
            this.btBuscarCurso.Click += new System.EventHandler(this.btBuscarCurso_Click);
            // 
            // tbCurso
            // 
            this.tbCurso.Location = new System.Drawing.Point(103, 32);
            this.tbCurso.Name = "tbCurso";
            this.tbCurso.Size = new System.Drawing.Size(178, 20);
            this.tbCurso.TabIndex = 1;
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Location = new System.Drawing.Point(63, 39);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(34, 13);
            this.lbCurso.TabIndex = 0;
            this.lbCurso.Text = "Curso";
            // 
            // dgvCurso
            // 
            this.dgvCurso.AllowUserToAddRows = false;
            this.dgvCurso.AllowUserToDeleteRows = false;
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAluno,
            this.nomeCurso,
            this.ementaCurso,
            this.duracaoCurso});
            this.dgvCurso.Location = new System.Drawing.Point(12, 60);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.ReadOnly = true;
            this.dgvCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurso.Size = new System.Drawing.Size(560, 333);
            this.dgvCurso.TabIndex = 3;
            this.dgvCurso.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellDoubleClick);
            // 
            // idAluno
            // 
            this.idAluno.HeaderText = "ID";
            this.idAluno.Name = "idAluno";
            this.idAluno.ReadOnly = true;
            this.idAluno.ToolTipText = "Código identificação do aluno";
            this.idAluno.Width = 50;
            // 
            // nomeCurso
            // 
            this.nomeCurso.HeaderText = "Nome";
            this.nomeCurso.Name = "nomeCurso";
            this.nomeCurso.ReadOnly = true;
            this.nomeCurso.ToolTipText = "Nome do curso";
            this.nomeCurso.Width = 120;
            // 
            // ementaCurso
            // 
            this.ementaCurso.HeaderText = "Ementa";
            this.ementaCurso.Name = "ementaCurso";
            this.ementaCurso.ReadOnly = true;
            this.ementaCurso.ToolTipText = "ementa do Curso";
            this.ementaCurso.Width = 240;
            // 
            // duracaoCurso
            // 
            this.duracaoCurso.HeaderText = "Duração";
            this.duracaoCurso.Name = "duracaoCurso";
            this.duracaoCurso.ReadOnly = true;
            this.duracaoCurso.ToolTipText = "Duração do Curso";
            // 
            // pbCurso
            // 
            this.pbCurso.Image = global::Apresentacao.Properties.Resources.CursoLogo;
            this.pbCurso.Location = new System.Drawing.Point(12, 12);
            this.pbCurso.Name = "pbCurso";
            this.pbCurso.Size = new System.Drawing.Size(45, 40);
            this.pbCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurso.TabIndex = 13;
            this.pbCurso.TabStop = false;
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 438);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.pbCurso);
            this.Controls.Add(this.btBuscarCurso);
            this.Controls.Add(this.tbCurso);
            this.Controls.Add(this.lbCurso);
            this.Controls.Add(this.dgvCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.FrmCurso_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCurso_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.PictureBox pbCurso;
        private System.Windows.Forms.Button btBuscarCurso;
        private System.Windows.Forms.TextBox tbCurso;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ementaCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaoCurso;
    }
}