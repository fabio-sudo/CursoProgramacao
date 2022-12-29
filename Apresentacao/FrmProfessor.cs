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
    public partial class FrmProfessor : Form
    {
        ListaProfessores listaProfessores = new ListaProfessores();
        Professor objProfessor = new Professor();
        NegProfessor nProfessor = new NegProfessor();

        public  Professor ProfessorSelecionado = new Professor();
        string strProfessorSelecionado;

        public FrmProfessor([Optional]string professorSelecionado)
        {
            InitializeComponent();
            strProfessorSelecionado = professorSelecionado;

        }

        //Preenche valore do Data Gride
        private void metodoAtualizaDataGrid()
        {

            //Limpando Data Grid
            dgvProfessor.Rows.Clear();

            if (listaProfessores.Count > 0)
            {
                //Adicionando Linhas no gride "ROW"
                dgvProfessor.Rows.Add(listaProfessores.Count);
            }
            else { return; }

            //Indice demarca a linha "ROW" que o valor será atribuido
            int indice = 0;
            //Enquanto houver Professors na lista os valores serão atribuidos no gride
            foreach (Professor Professor in this.listaProfessores)
            {
                this.dgvProfessor[0, indice].Value = Professor.idProfessor;
                this.dgvProfessor[1, indice].Value = Professor.nomeProfessor;
                this.dgvProfessor[2, indice].Value = Professor.sobrenomeProfessor;
                this.dgvProfessor[3, indice].Value = Professor.cpfProfessor;
                this.dgvProfessor[4, indice].Value = Professor.celularProfessor;
                this.dgvProfessor[5, indice].Value = Professor.enderecoProfessor;
                this.dgvProfessor[6, indice].Value = (DateTime.Today.Year - Professor.dataNascimentoProfessor.Year).ToString();
                

                indice++;
            }

            dgvProfessor.Update();
        }

        //Método preenche lista de Professors e realiza a busca
        private void metodoBuscarProfessor()
        {

            //Instanciando listaProfessors
            listaProfessores = new ListaProfessores();

            //Verifica se o valor digitado na Caixa de Texto e numero ou texto
            int n;
            bool ehUmNumero = int.TryParse(tbProfessor.Text, out n);

            //Se for numero busca somente o Professor Por ID
            if (ehUmNumero == true)
            {
                objProfessor = nProfessor.BuscarProfessorPorCodigo(n);
                listaProfessores.Add(objProfessor);
                tbProfessor.Text = objProfessor.nomeProfessor;
                metodoAtualizaDataGrid();
            }
            //Se for texto busca o Professor por Nome
            else
            {
                listaProfessores = nProfessor.BuscarProfessorsPorNome(tbProfessor.Text);
                metodoAtualizaDataGrid();

            }
        }
        //----------------------Controles
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmProfessorCadAltExc frmCadastrar = new FrmProfessorCadAltExc("Cadastro", null);
            frmCadastrar.ShowDialog();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            ProfessorSelecionado = new Professor();

            //Verifica se tem items no grid
            if (this.dgvProfessor.Rows.Count > 0)
            {
                //Retorna o ID do Professor da célula que está selecionda
                int indiceRegistroSelecionado = Convert.ToInt32(dgvProfessor.CurrentRow.Cells[0].Value);
                foreach (Professor Professor in listaProfessores)
                {
                    if (Professor.idProfessor == indiceRegistroSelecionado)
                    {
                        ProfessorSelecionado = Professor;
                        break;

                    }
                }

                if (strProfessorSelecionado != null)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {

                    DialogResult resultado;

                    FrmProfessorCadAltExc frmAlterar = new FrmProfessorCadAltExc("Alterar", ProfessorSelecionado);
                    resultado = frmAlterar.ShowDialog();

                    //Caso a alteração ou exclusão do item o formulário realiza a atulização dos dados do grid
                    if (resultado == DialogResult.Yes) { btBuscarProfessor.PerformClick(); }
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

        private void btBuscarProfessor_Click(object sender, EventArgs e)
        {
            metodoBuscarProfessor();
        }

        private void FrmProfessor_KeyDown(object sender, KeyEventArgs e)
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
                btBuscarProfessor.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
        }

        private void dgvProfessor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmProfessor_Load(object sender, EventArgs e)
        {
            if (strProfessorSelecionado != null) {

                tbProfessor.Text = strProfessorSelecionado;
                btBuscarProfessor.PerformClick();
            
            }
        }


    }
}
