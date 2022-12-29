using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButtonAluno_Click(object sender, EventArgs e)
        {
               FrmAluno frmAluno = new FrmAluno();
               // Set the Parent Form of the Child window.
               frmAluno.MdiParent = this;
               // Display the new form.
               frmAluno.Show();
         }

        private void toolStripButtonProfessor_Click(object sender, EventArgs e)
        {
            FrmProfessor frmProfessor = new FrmProfessor();
            // Set the Parent Form of the Child window.
            frmProfessor.MdiParent = this;
            // Display the new form.
            frmProfessor.Show();
        }

        private void toolStripButtonPeriodo_Click(object sender, EventArgs e)
        {
            FrmPeriodo frmPeriodo = new FrmPeriodo();
            // Set the Parent Form of the Child window.
            frmPeriodo.MdiParent = this;
            // Display the new form.
            frmPeriodo.Show();
        }

        private void toolStripButtonCurso_Click(object sender, EventArgs e)
        {
            FrmCurso frmCurso = new FrmCurso();
            // Set the Parent Form of the Child window.
            frmCurso.MdiParent = this;
            // Display the new form.
            frmCurso.Show();
        }

        private void toolStripButtonMatricula_Click(object sender, EventArgs e)
        {
            FrmControleAlunos frmControleAlunos = new FrmControleAlunos();
            // Set the Parent Form of the Child window.
            frmControleAlunos.MdiParent = this;
            // Display the new form.
            frmControleAlunos.Show();
        }

        private void toolStripButtonSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {

                return;
            }
            else
            {
                this.Close();
            }
        }



        }
    }
