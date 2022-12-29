using Negocios;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmCurso : Form
    {

        ListaCursos listaCursos = new ListaCursos();
        Curso objCurso = new Curso();
        NegCurso nCurso = new NegCurso();

        //Para poder ser acessado 
        public Curso cursoSelecionado = new Curso();
        string strCursoSelecionado;


        public FrmCurso([Optional] string selecionaCurso)
        {
            InitializeComponent();

            strCursoSelecionado = selecionaCurso;
        }


        //Preenche valore do Data Gride
        private void metodoAtualizaDataGrid()
        {

            //Limpando Data Grid
            dgvCurso.Rows.Clear();

            if (listaCursos.Count > 0)
            {
                //Adicionando Linhas no gride "ROW"
                dgvCurso.Rows.Add(listaCursos.Count);
            }
            else { return; }

            //Indice demarca a linha "ROW" que o valor será atribuido
            int indice = 0;
            //Enquanto houver alunos na lista os valores serão atribuidos no gride
            foreach (Curso curso in this.listaCursos)
            {
                this.dgvCurso[0, indice].Value = curso.idCurso;
                this.dgvCurso[1, indice].Value = curso.nomeCurso;
                this.dgvCurso[2, indice].Value = curso.ementaCurso;
                this.dgvCurso[3, indice].Value = curso.duracaoCurso;

                indice++;
            }

            dgvCurso.Update();
        }

        //Método preenche lista de alunos e realiza a busca
        private void metodoBuscarCurso()
        {

            //Instanciando listaAlunos
            listaCursos = new ListaCursos();

            //Verifica se o valor digitado na Caixa de Texto e numero ou texto
            int n;
            bool ehUmNumero = int.TryParse(tbCurso.Text, out n);

            //Se for numero busca somente o Aluno Por ID
            if (ehUmNumero == true)
            {
                objCurso = nCurso.BuscarCursoPorCodigo(n);
                listaCursos.Add(objCurso);
                tbCurso.Text = objCurso.nomeCurso;
                metodoAtualizaDataGrid();
            }
            //Se for texto busca o aluno por Nome
            else
            {
                listaCursos = nCurso.BuscarCursosPorNome(tbCurso.Text);
                metodoAtualizaDataGrid();

            }
        }

        //--------------------Controles
        private void btBuscarCurso_Click(object sender, EventArgs e)
        {
            metodoBuscarCurso();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmCursoCadAltExc frmCadastrar = new FrmCursoCadAltExc("Cadastro", null);
            frmCadastrar.ShowDialog();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
           cursoSelecionado = new Curso();

            //Verifica se tem items no grid
            if (this.dgvCurso.Rows.Count > 0)
            {
                //Retorna o ID do aluno da célula que está selecionda
                int indiceRegistroSelecionado = Convert.ToInt32(dgvCurso.CurrentRow.Cells[0].Value);
                foreach (Curso curso in listaCursos)
                {
                    if (curso.idCurso == indiceRegistroSelecionado)
                    {
                        cursoSelecionado = curso;
                        break;

                    }
                }

                if (strCursoSelecionado != null) {

                    DialogResult = DialogResult.OK;
                    this.Close();             
                }


                else
                {
                    DialogResult resultado;

                    FrmCursoCadAltExc frmAlterar = new FrmCursoCadAltExc("Alterar", cursoSelecionado);
                    resultado = frmAlterar.ShowDialog();

                    //Caso a alteração ou exclusão do item o formulário realiza a atulização dos dados do grid
                    if (resultado == DialogResult.Yes) { btBuscarCurso.PerformClick(); }
                }
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

        private void dgvCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmCurso_KeyDown(object sender, KeyEventArgs e)
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
                btBuscarCurso.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            if (strCursoSelecionado != null) {

                tbCurso.Text = strCursoSelecionado;
                btBuscarCurso.PerformClick();

            }
        }
    }
}
