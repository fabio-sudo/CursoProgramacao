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
    public partial class FrmPeriodo : Form
    {
        ListaPeriodos listaPeriodos = new ListaPeriodos();
        Periodo objPeriodo = new Periodo();
        NegPeriodo nPeriodo = new NegPeriodo();

        public Periodo periodoSelecionado = new Periodo();
        string strPeriodoSelecionado;

        public FrmPeriodo([Optional] string periodoSelecionado)
        {
            InitializeComponent();

            strPeriodoSelecionado = periodoSelecionado;
        }

        //Preenche valore do Data Gride
        private void metodoAtualizaDataGrid()
        {

            //Limpando Data Grid
            dgvPeriodo.Rows.Clear();

            if (listaPeriodos.Count > 0)
            {
                //Adicionando Linhas no gride "ROW"
                dgvPeriodo.Rows.Add(listaPeriodos.Count);
            }
            else { return; }

            //Indice demarca a linha "ROW" que o valor será atribuido
            int indice = 0;
            //Enquanto houver alunos na lista os valores serão atribuidos no gride
            foreach (Periodo Periodo in this.listaPeriodos)
            {
                this.dgvPeriodo[0, indice].Value = Periodo.idPeriodo;
                this.dgvPeriodo[1, indice].Value = Periodo.nomePeriodo;
                this.dgvPeriodo[2, indice].Value = Periodo.horarioInicialPeriodo;
                this.dgvPeriodo[3, indice].Value = Periodo.horarioFinalPeriodo;

                indice++;
            }

            dgvPeriodo.Update();
        }

        //Método preenche lista de alunos e realiza a busca
        private void metodoBuscarPeriodo()
        {

            //Instanciando listaAlunos
            listaPeriodos = new ListaPeriodos();

            //Verifica se o valor digitado na Caixa de Texto e numero ou texto
            int n;
            bool ehUmNumero = int.TryParse(tbPeriodo.Text, out n);

            //Se for numero busca somente o Aluno Por ID
            if (ehUmNumero == true)
            {
                objPeriodo = nPeriodo.BuscarPeriodoPorCodigo(n);
                listaPeriodos.Add(objPeriodo);
                tbPeriodo.Text = objPeriodo.nomePeriodo;
                metodoAtualizaDataGrid();
            }
            //Se for texto busca o aluno por Nome
            else
            {
                listaPeriodos = nPeriodo.BuscarPeriodosPorNome(tbPeriodo.Text);
                metodoAtualizaDataGrid();

            }
        }

        //-------------------------Controles
        private void btBuscarPeriodo_Click(object sender, EventArgs e)
        {
            metodoBuscarPeriodo();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmPeriodoCadAltExc frmCadastrar = new FrmPeriodoCadAltExc("Cadastro", null);
            frmCadastrar.ShowDialog();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
           periodoSelecionado = new Periodo();

            //Verifica se tem items no grid
            if (this.dgvPeriodo.Rows.Count > 0)
            {
                //Retorna o ID do aluno da célula que está selecionda
                int indiceRegistroSelecionado = Convert.ToInt32(dgvPeriodo.CurrentRow.Cells[0].Value);
                foreach (Periodo periodo in listaPeriodos)
                {
                    if (periodo.idPeriodo == indiceRegistroSelecionado)
                    {
                        periodoSelecionado = periodo;
                        break;

                    }
                }

                if(strPeriodoSelecionado != null){

                    DialogResult = DialogResult.OK;
                    this.Close();                
                }
                else{
                DialogResult resultado;

                FrmPeriodoCadAltExc frmAlterar = new FrmPeriodoCadAltExc("Alterar", periodoSelecionado);
                resultado = frmAlterar.ShowDialog();

                //Caso a alteração ou exclusão do item o formulário realiza a atulização dos dados do grid
                if (resultado == DialogResult.Yes) { btBuscarPeriodo.PerformClick(); }
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

        private void dgvPeriodo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmPeriodo_KeyDown(object sender, KeyEventArgs e)
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
                btBuscarPeriodo.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
        }

        private void FrmPeriodo_Load(object sender, EventArgs e)
        {
            if (strPeriodoSelecionado != null) {

                tbPeriodo.Text = strPeriodoSelecionado;
                btBuscarPeriodo.PerformClick();
            
            }
        }



    }
}
