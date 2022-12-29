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
    public partial class FrmPeriodoCadAltExc : Form
    {
        //Tipo de formulário -> Cadastro ou Alteração e Exclusão
        string formularioSelecionado;
        Periodo periodoSelecionado = new Periodo();
        NegPeriodo nPeriodo = new NegPeriodo();

        public FrmPeriodoCadAltExc(string FormularioSelecionado, Periodo periodo)
        {
            InitializeComponent();

            //Atribuindo a chamada -> Cadastro ou Alteração e Exclusão
            formularioSelecionado = FormularioSelecionado;
            periodoSelecionado = periodo;
        }

        //Validação preenchimento
        private Boolean metodoValidaPreenchimento()
        {

            if (tbNome.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha o nome do Período", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Focus();
                return false;
            }
           
            if(dtpHorarioInicial.Value >= dtpHorarioFinal.Value)
            {

                MessageBox.Show("Preencha os horários do Período corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Focus();
                return false;
            }
          
            return true;
        }

        private void metodoLimpaCampos()
        {

            tbNome.Clear();
            dtpHorarioInicial.Value = DateTime.Today;
            dtpHorarioFinal.Value = DateTime.Today;
        }

        //construtor do formulário
        private void metodoContrutor()
        {

            if (formularioSelecionado.Equals("Cadastro"))
            {
                lbId.Visible = false;
                tbId.Visible = false;
                btAlterar.Visible = false;
                btExcluir.Visible = false;

            }
            //Caso não for formulário de cadastro e um formulário de Alteração e Exclusão
            else
            {

                btCadastrar.Visible = false;
                lbId.Visible = true;
                tbId.Visible = true;
                btAlterar.Visible = true;
                btExcluir.Visible = true;


                tbId.Text = periodoSelecionado.idPeriodo.ToString();
                tbNome.Text = periodoSelecionado.nomePeriodo;




                dtpHorarioInicial.Value = periodoSelecionado.horarioInicialPeriodo;
                dtpHorarioFinal.Value = periodoSelecionado.horarioFinalPeriodo; 
            }
        }

        //-----------------------Controles
        private void FrmPeriodoCadAltExc_Load(object sender, EventArgs e)
        {
            metodoContrutor();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (metodoValidaPreenchimento() == true)
            {

                Periodo objPeriodo = new Periodo();
                objPeriodo.nomePeriodo = tbNome.Text;
                objPeriodo.horarioInicialPeriodo = dtpHorarioInicial.Value;
                objPeriodo.horarioFinalPeriodo = dtpHorarioFinal.Value;


                DialogResult resultado;
                if (nPeriodo.cadastraPeriodo(objPeriodo) == true)
                {

                    resultado = MessageBox.Show(" Período cadastrado com sucesso" + "\n Deseja sair do cadastro?",
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
            if (metodoValidaPreenchimento() == true)
            {
                Periodo objPeriodo = new Periodo();

                objPeriodo.idPeriodo = Convert.ToInt32(tbId.Text);
                objPeriodo.nomePeriodo = tbNome.Text;
                objPeriodo.horarioInicialPeriodo = dtpHorarioInicial.Value;
                objPeriodo.horarioFinalPeriodo = dtpHorarioFinal.Value;


                DialogResult resultado;
                if (nPeriodo.AlterarPeriodo(objPeriodo) == true)
                {

                    resultado = MessageBox.Show(" Período alterado com sucesso" + "\n Alterações concluidas?",
                               "Alteração Realizada", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (resultado == DialogResult.Yes)
                    {
                        DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                }
                else { MessageBox.Show("Erro ao realizar Alteração", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                if (nPeriodo.ExcluirPeriodo(periodoSelecionado) == true)
                {

                    MessageBox.Show(" Período excluido com sucesso!",
                                  "Exclusão Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.Yes;
                    this.Close();
                }

                else { MessageBox.Show("Erro ao realizar exclusão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
