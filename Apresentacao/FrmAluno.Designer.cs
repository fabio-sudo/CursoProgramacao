namespace Apresentacao
{
    partial class FrmAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAluno));
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbAluno = new System.Windows.Forms.Label();
            this.tbAluno = new System.Windows.Forms.TextBox();
            this.btBuscarAluno = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.pbAluno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAluno,
            this.nomeAluno,
            this.sobrenomeAluno,
            this.cpfAluno,
            this.celularAluno,
            this.enderecoAluno,
            this.idadeAluno,
            this.statusAluno});
            this.dgvAluno.Location = new System.Drawing.Point(15, 53);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAluno.Size = new System.Drawing.Size(795, 333);
            this.dgvAluno.TabIndex = 3;
            this.dgvAluno.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellDoubleClick);
            // 
            // idAluno
            // 
            this.idAluno.HeaderText = "ID";
            this.idAluno.Name = "idAluno";
            this.idAluno.ReadOnly = true;
            this.idAluno.ToolTipText = "Código identificação do aluno";
            this.idAluno.Width = 50;
            // 
            // nomeAluno
            // 
            this.nomeAluno.HeaderText = "Nome";
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.ReadOnly = true;
            this.nomeAluno.ToolTipText = "nome do aluno";
            this.nomeAluno.Width = 120;
            // 
            // sobrenomeAluno
            // 
            this.sobrenomeAluno.HeaderText = "Sobrenome";
            this.sobrenomeAluno.Name = "sobrenomeAluno";
            this.sobrenomeAluno.ReadOnly = true;
            this.sobrenomeAluno.ToolTipText = "sobrenome do aluno";
            // 
            // cpfAluno
            // 
            this.cpfAluno.HeaderText = "CPF";
            this.cpfAluno.Name = "cpfAluno";
            this.cpfAluno.ReadOnly = true;
            this.cpfAluno.ToolTipText = "CPF do aluno";
            this.cpfAluno.Width = 80;
            // 
            // celularAluno
            // 
            this.celularAluno.HeaderText = "Celular";
            this.celularAluno.Name = "celularAluno";
            this.celularAluno.ReadOnly = true;
            this.celularAluno.ToolTipText = "celular do aluno";
            this.celularAluno.Width = 80;
            // 
            // enderecoAluno
            // 
            this.enderecoAluno.HeaderText = "Endereço";
            this.enderecoAluno.Name = "enderecoAluno";
            this.enderecoAluno.ReadOnly = true;
            this.enderecoAluno.ToolTipText = "endereço do aluno";
            this.enderecoAluno.Width = 200;
            // 
            // idadeAluno
            // 
            this.idadeAluno.HeaderText = "Idade";
            this.idadeAluno.Name = "idadeAluno";
            this.idadeAluno.ReadOnly = true;
            this.idadeAluno.ToolTipText = "idade do aluno";
            this.idadeAluno.Width = 60;
            // 
            // statusAluno
            // 
            this.statusAluno.HeaderText = "Status";
            this.statusAluno.Name = "statusAluno";
            this.statusAluno.ReadOnly = true;
            this.statusAluno.ToolTipText = "status do aluno";
            this.statusAluno.Width = 60;
            // 
            // lbAluno
            // 
            this.lbAluno.AutoSize = true;
            this.lbAluno.Location = new System.Drawing.Point(66, 32);
            this.lbAluno.Name = "lbAluno";
            this.lbAluno.Size = new System.Drawing.Size(34, 13);
            this.lbAluno.TabIndex = 0;
            this.lbAluno.Text = "Aluno";
            // 
            // tbAluno
            // 
            this.tbAluno.Location = new System.Drawing.Point(106, 25);
            this.tbAluno.Name = "tbAluno";
            this.tbAluno.Size = new System.Drawing.Size(178, 20);
            this.tbAluno.TabIndex = 1;
            // 
            // btBuscarAluno
            // 
            this.btBuscarAluno.Location = new System.Drawing.Point(290, 24);
            this.btBuscarAluno.Name = "btBuscarAluno";
            this.btBuscarAluno.Size = new System.Drawing.Size(75, 23);
            this.btBuscarAluno.TabIndex = 2;
            this.btBuscarAluno.Text = "F5 Buscar";
            this.btBuscarAluno.UseVisualStyleBackColor = true;
            this.btBuscarAluno.Click += new System.EventHandler(this.btBuscarAluno_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(15, 392);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(85, 23);
            this.btCadastrar.TabIndex = 4;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.Location = new System.Drawing.Point(106, 392);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(85, 23);
            this.btSelecionar.TabIndex = 5;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = true;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(725, 392);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(85, 23);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // pbAluno
            // 
            this.pbAluno.Image = global::Apresentacao.Properties.Resources.estudanteLogo;
            this.pbAluno.Location = new System.Drawing.Point(15, 5);
            this.pbAluno.Name = "pbAluno";
            this.pbAluno.Size = new System.Drawing.Size(45, 40);
            this.pbAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAluno.TabIndex = 4;
            this.pbAluno.TabStop = false;
            // 
            // FrmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 437);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.pbAluno);
            this.Controls.Add(this.btBuscarAluno);
            this.Controls.Add(this.tbAluno);
            this.Controls.Add(this.lbAluno);
            this.Controls.Add(this.dgvAluno);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FrmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Alunos";
            this.Load += new System.EventHandler(this.FrmAluno_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAluno_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusAluno;
        private System.Windows.Forms.Label lbAluno;
        private System.Windows.Forms.TextBox tbAluno;
        private System.Windows.Forms.Button btBuscarAluno;
        private System.Windows.Forms.PictureBox pbAluno;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btSair;
    }
}