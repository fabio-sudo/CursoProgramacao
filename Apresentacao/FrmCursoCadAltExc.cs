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
    public partial class FrmCursoCadAltExc : Form
    {

        //Tipo de formulário -> Cadastro ou Alteração e Exclusão
        string formularioSelecionado;
        Curso cursoSelecionado = new Curso();
        NegCurso nCurso = new NegCurso();

        public FrmCursoCadAltExc(string FormularioSelecionado, Curso curso)
        {
            InitializeComponent();

            //Atribuindo a chamada -> Cadastro ou Alteração e Exclusão
            formularioSelecionado = FormularioSelecionado;
            cursoSelecionado = curso;
        }


        //Validação preenchimento
        private Boolean metodoValidaPreenchimento()
        {

            if (tbNome.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha o nome do Curso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Focus();
                return false;
            }
            if (tbEmenta.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha a ementa do Curso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmenta.Focus();
                return false;
            }
            if (tbDuracao.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha a duração do Curso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDuracao.Focus();
                return false;
            }
           

            return true;
        }

        private void metodoLimpaCampos()
        {

            tbNome.Clear();
            tbEmenta.Clear();
            tbDuracao.Clear();


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


                tbId.Text = cursoSelecionado.idCurso.ToString();
                tbNome.Text = cursoSelecionado.nomeCurso;
                tbEmenta.Text = cursoSelecionado.ementaCurso;
                tbDuracao.Text = cursoSelecionado.duracaoCurso;
    
            }
        }

        //-----------------Controles
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (metodoValidaPreenchimento() == true)
            {

                Curso objCurso = new Curso();

                objCurso.nomeCurso = tbNome.Text;
                objCurso.ementaCurso = tbEmenta.Text;
                objCurso.duracaoCurso = tbDuracao.Text;


                DialogResult resultado;
                if (nCurso.cadastraCurso(objCurso) == true)
                {

                    resultado = MessageBox.Show(" Curso cadastrado com sucesso" + "\n Deseja sair do cadastro?",
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

                Curso objCurso = new Curso();

                objCurso.idCurso = Convert.ToInt32(tbId.Text);
                objCurso.nomeCurso = tbNome.Text;
                objCurso.ementaCurso = tbEmenta.Text;
                objCurso.duracaoCurso = tbDuracao.Text;


                DialogResult resultado;
                if (nCurso.AlterarCurso(objCurso) == true)
                {

                    resultado = MessageBox.Show(" Curso alterado com sucesso" + "\n Alterações concluidas?",
                               "Cadastro Realizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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

                if (nCurso.ExcluirCurso(cursoSelecionado) == true)
                {

                    MessageBox.Show(" Curso excluido com sucesso!",
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

        private void FrmCursoCadAltExc_Load(object sender, EventArgs e)
        {
            metodoContrutor();
        }

        private void FrmCursoCadAltExc_KeyDown(object sender, KeyEventArgs e)
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
