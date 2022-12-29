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
    public partial class FrmControleAlunosCadAltExc : Form
    {
        ListaAlunoCurso listaAlunoCurso = new ListaAlunoCurso();//Lista preenchida pelo método de busca de matricula
       
        NegAlunoCurso nAlunoCurso = new NegAlunoCurso();

        ListaAlunos listaAlunoSelecionado = new ListaAlunos();
        ListaAlunos listaAlunosCursoSelecionado = new ListaAlunos();
        ListaAlunos listaAlunosAntigos = new ListaAlunos();

        Aluno alunoSelecionado = new Aluno();
        NegAluno nAluno = new NegAluno();

        Curso cursoSelecionado = new Curso();
        Periodo periodoSelecionado = new Periodo();
        Professor professorSelecionado = new Professor();

        int matriculaCurso;//Utilizado para realizar busca dos dados

        string formularioSelecionado;

        public FrmControleAlunosCadAltExc(string FormularioSelecionado, int matricula)
        {
            InitializeComponent();

            formularioSelecionado = FormularioSelecionado;
            matriculaCurso = matricula;
        }

        //Preenche valore do Data Gride
        private void metodoAtualizaDataGridAluno()
        {

            //Limpando Data Grid
            dgvAluno.Rows.Clear();

            if (listaAlunoSelecionado.Count > 0)
            {

                //Indice demarca a linha "ROW" que o valor será atribuido
                int indice = 0;
                //Enquanto houver alunos na lista os valores serão atribuidos no gride
                foreach (Aluno aluno in this.listaAlunoSelecionado)
                {
                    if (aluno.statusAluno != "Cursando" || formularioSelecionado != "Cadastro")
                    {
                        dgvAluno.Rows.Add();
                        this.dgvAluno[1, indice].Value = aluno.idAluno;
                        this.dgvAluno[2, indice].Value = aluno.nomeAluno;
                        this.dgvAluno[3, indice].Value = aluno.cpfAluno;
                        this.dgvAluno[4, indice].Value = aluno.idadeAluno;

                        indice++;
                    }
                }

                dgvAluno.Update();
            }
        }

        //Preenche valore do Data Gride
        private void metodoAtualizaDataGridAlunoCurso()
        {

            //Limpando Data Grid
            dgvAlunoCurso.Rows.Clear();

            if (listaAlunosCursoSelecionado.Count > 0)
            {
                //Adicionando Linhas no gride "ROW"
                dgvAlunoCurso.Rows.Add(listaAlunosCursoSelecionado.Count);
            }
            else { return; }

            //Indice demarca a linha "ROW" que o valor será atribuido
            int indice = 0;
            //Enquanto houver alunos na lista os valores serão atribuidos no gride
            foreach (Aluno aluno in this.listaAlunosCursoSelecionado)
            {
                this.dgvAlunoCurso[1, indice].Value = aluno.idAluno;
                this.dgvAlunoCurso[2, indice].Value = aluno.nomeAluno + " " + aluno.sobrenomeAluno;
                this.dgvAlunoCurso[3, indice].Value = aluno.cpfAluno;
                this.dgvAlunoCurso[4, indice].Value = aluno.idadeAluno;

                indice++;
            }

            dgvAlunoCurso.Update();
        }

        //construtor do formulário
        private void metodoContrutor()
        {
            if (formularioSelecionado.Equals("Cadastro"))
            {
                btAlterar.Visible = false;
                btExcluir.Visible = false;
                btFinalizarCurso.Visible = false;
            }
            //Caso não for formulário de cadastro e um formulário de Alteração e Exclusão
            else
            {
                //Adicionando items ao nosso formulário
                listaAlunoCurso = nAlunoCurso.BuscarAlunosCursoPorMatricula(matriculaCurso);
                if (listaAlunoCurso.Count > 0) {
                    foreach (AlunoCurso alunoCurso in listaAlunoCurso)
                    {

                        listaAlunosCursoSelecionado.Add(alunoCurso.Aluno);
                        listaAlunosAntigos.Add(alunoCurso.Aluno);
                    }

                    metodoAtualizaDataGridAlunoCurso();                
                }
                cbDiaSemana.SelectedItem = listaAlunoCurso[0].diaSemanaCurso;

                //Instanciando nosso objetos
                cursoSelecionado = listaAlunoCurso[0].Curso;
                professorSelecionado = listaAlunoCurso[0].Professor;
                periodoSelecionado = listaAlunoCurso[0].Periodo;
                
                //Preenchendo Controles
                tbCurso.Text = cursoSelecionado.nomeCurso;
                tbProfessor.Text = professorSelecionado.nomeProfessor;
                tbPeriodo.Text = periodoSelecionado.nomePeriodo;

                //Controles
                btCadastrar.Visible = false;
                btFinalizarCurso.Visible = true;
                btAlterar.Visible = true;
                btExcluir.Visible = true;

            }
        }

        //verifica alunos já adicionados 
        private void metodoAtualizaListaADD() {

            if (listaAlunosCursoSelecionado.Count > 0) { 
            
            //Percorre a lista de alunos adicionados
            foreach(Aluno alunoRemovido in listaAlunosCursoSelecionado){

                //percorre a lista de alunos
                foreach (Aluno alunoARemover in listaAlunoSelecionado) {

                    //Verifica se aluno já foi adicionado e o remove da lista
                    if (alunoRemovido.idAluno == alunoARemover.idAluno) {

                        listaAlunoSelecionado.Remove(alunoARemover);
                        break;
                    }              
                }            
            
            }

            metodoAtualizaDataGridAluno();      
            }
        
        }

        //Valida Preenchimento dos campos
        private Boolean metodoValidaCadastro() {

            if (tbCurso.Text == string.Empty || cursoSelecionado == null)
            {

                MessageBox.Show("Selecione o Curso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCurso.Focus();
                return false;
            }
            if (tbProfessor.Text == string.Empty || professorSelecionado == null)
            {

                MessageBox.Show("Selecione o Professor do curso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbProfessor.Focus();
                return false;
            }
            if (tbPeriodo.Text == string.Empty || cursoSelecionado == null)
            {

                MessageBox.Show("Selecione o Período do curso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPeriodo.Focus();
                return false;
            }
            if (cbDiaSemana.Text == string.Empty)
            {

                MessageBox.Show("Selecione o dia da semana do Curso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbDiaSemana.Focus();
                return false;
            }

            if (dgvAlunoCurso.Rows.Count <= 0) {

                    MessageBox.Show("Adicione os alunos ao Curso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbAluno.Focus();
                    return false;
            }

            return true;
        }

        //Limpa campos
        private void metodoLimpaCampos(){
        
            //instanciando objetos como nulos
            cursoSelecionado = null;
            periodoSelecionado = null;
            professorSelecionado = null;

            //Limpa os campos
            tbAluno.Clear();
            tbCurso.Clear();
            tbProfessor.Clear();
            tbPeriodo.Clear();
            cbDiaSemana.SelectedItem = null;


            //Limpa os grides e zera as listas
            btLimpar.PerformClick();      
        }

        //----------------Controles

        //--------------Formulário
        private void FrmControleAlunosCadAltExc_Load(object sender, EventArgs e)
        {
            //instanciando objetos
            cursoSelecionado = null;
            periodoSelecionado = null;
            professorSelecionado = null;

            //Criando formulário dinamicamente
            metodoContrutor();
        }

        //--------------Buscar
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

        //--------------Aluno
        private void btBuscarAluno_Click(object sender, EventArgs e)
        {
            //Instanciando listaAlunos
            listaAlunoSelecionado = new ListaAlunos();

            listaAlunoSelecionado = nAluno.BuscarAlunosCursoPorNome(tbAluno.Text);
            metodoAtualizaListaADD();

            metodoAtualizaDataGridAluno();
            
            }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
                    
            foreach (DataGridViewRow row in dgvAluno.Rows) { 
            
            if((bool)row.Cells[0].FormattedValue == true){

                Aluno novoAluno = new Aluno();
                novoAluno.idAluno = Convert.ToInt32(row.Cells[1].Value);
                novoAluno.nomeAluno = row.Cells[2].Value.ToString();
                novoAluno.cpfAluno = row.Cells[3].Value.ToString();
                novoAluno.idadeAluno = row.Cells[4].Value.ToString();

                listaAlunosCursoSelecionado.Add(novoAluno);
            }

            }

            metodoAtualizaDataGridAlunoCurso();
            metodoAtualizaListaADD();

        }   

        private void btRemover_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAlunoCurso.Rows)
            {
                if ((bool)row.Cells[0].FormattedValue == true)
                {

                    Aluno novoAluno = new Aluno();
                    novoAluno.idAluno = Convert.ToInt32(row.Cells[1].Value);
                    novoAluno.nomeAluno = row.Cells[2].Value.ToString();
                    novoAluno.cpfAluno = row.Cells[3].Value.ToString();
                    novoAluno.idadeAluno = row.Cells[4].Value.ToString();

                    listaAlunoSelecionado.Add(novoAluno);

                    foreach (Aluno alunoRemove in listaAlunosCursoSelecionado) {


                        if (alunoRemove.idAluno == novoAluno.idAluno) {

                            listaAlunosCursoSelecionado.Remove(alunoRemove);
                            break;
                        }
                    
                    }

                }
            }

            metodoAtualizaDataGridAlunoCurso();
            metodoAtualizaDataGridAluno();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            dgvAlunoCurso.Rows.Clear();
            dgvAluno.Rows.Clear();
            listaAlunosCursoSelecionado.Clear();

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Faz  a validação dos dados do formulário para realizar o cadastramento
            if (metodoValidaCadastro() == true) { 
            
             AlunoCurso objCurso = new AlunoCurso();
                objCurso.Curso = cursoSelecionado;
                objCurso.Professor = professorSelecionado;
                objCurso.Periodo = periodoSelecionado;
                objCurso.idAlunoCurso = nAlunoCurso.BuscarMatricula();//Busca nosso indice e adiciona 1 para realizar o cadastro
                objCurso.diaSemanaCurso = cbDiaSemana.Text;
                objCurso.statusCurso = "Cursando";


                DialogResult resultado;
                if (nAlunoCurso.cadastraAlunoCurso(objCurso, listaAlunosCursoSelecionado) == true)
                {

                    resultado = MessageBox.Show(" Alunos Vinculado ao Curso com sucesso" + "\n Deseja sair do cadastro?",
                               "Cadastro Realizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (resultado == DialogResult.Yes)
                    {
                        DialogResult = DialogResult.Yes;
                        this.Close();

                    }
                    else
                    {

                        metodoLimpaCampos();
                    }
                }
                else { MessageBox.Show("Erro ao realizar Cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }


            }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Juta as listas
            listaAlunosCursoSelecionado.AddRange(listaAlunosAntigos);
              
              //criando lista de itens unicos
              var listaAlunosAltera =   listaAlunosCursoSelecionado.GroupBy(x => x.idAluno).
                Where(item => item.Count() == 1);

              //Lista de itens para passar para método
              List<int> alunosAltera = new List<int>();

              //Converter itens para ID do aluno
              foreach (var item in listaAlunosAltera) { 
              
                  alunosAltera.Add(Convert.ToInt32(item.Key));        
              }

            //Faz  a validação dos dados do formulário para realizar o cadastramento
            if (metodoValidaCadastro() == true)
            {

                AlunoCurso objCurso = new AlunoCurso();
                objCurso.Curso = cursoSelecionado;
                objCurso.Professor = professorSelecionado;
                objCurso.Periodo = periodoSelecionado;
                objCurso.idAlunoCurso = matriculaCurso;
                objCurso.diaSemanaCurso = cbDiaSemana.Text;
                objCurso.statusCurso = "Cursando";

                DialogResult resultado;
                if (nAlunoCurso.AlterarAlunoCurso(objCurso, alunosAltera) == true)
                {

                    resultado = MessageBox.Show(" Alunos Vinculados ao Curso com sucesso" + "\n Deseja sair da alterção?",
                               "Alterações Realizadas", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (resultado == DialogResult.Yes)
                    {
                        DialogResult = DialogResult.Yes;
                        this.Close();

                    }
                }
                else { MessageBox.Show("Erro ao realizar Cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show(" Deseja realmente realizar a exclusão ?",
                               "Exclusão Realizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

               if (resultado == DialogResult.Yes)             
                 {
                     //Volta status dos alunos do curso para a lista de espera
                     if (nAlunoCurso.StatusAlunoCurso(listaAlunoCurso[0], listaAlunosAntigos, "Espera") == true)
                     {


                         if (nAlunoCurso.ExcluirAlunoCurso(listaAlunoCurso[0]) == true)
                         {

                             MessageBox.Show("Exclusão realizadacom sucesso!",
                                           "Exclusão Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                             DialogResult = DialogResult.Yes;
                             this.Close();
                         }

                         else { MessageBox.Show("Erro ao realizar exclusão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }


                     }


                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btFinalizarCurso_Click(object sender, EventArgs e)
        {
            string status;

            if (listaAlunoCurso[0].statusCurso == "Finalizado")
            {

                status = "Cursando";
            }
            else {


                status = "Finalizado";
            
            }
            
            {
                DialogResult resultado = MessageBox.Show(" Deseja finalizar este curso ?",
                               "Curso finalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    if (nAlunoCurso.StatusAlunoCurso(listaAlunoCurso[0], listaAlunosAntigos, status) == true)
                    {
                        MessageBox.Show("Curso finalizado sucesso!",
                                          "Encerramento Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DialogResult = DialogResult.Yes;
                        this.Close();
                    }

                }
            }
        }

    
    }
}
