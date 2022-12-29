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
    public partial class FrmProfessorCadAltExc : Form
    {
        //Tipo de formulário -> Cadastro ou Alteração e Exclusão
        string formularioSelecionado;
        Professor professorSelecionado = new Professor();
        NegProfessor nProfessor = new NegProfessor();

        public FrmProfessorCadAltExc(string FormularioSelecionado, Professor professor)
        {
            InitializeComponent();

            //Atribuindo a chamada -> Cadastro ou Alteração e Exclusão
            formularioSelecionado = FormularioSelecionado;
            professorSelecionado = professor;
        }


        //Validação preenchimento
        private Boolean metodoValidaPreenchimento()
        {

            if (tbNome.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha o nome do Professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Focus();
                return false;
            }
            if (tbSobrenome.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha o sobrenome do Professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSobrenome.Focus();
                return false;
            }
            if (mtbCpf.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha o cpf do Professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCpf.Focus();
                return false;
            }
            if (mtbCelular.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha o celular do Professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCelular.Focus();
                return false;
            }
            if (tbEndereco.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha o Endereço do Professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEndereco.Focus();
                return false;
            }


            return true;
        }

        private void metodoLimpaCampos()
        {

            tbNome.Clear();
            tbSobrenome.Clear();
            mtbCpf.Clear();
            mtbCelular.Clear();
            tbEndereco.Clear();
            dtpDataNascimento.Value = DateTime.Today;

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


                tbId.Text = professorSelecionado.idProfessor.ToString();
                tbNome.Text = professorSelecionado.nomeProfessor;
                tbSobrenome.Text = professorSelecionado.sobrenomeProfessor;
                mtbCpf.Text = professorSelecionado.cpfProfessor;
                mtbCelular.Text = professorSelecionado.celularProfessor;
                tbEndereco.Text = professorSelecionado.enderecoProfessor;
                dtpDataNascimento.Value = professorSelecionado.dataNascimentoProfessor;


            }
        }

        //---------------------------------Controles
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (metodoValidaPreenchimento() == true)
            {

                Professor objProfessor = new Professor();

                objProfessor.nomeProfessor = tbNome.Text;
                objProfessor.sobrenomeProfessor = tbSobrenome.Text;
                objProfessor.cpfProfessor = mtbCpf.Text;
                objProfessor.celularProfessor = mtbCelular.Text;
                objProfessor.enderecoProfessor = tbEndereco.Text;
                objProfessor.dataNascimentoProfessor = dtpDataNascimento.Value;

                DialogResult resultado;
                if (nProfessor.cadastraProfessor(objProfessor) == true)
                {

                    resultado = MessageBox.Show(" Professor cadastrado com sucesso" + "\n Deseja sair do cadastro?",
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
                
                Professor objProfessor = new Professor();

                objProfessor.idProfessor = Convert.ToInt32(tbId.Text);
                objProfessor.nomeProfessor = tbNome.Text;
                objProfessor.sobrenomeProfessor = tbSobrenome.Text;
                objProfessor.cpfProfessor = mtbCpf.Text;
                objProfessor.celularProfessor = mtbCelular.Text;
                objProfessor.enderecoProfessor = tbEndereco.Text;
                objProfessor.dataNascimentoProfessor = dtpDataNascimento.Value;

                DialogResult resultado;
                if (nProfessor.AlterarProfessor(objProfessor) == true)
                {

                    resultado = MessageBox.Show(" Professor alterado com sucesso" + "\n Alterações concluidas?",
                               "Alteração Realizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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

                if (nProfessor.ExcluirProfessor(professorSelecionado) == true)
                {

                    MessageBox.Show(" Professor excluido com sucesso!",
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

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Deseja realmente sair?",
                    "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmProfessorCadAltExc_Load(object sender, EventArgs e)
        {
            metodoContrutor();
        }

        private void FrmProfessorCadAltExc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btExcluir.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F12) == true)
            {
                btAlterar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
        }




    }
}
