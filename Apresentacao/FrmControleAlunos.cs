using Negocios;
using ObjetoTransferencia;
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
    public partial class FrmControleAlunos : Form
    {
        ListaAlunoCurso litaAlunoCurso = new ListaAlunoCurso();
        NegAlunoCurso nAlunoCurso = new NegAlunoCurso();

        Aluno alunoSelecionado = new Aluno();
        Curso cursoSelecionado = new Curso();
        Periodo periodoSelecionado = new Periodo();
        Professor professorSelecionado = new Professor();

        public FrmControleAlunos()
        {
            InitializeComponent();
        }

        //métodos
        private void metodoAtualizaDataGrid() {

            //Limpando Data Grid
            dgvAluno.Rows.Clear();

            if (litaAlunoCurso.Count > 0)
            {
                //Adicionando Linhas no gride "ROW"
                dgvAluno.Rows.Add(litaAlunoCurso.Count);
            }
            else { return; }

            //Indice demarca a linha "ROW" que o valor será atribuido
            int indice = 0;
            //Enquanto houver alunos na lista os valores serão atribuidos no gride
            foreach (AlunoCurso alunoCurso in this.litaAlunoCurso)
            {
                this.dgvAluno[0, indice].Value = alunoCurso.idAlunoCurso;
                this.dgvAluno[1, indice].Value = alunoCurso.Curso.nomeCurso;
                this.dgvAluno[2, indice].Value = alunoCurso.Curso.duracaoCurso;
                this.dgvAluno[3, indice].Value = alunoCurso.Aluno.nomeAluno + " " + alunoCurso.Aluno.sobrenomeAluno;
                this.dgvAluno[4, indice].Value = alunoCurso.Aluno.celularAluno; 
                this.dgvAluno[5, indice].Value = alunoCurso.Aluno.idadeAluno;
                this.dgvAluno[6, indice].Value = alunoCurso.Professor.nomeProfessor + " " + alunoCurso.Professor.sobrenomeProfessor;
                this.dgvAluno[7, indice].Value = alunoCurso.diaSemanaCurso;
                this.dgvAluno[8, indice].Value = alunoCurso.Periodo.nomePeriodo;
                this.dgvAluno[9, indice].Value = alunoCurso.Periodo.horarioInicialPeriodo;
                this.dgvAluno[10, indice].Value = alunoCurso.Periodo.horarioFinalPeriodo;
                this.dgvAluno[11, indice].Value = alunoCurso.statusCurso;


                indice++;
            }

            dgvAluno.Update();         
        
        }


        //Filtros
        private void btBuscarAluno_Click(object sender, EventArgs e)
        {
            
            FrmAluno frmAluno = new FrmAluno(tbAluno.Text);

            DialogResult resultado = frmAluno.ShowDialog();
            
            if (resultado == DialogResult.OK) {

                alunoSelecionado = frmAluno.alunoSelecionado;
                tbAluno.Text = alunoSelecionado.nomeAluno;
            
            }

        }

        private void btBuscarCurso_Click(object sender, EventArgs e)
        {
            FrmCurso frmCurso = new FrmCurso(tbCurso.Text);
            DialogResult resultado = frmCurso.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                cursoSelecionado = frmCurso.cursoSelecionado;
                tbCurso.Text = cursoSelecionado.nomeCurso;

            }
        }

        private void btBuscarProfessor_Click(object sender, EventArgs e)
        {
            FrmProfessor frmProfessor = new FrmProfessor(tbProfessor.Text);
            DialogResult resultado = frmProfessor.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                professorSelecionado = frmProfessor.ProfessorSelecionado;
                tbProfessor.Text = professorSelecionado.nomeProfessor;

            }
        }

        private void btBuscarPeriodo_Click(object sender, EventArgs e)
        {
            FrmPeriodo frmPeriodo = new FrmPeriodo(tbPeriodo.Text);
            DialogResult resultado = frmPeriodo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                periodoSelecionado = frmPeriodo.periodoSelecionado;
                tbPeriodo.Text = periodoSelecionado.nomePeriodo;

            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Deseja realmente sair?",
            "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Cadastro
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmControleAlunosCadAltExc FrmControleAlunosCadAltExc = new FrmControleAlunosCadAltExc("Cadastro", 0);
            FrmControleAlunosCadAltExc.ShowDialog();
        }

        //Buscar
        private void btGerar_Click(object sender, EventArgs e)
        {
            if (tbAluno.Text == string.Empty && tbCurso.Text == string.Empty &&
                tbProfessor.Text == string.Empty && tbPeriodo.Text == string.Empty)
            {

                litaAlunoCurso = nAlunoCurso.BuscarAlunosCursoTodos();
                metodoAtualizaDataGrid();
            }
            else {

                litaAlunoCurso = nAlunoCurso.BuscarAlunosCursoPorFiltros(tbAluno.Text,tbCurso.Text,
                    tbProfessor.Text,tbPeriodo.Text);
                metodoAtualizaDataGrid();
            }

        }

        //Teclas de Atalho
        private void FrmControleAlunos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btSelecionar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btGerar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            //Retorna o ID do aluno da célula que está selecionda
            if (dgvAluno.Rows.Count > 0)
            {
                int indiceRegistroSelecionado = Convert.ToInt32(dgvAluno.CurrentRow.Cells[0].Value);
                FrmControleAlunosCadAltExc FrmControleAlunosCadAltExc = new FrmControleAlunosCadAltExc("Alterar", indiceRegistroSelecionado);
                FrmControleAlunosCadAltExc.ShowDialog();
                btGerar.PerformClick();
            }
        }
    }
}
