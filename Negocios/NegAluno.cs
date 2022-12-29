using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegAluno
    {
        //Instancia objeto conexao sql
        ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Cadastrar Aluno
        public Boolean cadastraAluno(Aluno aluno) {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeAluno", aluno.nomeAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sobrenomeAluno", aluno.sobrenomeAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cpfAluno", aluno.cpfAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@celularAluno", aluno.celularAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@enderecoAluno", aluno.enderecoAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataNascimentoAluno", aluno.dataNascimentoAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@statusAluno", aluno.statusAluno));

                string comando = "exec uspCadastrarAluno @nomeAluno, @sobrenomeAluno, @cpfAluno, @celularAluno, @enderecoAluno,"+
                    "@dataNascimentoAluno, @statusAluno";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao cadastrar aluno
                }
                else
                    return true;

            }

            catch (Exception ex) { throw new Exception("Erro na camada de negócios. Cadastro de Aluno " + ex.Message);
            
            }
        
        }

        //Alterar Aluno
        public Boolean AlterarAluno(Aluno aluno)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@idAluno", aluno.idAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeAluno", aluno.nomeAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sobrenomeAluno", aluno.sobrenomeAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cpfAluno", aluno.cpfAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@celularAluno", aluno.celularAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@enderecoAluno", aluno.enderecoAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataNascimentoAluno", aluno.dataNascimentoAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@statusAluno", aluno.statusAluno));

                string comando = "exec uspAlterarAluno @idAluno, @nomeAluno, @sobrenomeAluno, @cpfAluno, @celularAluno, @enderecoAluno," +
                    "@dataNascimentoAluno, @statusAluno";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao alterar aluno
                }
                else
                    return true;

            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Alteração de Aluno " + ex.Message);

            }

        }

        //Excluir Aluno
        public Boolean ExcluirAluno(Aluno aluno)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@idAluno", aluno.idAluno));

                string comando = "exec uspExcluirAluno @idAluno";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao excluir aluno
                }
                else
                    return true;

            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Exclusão de Aluno " + ex.Message);

            }

        }

        //Buscar aluno por código
        public Aluno BuscarAlunoPorCodigo(int codigo)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoAluno", codigo));
            string comandoSql = "exec uspBuscarAlunoPorCodigo @codigoAluno";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);


            if (tabelaRetorno.Rows.Count > 0)
            {
                Aluno aluno = new Aluno();
                DataRow registro = tabelaRetorno.Rows[0];


                aluno.idAluno = Convert.ToInt32(registro[0]);
                aluno.nomeAluno = registro[1].ToString();
                aluno.sobrenomeAluno = registro[2].ToString();
                aluno.cpfAluno = registro[3].ToString();
                aluno.celularAluno = registro[4].ToString();
                aluno.enderecoAluno = registro[5].ToString();
                aluno.dataNascimentoAluno = Convert.ToDateTime(registro[6]);
                aluno.statusAluno = registro[7].ToString();


                return aluno;
            }
            else
                return null;

        }

        //Buscar aluno por nome
        public ListaAlunos BuscarAlunosPorNome(String nomeAluno)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeAluno", nomeAluno));


                ListaAlunos listaAlunos = new ListaAlunos();
                Aluno aluno = new Aluno();

                DataTable tabelaResultado;

                string comando = "exec uspBuscarAlunoPorNome @nomeAluno";
                tabelaResultado = sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    aluno = new Aluno();

                    aluno.idAluno = Convert.ToInt32(registro[0]);
                    aluno.nomeAluno = registro[1].ToString();
                    aluno.sobrenomeAluno = registro[2].ToString();
                    aluno.cpfAluno = registro[3].ToString();
                    aluno.celularAluno = registro[4].ToString();
                    aluno.enderecoAluno = registro[5].ToString();
                    aluno.dataNascimentoAluno = Convert.ToDateTime(registro[6]);
                    aluno.statusAluno = registro[7].ToString();

                    listaAlunos.Add(aluno);
                }
                return listaAlunos;

            }
            catch (Exception ex) { throw new Exception("Erro na camada de negócios Buscar Alunos Por Nome " + ex.Message); }
        }

        //Buscar aluno por nome
        public ListaAlunos BuscarAlunosCursoPorNome(String nomeAluno)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeAluno", nomeAluno));


                ListaAlunos listaAlunos = new ListaAlunos();
                Aluno aluno = new Aluno();

                DataTable tabelaResultado;

                string comando = "exec uspBuscarAlunoPorNome @nomeAluno";
                tabelaResultado = sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    aluno = new Aluno();

                    aluno.idAluno = Convert.ToInt32(registro[0]);
                    aluno.nomeAluno = registro[1].ToString() +" "+ registro[2].ToString();
                    aluno.cpfAluno = registro[3].ToString();
                    aluno.statusAluno = registro[7].ToString();
                    //Convertendo Data de Nascimento para Idade 
                    aluno.idadeAluno =
                        (DateTime.Today.Year - Convert.ToDateTime(registro[6]).Year).ToString();

                    listaAlunos.Add(aluno);
                }
                return listaAlunos;

            }
            catch (Exception ex) { throw new Exception("Erro na camada de negócios Buscar Alunos Por Nome " + ex.Message); }
        }


    }
}
