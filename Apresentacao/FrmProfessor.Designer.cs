namespace Apresentacao
{
    partial class FrmProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessor));
            this.btSair = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btBuscarProfessor = new System.Windows.Forms.Button();
            this.tbProfessor = new System.Windows.Forms.TextBox();
            this.lbProfessor = new System.Windows.Forms.Label();
            this.dgvProfessor = new System.Windows.Forms.DataGridView();
            this.idProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbProfessor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(662, 399);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(85, 23);
            this.btSair.TabIndex = 16;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.Location = new System.Drawing.Point(103, 399);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(85, 23);
            this.btSelecionar.TabIndex = 15;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = true;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(12, 399);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(85, 23);
            this.btCadastrar.TabIndex = 14;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btBuscarProfessor
            // 
            this.btBuscarProfessor.Location = new System.Drawing.Point(304, 31);
            this.btBuscarProfessor.Name = "btBuscarProfessor";
            this.btBuscarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btBuscarProfessor.TabIndex = 12;
            this.btBuscarProfessor.Text = "Buscar";
            this.btBuscarProfessor.UseVisualStyleBackColor = true;
            this.btBuscarProfessor.Click += new System.EventHandler(this.btBuscarProfessor_Click);
            // 
            // tbProfessor
            // 
            this.tbProfessor.Location = new System.Drawing.Point(120, 32);
            this.tbProfessor.Name = "tbProfessor";
            this.tbProfessor.Size = new System.Drawing.Size(178, 20);
            this.tbProfessor.TabIndex = 11;
            // 
            // lbProfessor
            // 
            this.lbProfessor.AutoSize = true;
            this.lbProfessor.Location = new System.Drawing.Point(63, 39);
            this.lbProfessor.Name = "lbProfessor";
            this.lbProfessor.Size = new System.Drawing.Size(51, 13);
            this.lbProfessor.TabIndex = 10;
            this.lbProfessor.Text = "Professor";
            // 
            // dgvProfessor
            // 
            this.dgvProfessor.AllowUserToAddRows = false;
            this.dgvProfessor.AllowUserToDeleteRows = false;
            this.dgvProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProfessor,
            this.nomeProfessor,
            this.sobrenomeProfessor,
            this.cpfProfessor,
            this.celularProfessor,
            this.enderecoProfessor,
            this.idadeProfessor});
            this.dgvProfessor.Location = new System.Drawing.Point(12, 60);
            this.dgvProfessor.Name = "dgvProfessor";
            this.dgvProfessor.ReadOnly = true;
            this.dgvProfessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfessor.Size = new System.Drawing.Size(735, 333);
            this.dgvProfessor.TabIndex = 9;
            this.dgvProfessor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfessor_CellDoubleClick);
            // 
            // idProfessor
            // 
            this.idProfessor.HeaderText = "ID";
            this.idProfessor.Name = "idProfessor";
            this.idProfessor.ReadOnly = true;
            this.idProfessor.ToolTipText = "Código identificação do professor";
            this.idProfessor.Width = 50;
            // 
            // nomeProfessor
            // 
            this.nomeProfessor.HeaderText = "Nome";
            this.nomeProfessor.Name = "nomeProfessor";
            this.nomeProfessor.ReadOnly = true;
            this.nomeProfessor.ToolTipText = "nome do professor";
            this.nomeProfessor.Width = 120;
            // 
            // sobrenomeProfessor
            // 
            this.sobrenomeProfessor.HeaderText = "Sobrenome";
            this.sobrenomeProfessor.Name = "sobrenomeProfessor";
            this.sobrenomeProfessor.ReadOnly = true;
            this.sobrenomeProfessor.ToolTipText = "sobrenome do professor";
            // 
            // cpfProfessor
            // 
            this.cpfProfessor.HeaderText = "CPF";
            this.cpfProfessor.Name = "cpfProfessor";
            this.cpfProfessor.ReadOnly = true;
            this.cpfProfessor.ToolTipText = "CPF do professor";
            this.cpfProfessor.Width = 80;
            // 
            // celularProfessor
            // 
            this.celularProfessor.HeaderText = "Celular";
            this.celularProfessor.Name = "celularProfessor";
            this.celularProfessor.ReadOnly = true;
            this.celularProfessor.ToolTipText = "celular do professor";
            this.celularProfessor.Width = 80;
            // 
            // enderecoProfessor
            // 
            this.enderecoProfessor.HeaderText = "Endereço";
            this.enderecoProfessor.Name = "enderecoProfessor";
            this.enderecoProfessor.ReadOnly = true;
            this.enderecoProfessor.ToolTipText = "endereço do professor";
            this.enderecoProfessor.Width = 200;
            // 
            // idadeProfessor
            // 
            this.idadeProfessor.HeaderText = "Idade";
            this.idadeProfessor.Name = "idadeProfessor";
            this.idadeProfessor.ReadOnly = true;
            this.idadeProfessor.ToolTipText = "idade do professor";
            this.idadeProfessor.Width = 60;
            // 
            // pbProfessor
            // 
            this.pbProfessor.Image = global::Apresentacao.Properties.Resources.Professor;
            this.pbProfessor.Location = new System.Drawing.Point(12, 12);
            this.pbProfessor.Name = "pbProfessor";
            this.pbProfessor.Size = new System.Drawing.Size(45, 40);
            this.pbProfessor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfessor.TabIndex = 13;
            this.pbProfessor.TabStop = false;
            // 
            // FrmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 440);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.pbProfessor);
            this.Controls.Add(this.btBuscarProfessor);
            this.Controls.Add(this.tbProfessor);
            this.Controls.Add(this.lbProfessor);
            this.Controls.Add(this.dgvProfessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Professores";
            this.Load += new System.EventHandler(this.FrmProfessor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProfessor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.PictureBox pbProfessor;
        private System.Windows.Forms.Button btBuscarProfessor;
        private System.Windows.Forms.TextBox tbProfessor;
        private System.Windows.Forms.Label lbProfessor;
        private System.Windows.Forms.DataGridView dgvProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeProfessor;
    }
}