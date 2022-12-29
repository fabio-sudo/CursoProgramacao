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
    public partial class FrmAluno : Form
    {

        ListaAlunos listaAlunos = new ListaAlunos();
        Aluno objAluno = new Aluno();
        NegAluno nAluno = new NegAluno();
        
        //Para poder ser acessado 
        public Aluno alunoSelecionado = new Aluno();

        string strAlunoSelecionado;


        public FrmAluno([Optional] string selecionaAluno)
        {
            InitializeComponent();

            strAlunoSelecionado = selecionaAluno;
        }

        //Preenche valore do Data Gride
        private void metodoAtualizaDataGrid() {
            
            //Limpando Data Grid
            dgvAluno.Rows.Clear();

            if (listaAlunos.Count > 0)
            {
                //Adicionando Linhas no gride "ROW"
                dgvAluno.Rows.Add(listaAlunos.Count);
            }
            else { return; }

            //Indice demarca a linha "ROW" que o valor será atribuido
            int indice = 0;
            //Enquanto houver alunos na lista os valores serão atribuidos no gride
            foreach (Aluno aluno in this.listaAlunos)
            {
                this.dgvAluno[0, indice].Value = aluno.idAluno;
                this.dgvAluno[1, indice].Value = aluno.nomeAluno;
                this.dgvAluno[2, indice].Value = aluno.sobrenomeAluno;
                this.dgvAluno[3, indice].Value = aluno.cpfAluno;
                this.dgvAluno[4, indice].Value = aluno.celularAluno;
                this.dgvAluno[5, indice].Value = aluno.enderecoAluno;

                //Convertendo Data de Nascimento para Idade 
                aluno.idadeAluno = 
                    (DateTime.Today.Year - aluno.dataNascimentoAluno.Year).ToString();

                this.dgvAluno[6, indice].Value = aluno.idadeAluno;
                this.dgvAluno[7, indice].Value = aluno.statusAluno;

                indice++;
            }

            dgvAluno.Update();                 
        }

        //Método preenche lista de alunos e realiza a busca
        private void metodoBuscarAluno() {

            //Instanciando listaAlunos
            listaAlunos = new ListaAlunos();

            //Verifica se o valor digitado na Caixa de Texto e numero ou texto
            int n;
            bool ehUmNumero = int.TryParse(tbAluno.Text, out n);

            //Se for numero busca somente o Aluno Por ID
            if (ehUmNumero == true)
            {
                objAluno = nAluno.BuscarAlunoPorCodigo(n);
                listaAlunos.Add(objAluno);
                tbAluno.Text = objAluno.nomeAluno;
                metodoAtualizaDataGrid();
            }
            //Se for texto busca o aluno por Nome
            else
            {
                listaAlunos = nAluno.BuscarAlunosPorNome(tbAluno.Text);
                metodoAtualizaDataGrid();

            }
            }

        //--------------------Controles
        private void btBuscarAluno_Click(object sender, EventArgs e)
        {
            metodoBuscarAluno();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmAlunoCadAltExc frmCadastrar = new FrmAlunoCadAltExc("Cadastro", null);
            frmCadastrar.ShowDialog();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            alunoSelecionado = new Aluno();

            //Verifica se tem items no grid
            if (this.dgvAluno.Rows.Count > 0)
            {
                //Retorna o ID do aluno da célula que está selecionda
                int indiceRegistroSelecionado = Convert.ToInt32(dgvAluno.CurrentRow.Cells[0].Value);
                foreach (Aluno aluno in listaAlunos)
                {
                    if (aluno.idAluno == indiceRegistroSelecionado)
                    {
                        alunoSelecionado = aluno;
                        break;

                    }
                }

                if (strAlunoSelecionado != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                else
                {
                    DialogResult resultado;

                    FrmAlunoCadAltExc frmCadastrar = new FrmAlunoCadAltExc("Alterar", alunoSelecionado);
                    resultado = frmCadastrar.ShowDialog();

                    //Caso a alteração ou exclusão do item o formulário realiza a atulização dos dados do grid
                    if (resultado == DialogResult.Yes) { btBuscarAluno.PerformClick(); }
                }
            }
        }

        //Duplo click chama o método selecionar
        private void dgvAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmAluno_KeyDown(object sender, KeyEventArgs e)
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
                btBuscarAluno.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
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

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            if (strAlunoSelecionado != null)
            {

                tbAluno.Text = strAlunoSelecionado;
                btBuscarAluno.PerformClick();           
            }
        }


        
    }
}
