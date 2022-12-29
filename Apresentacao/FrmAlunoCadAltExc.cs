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
    public partial class FrmAlunoCadAltExc : Form
    {
        //Tipo de formulário -> Cadastro ou Alteração e Exclusão
        string formularioSelecionado;
        Aluno alunoSelecionado = new Aluno();
        NegAluno nAluno = new NegAluno();


        public FrmAlunoCadAltExc(string FormularioSelecionado, Aluno aluno)
        {
            InitializeComponent();

            //Atribuindo a chamada -> Cadastro ou Alteração e Exclusão
            formularioSelecionado = FormularioSelecionado;
            alunoSelecionado = aluno;
        }

        //Validação preenchimento
        private Boolean metodoValidaPreenchimento() {

            if (tbNome.Text.Equals(String.Empty)) {

                MessageBox.Show("Preencha o nome do Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Focus();
                return false;
            }
            if (tbSobrenome.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha o sobrenome do Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSobrenome.Focus();
                return false;
            }
            if (mtbCpf.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha o cpf do Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCpf.Focus();
                return false;
            }
            if (mtbCelular.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha o celular do Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCelular.Focus();
                return false;
            }
            if (tbEndereco.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha o Endereço do Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEndereco.Focus();
                return false;
            }
            if (cbStatus.Text.Equals(String.Empty))
            {

                MessageBox.Show("Preencha o status do Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbStatus.Focus();
                return false;
            }

            return true;      
        }

        private void metodoLimpaCampos() {

            tbNome.Clear();
            tbSobrenome.Clear();
            mtbCpf.Clear();
            mtbCelular.Clear();
            tbEndereco.Clear();
            cbStatus.SelectedItem = null;
            dtpDataNascimento.Value = DateTime.Today;
             
        }

        //construtor do formulário
        private void metodoContrutor() {

            if (formularioSelecionado.Equals("Cadastro"))
            {
                lbIdAluno.Visible = false;
                tbId.Visible = false;
                btAlterar.Visible = false;
                btExcluir.Visible = false;

            }
            //Caso não for formulário de cadastro e um formulário de Alteração e Exclusão
            else {

                btCadastrar.Visible = false;
                lbIdAluno.Visible = true;
                tbId.Visible = true;
                btAlterar.Visible = true;
                btExcluir.Visible = true;


                tbId.Text = alunoSelecionado.idAluno.ToString();
                tbNome.Text = alunoSelecionado.nomeAluno;
                tbSobrenome.Text = alunoSelecionado.sobrenomeAluno;
                mtbCpf.Text = alunoSelecionado.cpfAluno;
                mtbCelular.Text = alunoSelecionado.celularAluno;
                tbEndereco.Text = alunoSelecionado.enderecoAluno;
                dtpDataNascimento.Value = alunoSelecionado.dataNascimentoAluno;
                cbStatus.SelectedItem = alunoSelecionado.statusAluno;

            }         
        }

        //-----------------------Controles
        private void FrmAlunoCadAltExc_Load(object sender, EventArgs e)
        {
            metodoContrutor();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (metodoValidaPreenchimento() == true)
            {

                Aluno objAluno = new Aluno();

                objAluno.idAluno = Convert.ToInt32(tbId.Text);
                objAluno.nomeAluno = tbNome.Text;
                objAluno.sobrenomeAluno = tbSobrenome.Text;
                objAluno.cpfAluno = mtbCpf.Text;
                objAluno.celularAluno = mtbCelular.Text;
                objAluno.enderecoAluno = tbEndereco.Text;
                objAluno.statusAluno = cbStatus.Text;
                objAluno.dataNascimentoAluno = dtpDataNascimento.Value;

                DialogResult resultado;
                if (nAluno.AlterarAluno(objAluno) == true)
                {

                    resultado = MessageBox.Show(" Aluno alterado com sucesso" + "\n Alterações concluidas?",
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

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (metodoValidaPreenchimento() == true) {

                Aluno objAluno = new Aluno();
                objAluno.nomeAluno = tbNome.Text;
                objAluno.sobrenomeAluno = tbSobrenome.Text;
                objAluno.cpfAluno = mtbCpf.Text;
                objAluno.celularAluno = mtbCelular.Text;
                objAluno.enderecoAluno = tbEndereco.Text;
                objAluno.statusAluno = cbStatus.Text;
                objAluno.dataNascimentoAluno = dtpDataNascimento.Value;

                DialogResult resultado;
                if (nAluno.cadastraAluno(objAluno) == true)
                {

                    resultado = MessageBox.Show(" Aluno cadastrado com sucesso" + "\n Deseja sair do cadastro?",
                               "Cadastro Realizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (resultado == DialogResult.Yes)
                    {
                        DialogResult = DialogResult.Yes;
                        this.Close(); 

                    }
                    else {

                        metodoLimpaCampos(); 
                    }
                }
                else { MessageBox.Show("Erro ao realizar Cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }     
            
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                if (nAluno.ExcluirAluno(alunoSelecionado) == true)
                {

                    MessageBox.Show(" Aluno excluido com sucesso!",
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

        //Teclas de Atalho
        private void FrmAlunoCadAltExc_KeyDown(object sender, KeyEventArgs e)
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

        //Sair
        private void btSair_Click(object sender, EventArgs e)
        {
           DialogResult resultado = MessageBox.Show(" Deseja realmente sair?",
                              "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }

        }
        


    }
}
