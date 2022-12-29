namespace Apresentacao
{
    partial class FrmPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeriodo));
            this.btSair = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btBuscarPeriodo = new System.Windows.Forms.Button();
            this.tbPeriodo = new System.Windows.Forms.TextBox();
            this.lbPeriodo = new System.Windows.Forms.Label();
            this.dgvPeriodo = new System.Windows.Forms.DataGridView();
            this.idProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbPeriodo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(356, 401);
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
            // btBuscarPeriodo
            // 
            this.btBuscarPeriodo.Location = new System.Drawing.Point(298, 29);
            this.btBuscarPeriodo.Name = "btBuscarPeriodo";
            this.btBuscarPeriodo.Size = new System.Drawing.Size(75, 23);
            this.btBuscarPeriodo.TabIndex = 2;
            this.btBuscarPeriodo.Text = "Buscar";
            this.btBuscarPeriodo.UseVisualStyleBackColor = true;
            this.btBuscarPeriodo.Click += new System.EventHandler(this.btBuscarPeriodo_Click);
            // 
            // tbPeriodo
            // 
            this.tbPeriodo.Location = new System.Drawing.Point(114, 32);
            this.tbPeriodo.Name = "tbPeriodo";
            this.tbPeriodo.Size = new System.Drawing.Size(178, 20);
            this.tbPeriodo.TabIndex = 1;
            // 
            // lbPeriodo
            // 
            this.lbPeriodo.AutoSize = true;
            this.lbPeriodo.Location = new System.Drawing.Point(63, 39);
            this.lbPeriodo.Name = "lbPeriodo";
            this.lbPeriodo.Size = new System.Drawing.Size(45, 13);
            this.lbPeriodo.TabIndex = 0;
            this.lbPeriodo.Text = "Período";
            // 
            // dgvPeriodo
            // 
            this.dgvPeriodo.AllowUserToAddRows = false;
            this.dgvPeriodo.AllowUserToDeleteRows = false;
            this.dgvPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProfessor,
            this.nomePeriodo,
            this.horarioInicio,
            this.HorarioFim});
            this.dgvPeriodo.Location = new System.Drawing.Point(12, 60);
            this.dgvPeriodo.Name = "dgvPeriodo";
            this.dgvPeriodo.ReadOnly = true;
            this.dgvPeriodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeriodo.Size = new System.Drawing.Size(429, 333);
            this.dgvPeriodo.TabIndex = 3;
            this.dgvPeriodo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeriodo_CellDoubleClick);
            // 
            // idProfessor
            // 
            this.idProfessor.HeaderText = "ID";
            this.idProfessor.Name = "idProfessor";
            this.idProfessor.ReadOnly = true;
            this.idProfessor.ToolTipText = "Código identificação do período";
            this.idProfessor.Width = 50;
            // 
            // nomePeriodo
            // 
            this.nomePeriodo.HeaderText = "Nome";
            this.nomePeriodo.Name = "nomePeriodo";
            this.nomePeriodo.ReadOnly = true;
            this.nomePeriodo.ToolTipText = "Nome do período ";
            this.nomePeriodo.Width = 120;
            // 
            // horarioInicio
            // 
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            this.horarioInicio.DefaultCellStyle = dataGridViewCellStyle1;
            this.horarioInicio.HeaderText = "Horário Inicio";
            this.horarioInicio.Name = "horarioInicio";
            this.horarioInicio.ReadOnly = true;
            this.horarioInicio.ToolTipText = "Horário inicial das aulas";
            // 
            // HorarioFim
            // 
            dataGridViewCellStyle2.Format = "t";
            this.HorarioFim.DefaultCellStyle = dataGridViewCellStyle2;
            this.HorarioFim.HeaderText = "Horário Fim";
            this.HorarioFim.Name = "HorarioFim";
            this.HorarioFim.ReadOnly = true;
            this.HorarioFim.ToolTipText = "Horário final das aulas";
            // 
            // pbPeriodo
            // 
            this.pbPeriodo.Image = global::Apresentacao.Properties.Resources.PeriodoLogo;
            this.pbPeriodo.Location = new System.Drawing.Point(12, 12);
            this.pbPeriodo.Name = "pbPeriodo";
            this.pbPeriodo.Size = new System.Drawing.Size(45, 40);
            this.pbPeriodo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPeriodo.TabIndex = 22;
            this.pbPeriodo.TabStop = false;
            // 
            // FrmPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 436);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.pbPeriodo);
            this.Controls.Add(this.btBuscarPeriodo);
            this.Controls.Add(this.tbPeriodo);
            this.Controls.Add(this.lbPeriodo);
            this.Controls.Add(this.dgvPeriodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Período";
            this.Load += new System.EventHandler(this.FrmPeriodo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPeriodo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeriodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.PictureBox pbPeriodo;
        private System.Windows.Forms.Button btBuscarPeriodo;
        private System.Windows.Forms.TextBox tbPeriodo;
        private System.Windows.Forms.Label lbPeriodo;
        private System.Windows.Forms.DataGridView dgvPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioFim;
    }
}