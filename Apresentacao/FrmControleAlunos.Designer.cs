namespace Apresentacao
{
    partial class FrmControleAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControleAlunos));
            this.btGerar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracaoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaSemanaCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscarCurso = new System.Windows.Forms.Button();
            this.tbCurso = new System.Windows.Forms.TextBox();
            this.pbCurso = new System.Windows.Forms.PictureBox();
            this.btBuscarProfessor = new System.Windows.Forms.Button();
            this.tbProfessor = new System.Windows.Forms.TextBox();
            this.pbProfessor = new System.Windows.Forms.PictureBox();
            this.btBuscarPeriodo = new System.Windows.Forms.Button();
            this.tbPeriodo = new System.Windows.Forms.TextBox();
            this.pbPeriodo = new System.Windows.Forms.PictureBox();
            this.btBuscarAluno = new System.Windows.Forms.Button();
            this.tbAluno = new System.Windows.Forms.TextBox();
            this.pbAluno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(12, 544);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(85, 23);
            this.btGerar.TabIndex = 9;
            this.btGerar.Text = "F5 Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(1045, 544);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(85, 23);
            this.btSair.TabIndex = 12;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.Location = new System.Drawing.Point(194, 544);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(85, 23);
            this.btSelecionar.TabIndex = 11;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = true;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(103, 544);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(85, 23);
            this.btCadastrar.TabIndex = 10;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAluno,
            this.nomeCurso,
            this.duracaoCurso,
            this.nomeAluno,
            this.celularAluno,
            this.idadeAluno,
            this.nomeProfessor,
            this.diaSemanaCurso,
            this.periodoCurso,
            this.horarioEntrada,
            this.horarioSaida,
            this.statusAluno});
            this.dgvAluno.Location = new System.Drawing.Point(12, 60);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAluno.Size = new System.Drawing.Size(1118, 478);
            this.dgvAluno.TabIndex = 8;
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
            this.nomeCurso.HeaderText = "Curso";
            this.nomeCurso.Name = "nomeCurso";
            this.nomeCurso.ReadOnly = true;
            this.nomeCurso.ToolTipText = "Nome do curso";
            // 
            // duracaoCurso
            // 
            this.duracaoCurso.HeaderText = "Duração";
            this.duracaoCurso.Name = "duracaoCurso";
            this.duracaoCurso.ReadOnly = true;
            this.duracaoCurso.ToolTipText = "Duração do curso";
            this.duracaoCurso.Width = 80;
            // 
            // nomeAluno
            // 
            this.nomeAluno.HeaderText = "Aluno";
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.ReadOnly = true;
            this.nomeAluno.ToolTipText = "Nome Completo aluno";
            this.nomeAluno.Width = 160;
            // 
            // celularAluno
            // 
            this.celularAluno.HeaderText = "Celular";
            this.celularAluno.Name = "celularAluno";
            this.celularAluno.ReadOnly = true;
            this.celularAluno.ToolTipText = "celular do aluno";
            this.celularAluno.Width = 80;
            // 
            // idadeAluno
            // 
            this.idadeAluno.HeaderText = "Idade";
            this.idadeAluno.Name = "idadeAluno";
            this.idadeAluno.ReadOnly = true;
            this.idadeAluno.ToolTipText = "idade do aluno";
            this.idadeAluno.Width = 60;
            // 
            // nomeProfessor
            // 
            this.nomeProfessor.HeaderText = "Professor";
            this.nomeProfessor.Name = "nomeProfessor";
            this.nomeProfessor.ReadOnly = true;
            this.nomeProfessor.ToolTipText = "Nome completo do professor";
            this.nomeProfessor.Width = 160;
            // 
            // diaSemanaCurso
            // 
            this.diaSemanaCurso.HeaderText = "Dia Curso";
            this.diaSemanaCurso.Name = "diaSemanaCurso";
            this.diaSemanaCurso.ReadOnly = true;
            this.diaSemanaCurso.Width = 80;
            // 
            // periodoCurso
            // 
            this.periodoCurso.HeaderText = "Período";
            this.periodoCurso.Name = "periodoCurso";
            this.periodoCurso.ReadOnly = true;
            this.periodoCurso.Width = 80;
            // 
            // horarioEntrada
            // 
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            this.horarioEntrada.DefaultCellStyle = dataGridViewCellStyle1;
            this.horarioEntrada.HeaderText = "H.Entrada";
            this.horarioEntrada.Name = "horarioEntrada";
            this.horarioEntrada.ReadOnly = true;
            this.horarioEntrada.ToolTipText = "horário de entrada do curso";
            this.horarioEntrada.Width = 70;
            // 
            // horarioSaida
            // 
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.horarioSaida.DefaultCellStyle = dataGridViewCellStyle2;
            this.horarioSaida.HeaderText = "H.Saida";
            this.horarioSaida.Name = "horarioSaida";
            this.horarioSaida.ReadOnly = true;
            this.horarioSaida.ToolTipText = "horário de saída do curso";
            this.horarioSaida.Width = 70;
            // 
            // statusAluno
            // 
            this.statusAluno.HeaderText = "Status";
            this.statusAluno.Name = "statusAluno";
            this.statusAluno.ReadOnly = true;
            this.statusAluno.ToolTipText = "status do aluno";
            this.statusAluno.Width = 60;
            // 
            // btBuscarCurso
            // 
            this.btBuscarCurso.Location = new System.Drawing.Point(493, 31);
            this.btBuscarCurso.Name = "btBuscarCurso";
            this.btBuscarCurso.Size = new System.Drawing.Size(75, 23);
            this.btBuscarCurso.TabIndex = 3;
            this.btBuscarCurso.Text = "Buscar";
            this.btBuscarCurso.UseVisualStyleBackColor = true;
            this.btBuscarCurso.Click += new System.EventHandler(this.btBuscarCurso_Click);
            // 
            // tbCurso
            // 
            this.tbCurso.Location = new System.Drawing.Point(337, 34);
            this.tbCurso.Name = "tbCurso";
            this.tbCurso.Size = new System.Drawing.Size(150, 20);
            this.tbCurso.TabIndex = 2;
            // 
            // pbCurso
            // 
            this.pbCurso.Image = global::Apresentacao.Properties.Resources.CursoLogo;
            this.pbCurso.Location = new System.Drawing.Point(293, 22);
            this.pbCurso.Name = "pbCurso";
            this.pbCurso.Size = new System.Drawing.Size(38, 32);
            this.pbCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurso.TabIndex = 18;
            this.pbCurso.TabStop = false;
            // 
            // btBuscarProfessor
            // 
            this.btBuscarProfessor.Location = new System.Drawing.Point(774, 31);
            this.btBuscarProfessor.Name = "btBuscarProfessor";
            this.btBuscarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btBuscarProfessor.TabIndex = 5;
            this.btBuscarProfessor.Text = "Buscar";
            this.btBuscarProfessor.UseVisualStyleBackColor = true;
            this.btBuscarProfessor.Click += new System.EventHandler(this.btBuscarProfessor_Click);
            // 
            // tbProfessor
            // 
            this.tbProfessor.Location = new System.Drawing.Point(618, 34);
            this.tbProfessor.Name = "tbProfessor";
            this.tbProfessor.Size = new System.Drawing.Size(150, 20);
            this.tbProfessor.TabIndex = 4;
            // 
            // pbProfessor
            // 
            this.pbProfessor.Image = global::Apresentacao.Properties.Resources.Professor;
            this.pbProfessor.Location = new System.Drawing.Point(574, 22);
            this.pbProfessor.Name = "pbProfessor";
            this.pbProfessor.Size = new System.Drawing.Size(38, 32);
            this.pbProfessor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfessor.TabIndex = 21;
            this.pbProfessor.TabStop = false;
            // 
            // btBuscarPeriodo
            // 
            this.btBuscarPeriodo.Location = new System.Drawing.Point(1055, 31);
            this.btBuscarPeriodo.Name = "btBuscarPeriodo";
            this.btBuscarPeriodo.Size = new System.Drawing.Size(75, 23);
            this.btBuscarPeriodo.TabIndex = 7;
            this.btBuscarPeriodo.Text = "Buscar";
            this.btBuscarPeriodo.UseVisualStyleBackColor = true;
            this.btBuscarPeriodo.Click += new System.EventHandler(this.btBuscarPeriodo_Click);
            // 
            // tbPeriodo
            // 
            this.tbPeriodo.Location = new System.Drawing.Point(899, 34);
            this.tbPeriodo.Name = "tbPeriodo";
            this.tbPeriodo.Size = new System.Drawing.Size(150, 20);
            this.tbPeriodo.TabIndex = 6;
            // 
            // pbPeriodo
            // 
            this.pbPeriodo.Image = global::Apresentacao.Properties.Resources.PeriodoLogo;
            this.pbPeriodo.Location = new System.Drawing.Point(855, 22);
            this.pbPeriodo.Name = "pbPeriodo";
            this.pbPeriodo.Size = new System.Drawing.Size(38, 32);
            this.pbPeriodo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPeriodo.TabIndex = 24;
            this.pbPeriodo.TabStop = false;
            // 
            // btBuscarAluno
            // 
            this.btBuscarAluno.Location = new System.Drawing.Point(212, 31);
            this.btBuscarAluno.Name = "btBuscarAluno";
            this.btBuscarAluno.Size = new System.Drawing.Size(75, 23);
            this.btBuscarAluno.TabIndex = 1;
            this.btBuscarAluno.Text = "Buscar";
            this.btBuscarAluno.UseVisualStyleBackColor = true;
            this.btBuscarAluno.Click += new System.EventHandler(this.btBuscarAluno_Click);
            // 
            // tbAluno
            // 
            this.tbAluno.Location = new System.Drawing.Point(56, 34);
            this.tbAluno.Name = "tbAluno";
            this.tbAluno.Size = new System.Drawing.Size(150, 20);
            this.tbAluno.TabIndex = 0;
            // 
            // pbAluno
            // 
            this.pbAluno.Image = global::Apresentacao.Properties.Resources.AlunoCursoLogo;
            this.pbAluno.Location = new System.Drawing.Point(12, 22);
            this.pbAluno.Name = "pbAluno";
            this.pbAluno.Size = new System.Drawing.Size(38, 32);
            this.pbAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAluno.TabIndex = 27;
            this.pbAluno.TabStop = false;
            // 
            // FrmControleAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 591);
            this.Controls.Add(this.btBuscarAluno);
            this.Controls.Add(this.tbAluno);
            this.Controls.Add(this.pbAluno);
            this.Controls.Add(this.btBuscarPeriodo);
            this.Controls.Add(this.tbPeriodo);
            this.Controls.Add(this.pbPeriodo);
            this.Controls.Add(this.btBuscarProfessor);
            this.Controls.Add(this.tbProfessor);
            this.Controls.Add(this.pbProfessor);
            this.Controls.Add(this.btBuscarCurso);
            this.Controls.Add(this.tbCurso);
            this.Controls.Add(this.pbCurso);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dgvAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmControleAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Alunos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmControleAlunos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Button btBuscarCurso;
        private System.Windows.Forms.TextBox tbCurso;
        private System.Windows.Forms.PictureBox pbCurso;
        private System.Windows.Forms.Button btBuscarProfessor;
        private System.Windows.Forms.TextBox tbProfessor;
        private System.Windows.Forms.PictureBox pbProfessor;
        private System.Windows.Forms.Button btBuscarPeriodo;
        private System.Windows.Forms.TextBox tbPeriodo;
        private System.Windows.Forms.PictureBox pbPeriodo;
        private System.Windows.Forms.Button btBuscarAluno;
        private System.Windows.Forms.TextBox tbAluno;
        private System.Windows.Forms.PictureBox pbAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaSemanaCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusAluno;
    }
}