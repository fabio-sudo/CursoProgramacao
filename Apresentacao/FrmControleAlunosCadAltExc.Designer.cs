namespace Apresentacao
{
    partial class FrmControleAlunosCadAltExc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControleAlunosCadAltExc));
            this.tbProfessor = new System.Windows.Forms.TextBox();
            this.btBuscarProfessor = new System.Windows.Forms.Button();
            this.btBuscarPeriodo = new System.Windows.Forms.Button();
            this.tbPeriodo = new System.Windows.Forms.TextBox();
            this.btBuscarCurso = new System.Windows.Forms.Button();
            this.tbCurso = new System.Windows.Forms.TextBox();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.selecionarAluno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscarAluno = new System.Windows.Forms.Button();
            this.tbAluno = new System.Windows.Forms.TextBox();
            this.dgvAlunoCurso = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.pbAlunoCurso = new System.Windows.Forms.PictureBox();
            this.pbAluno = new System.Windows.Forms.PictureBox();
            this.pbCurso = new System.Windows.Forms.PictureBox();
            this.pbPeriodo = new System.Windows.Forms.PictureBox();
            this.pbProfessor = new System.Windows.Forms.PictureBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.cbDiaSemana = new System.Windows.Forms.ComboBox();
            this.btFinalizarCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunoCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlunoCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProfessor
            // 
            this.tbProfessor.Location = new System.Drawing.Point(337, 24);
            this.tbProfessor.Name = "tbProfessor";
            this.tbProfessor.Size = new System.Drawing.Size(150, 20);
            this.tbProfessor.TabIndex = 2;
            // 
            // btBuscarProfessor
            // 
            this.btBuscarProfessor.Location = new System.Drawing.Point(493, 21);
            this.btBuscarProfessor.Name = "btBuscarProfessor";
            this.btBuscarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btBuscarProfessor.TabIndex = 3;
            this.btBuscarProfessor.Text = "Buscar";
            this.btBuscarProfessor.UseVisualStyleBackColor = true;
            this.btBuscarProfessor.Click += new System.EventHandler(this.btBuscarProfessor_Click);
            // 
            // btBuscarPeriodo
            // 
            this.btBuscarPeriodo.Location = new System.Drawing.Point(774, 21);
            this.btBuscarPeriodo.Name = "btBuscarPeriodo";
            this.btBuscarPeriodo.Size = new System.Drawing.Size(75, 23);
            this.btBuscarPeriodo.TabIndex = 5;
            this.btBuscarPeriodo.Text = "Buscar";
            this.btBuscarPeriodo.UseVisualStyleBackColor = true;
            this.btBuscarPeriodo.Click += new System.EventHandler(this.btBuscarPeriodo_Click);
            // 
            // tbPeriodo
            // 
            this.tbPeriodo.Location = new System.Drawing.Point(618, 24);
            this.tbPeriodo.Name = "tbPeriodo";
            this.tbPeriodo.Size = new System.Drawing.Size(150, 20);
            this.tbPeriodo.TabIndex = 4;
            // 
            // btBuscarCurso
            // 
            this.btBuscarCurso.Location = new System.Drawing.Point(212, 21);
            this.btBuscarCurso.Name = "btBuscarCurso";
            this.btBuscarCurso.Size = new System.Drawing.Size(75, 23);
            this.btBuscarCurso.TabIndex = 1;
            this.btBuscarCurso.Text = "Buscar";
            this.btBuscarCurso.UseVisualStyleBackColor = true;
            this.btBuscarCurso.Click += new System.EventHandler(this.btBuscarCurso_Click);
            // 
            // tbCurso
            // 
            this.tbCurso.Location = new System.Drawing.Point(56, 24);
            this.tbCurso.Name = "tbCurso";
            this.tbCurso.Size = new System.Drawing.Size(150, 20);
            this.tbCurso.TabIndex = 0;
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionarAluno,
            this.idAluno,
            this.nomeAluno,
            this.cpfAluno,
            this.idadeAluno});
            this.dgvAluno.Location = new System.Drawing.Point(12, 99);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAluno.Size = new System.Drawing.Size(376, 246);
            this.dgvAluno.TabIndex = 9;
            // 
            // selecionarAluno
            // 
            this.selecionarAluno.HeaderText = "...";
            this.selecionarAluno.Name = "selecionarAluno";
            this.selecionarAluno.Width = 20;
            // 
            // idAluno
            // 
            this.idAluno.HeaderText = "ID";
            this.idAluno.Name = "idAluno";
            this.idAluno.ReadOnly = true;
            this.idAluno.ToolTipText = "Código de identificação do aluno";
            this.idAluno.Width = 50;
            // 
            // nomeAluno
            // 
            this.nomeAluno.HeaderText = "Nome";
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.ReadOnly = true;
            this.nomeAluno.ToolTipText = "Nome completo do aluno";
            this.nomeAluno.Width = 140;
            // 
            // cpfAluno
            // 
            this.cpfAluno.HeaderText = "CPF";
            this.cpfAluno.Name = "cpfAluno";
            this.cpfAluno.ReadOnly = true;
            this.cpfAluno.ToolTipText = "CPF do aluno";
            this.cpfAluno.Width = 80;
            // 
            // idadeAluno
            // 
            this.idadeAluno.HeaderText = "Idade";
            this.idadeAluno.Name = "idadeAluno";
            this.idadeAluno.ReadOnly = true;
            this.idadeAluno.ToolTipText = "Idade do aluno";
            this.idadeAluno.Width = 40;
            // 
            // btBuscarAluno
            // 
            this.btBuscarAluno.Location = new System.Drawing.Point(212, 70);
            this.btBuscarAluno.Name = "btBuscarAluno";
            this.btBuscarAluno.Size = new System.Drawing.Size(75, 23);
            this.btBuscarAluno.TabIndex = 7;
            this.btBuscarAluno.Text = "Buscar";
            this.btBuscarAluno.UseVisualStyleBackColor = true;
            this.btBuscarAluno.Click += new System.EventHandler(this.btBuscarAluno_Click);
            // 
            // tbAluno
            // 
            this.tbAluno.Location = new System.Drawing.Point(56, 73);
            this.tbAluno.Name = "tbAluno";
            this.tbAluno.Size = new System.Drawing.Size(150, 20);
            this.tbAluno.TabIndex = 6;
            // 
            // dgvAlunoCurso
            // 
            this.dgvAlunoCurso.AllowUserToAddRows = false;
            this.dgvAlunoCurso.AllowUserToDeleteRows = false;
            this.dgvAlunoCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunoCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvAlunoCurso.Location = new System.Drawing.Point(475, 99);
            this.dgvAlunoCurso.Name = "dgvAlunoCurso";
            this.dgvAlunoCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunoCurso.Size = new System.Drawing.Size(377, 246);
            this.dgvAlunoCurso.TabIndex = 13;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "selecionarAlunoCurso";
            this.dataGridViewCheckBoxColumn1.HeaderText = "...";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idAlunoCurso";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Código de identificação do aluno";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeAlunoCurso";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.ToolTipText = "Nome completo do aluno";
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cpfAlunoCurso";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.ToolTipText = "CPF do aluno";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idadeAlunoCurso";
            this.dataGridViewTextBoxColumn4.HeaderText = "Idade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.ToolTipText = "Idade do aluno";
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(394, 181);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 10;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(394, 210);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 11;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(394, 239);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // pbAlunoCurso
            // 
            this.pbAlunoCurso.Image = global::Apresentacao.Properties.Resources.AlunoCursoLogo;
            this.pbAlunoCurso.Location = new System.Drawing.Point(475, 61);
            this.pbAlunoCurso.Name = "pbAlunoCurso";
            this.pbAlunoCurso.Size = new System.Drawing.Size(38, 32);
            this.pbAlunoCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlunoCurso.TabIndex = 17;
            this.pbAlunoCurso.TabStop = false;
            // 
            // pbAluno
            // 
            this.pbAluno.Image = global::Apresentacao.Properties.Resources.estudanteLogo;
            this.pbAluno.Location = new System.Drawing.Point(12, 61);
            this.pbAluno.Name = "pbAluno";
            this.pbAluno.Size = new System.Drawing.Size(38, 32);
            this.pbAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAluno.TabIndex = 10;
            this.pbAluno.TabStop = false;
            // 
            // pbCurso
            // 
            this.pbCurso.Image = global::Apresentacao.Properties.Resources.CursoLogo;
            this.pbCurso.Location = new System.Drawing.Point(12, 12);
            this.pbCurso.Name = "pbCurso";
            this.pbCurso.Size = new System.Drawing.Size(38, 32);
            this.pbCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurso.TabIndex = 6;
            this.pbCurso.TabStop = false;
            // 
            // pbPeriodo
            // 
            this.pbPeriodo.Image = global::Apresentacao.Properties.Resources.PeriodoLogo;
            this.pbPeriodo.Location = new System.Drawing.Point(574, 12);
            this.pbPeriodo.Name = "pbPeriodo";
            this.pbPeriodo.Size = new System.Drawing.Size(38, 32);
            this.pbPeriodo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPeriodo.TabIndex = 3;
            this.pbPeriodo.TabStop = false;
            // 
            // pbProfessor
            // 
            this.pbProfessor.Image = global::Apresentacao.Properties.Resources.Professor;
            this.pbProfessor.Location = new System.Drawing.Point(293, 12);
            this.pbProfessor.Name = "pbProfessor";
            this.pbProfessor.Size = new System.Drawing.Size(38, 32);
            this.pbProfessor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfessor.TabIndex = 0;
            this.pbProfessor.TabStop = false;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(12, 393);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(82, 23);
            this.btCadastrar.TabIndex = 14;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(767, 393);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(82, 23);
            this.btSair.TabIndex = 17;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(100, 393);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(82, 23);
            this.btAlterar.TabIndex = 15;
            this.btAlterar.Text = "F12 Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(188, 393);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(82, 23);
            this.btExcluir.TabIndex = 16;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // cbDiaSemana
            // 
            this.cbDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiaSemana.FormattingEnabled = true;
            this.cbDiaSemana.Items.AddRange(new object[] {
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira"});
            this.cbDiaSemana.Location = new System.Drawing.Point(519, 73);
            this.cbDiaSemana.Name = "cbDiaSemana";
            this.cbDiaSemana.Size = new System.Drawing.Size(121, 21);
            this.cbDiaSemana.TabIndex = 8;
            // 
            // btFinalizarCurso
            // 
            this.btFinalizarCurso.Location = new System.Drawing.Point(12, 364);
            this.btFinalizarCurso.Name = "btFinalizarCurso";
            this.btFinalizarCurso.Size = new System.Drawing.Size(91, 23);
            this.btFinalizarCurso.TabIndex = 18;
            this.btFinalizarCurso.Text = "Finalizar Curso";
            this.btFinalizarCurso.UseVisualStyleBackColor = true;
            this.btFinalizarCurso.Click += new System.EventHandler(this.btFinalizarCurso_Click);
            // 
            // FrmControleAlunosCadAltExc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 431);
            this.Controls.Add(this.btFinalizarCurso);
            this.Controls.Add(this.cbDiaSemana);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.pbAlunoCurso);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.dgvAlunoCurso);
            this.Controls.Add(this.btBuscarAluno);
            this.Controls.Add(this.tbAluno);
            this.Controls.Add(this.pbAluno);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.btBuscarCurso);
            this.Controls.Add(this.tbCurso);
            this.Controls.Add(this.pbCurso);
            this.Controls.Add(this.btBuscarPeriodo);
            this.Controls.Add(this.tbPeriodo);
            this.Controls.Add(this.pbPeriodo);
            this.Controls.Add(this.btBuscarProfessor);
            this.Controls.Add(this.tbProfessor);
            this.Controls.Add(this.pbProfessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmControleAlunosCadAltExc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Alunos";
            this.Load += new System.EventHandler(this.FrmControleAlunosCadAltExc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunoCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlunoCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProfessor;
        private System.Windows.Forms.TextBox tbProfessor;
        private System.Windows.Forms.Button btBuscarProfessor;
        private System.Windows.Forms.Button btBuscarPeriodo;
        private System.Windows.Forms.TextBox tbPeriodo;
        private System.Windows.Forms.PictureBox pbPeriodo;
        private System.Windows.Forms.Button btBuscarCurso;
        private System.Windows.Forms.TextBox tbCurso;
        private System.Windows.Forms.PictureBox pbCurso;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Button btBuscarAluno;
        private System.Windows.Forms.TextBox tbAluno;
        private System.Windows.Forms.PictureBox pbAluno;
        private System.Windows.Forms.DataGridView dgvAlunoCurso;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.PictureBox pbAlunoCurso;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.ComboBox cbDiaSemana;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionarAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeAluno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btFinalizarCurso;
    }
}