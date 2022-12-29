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
    public class NegAlunoCurso
    {
        
        //uspStatusAluno_Curso


        //Instancia objeto conexao sql
        ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Cadastrar Aluno_Curso
        public Boolean cadastraAlunoCurso(AlunoCurso alunoCurso, ListaAlunos lista)
        {

            try
            {
                foreach (Aluno aluno in lista)
                {
                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Matricula", alunoCurso.idAlunoCurso));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Aluno", aluno.idAluno));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Curso", alunoCurso.Curso.idCurso));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Professor", alunoCurso.Professor.idProfessor));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Periodo", alunoCurso.Periodo.idPeriodo));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@diaSemanaCurso", alunoCurso.diaSemanaCurso));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@statusAlunoCurso", alunoCurso.statusCurso));

                    string comando = "exec uspCadastrarAluno_Curso @Matricula, @Aluno, @Curso, @Professor, @Periodo, @diaSemanaCurso," +
                        "@statusAlunoCurso";

                    object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                    if (Convert.ToInt16(Resposta) == 2)
                    {
                        return false;//Erro ao cadastrar aluno
                    }
                }

                return true;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Cadastro de Aluno Curso " + ex.Message);

            }

        }

        //Alterar Aluno_Curso
        public Boolean AlterarAlunoCurso(AlunoCurso alunoCurso, List<int> lista)
        {

            try
            {
                foreach (int idAluno in lista)
                {
                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Matricula", alunoCurso.idAlunoCurso));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Aluno", idAluno));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Curso", alunoCurso.Curso.idCurso));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Professor", alunoCurso.Professor.idProfessor));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Periodo", alunoCurso.Periodo.idPeriodo));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@diaSemanaCurso", alunoCurso.diaSemanaCurso));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@statusAlunoCurso", alunoCurso.statusCurso));

                    string comando = "exec uspAlterarAluno_Curso @Matricula, @Aluno, @Curso, @Professor, @Periodo, @diaSemanaCurso," +
                        "@statusAlunoCurso";

                    object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                    if (Convert.ToInt16(Resposta) == 2)
                    {
                        return false;//Erro ao alterar aluno
                    }

                }

                return true;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Alteração de Aluno Curso" + ex.Message);

            }

        }

        //Excluir Aluno_Curso
        public Boolean ExcluirAlunoCurso(AlunoCurso alunoCurso)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@idAlunoCurso", alunoCurso.idAlunoCurso));

                string comando = "exec uspExcluirAluno_Curso @idAlunoCurso";

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

        //Altera Status
        public Boolean StatusAlunoCurso(AlunoCurso alunoCurso, ListaAlunos lista, string Status)
        {

            try
            {
                foreach (Aluno aluno in lista)
                {
                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Matricula", alunoCurso.idAlunoCurso));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Aluno", aluno.idAluno));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Status", Status));

                    string comando = "exec uspStatusAluno_Curso  @Aluno, @Matricula, @Status";

                    object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                    if (Convert.ToInt16(Resposta) == 2)
                    {
                        return false;//Erro ao cadastrar aluno
                    }
                }

                return true;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Cadastro de Aluno Curso " + ex.Message);

            }

        }

        //Busca Ultima matriucla realizada
        public int BuscarMatricula()
        {
            try
            {
                string comando = " exec uspBuscarMatricula";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                return Convert.ToInt16(Resposta);

            }
            catch (Exception ex)
            {
                //caso não houver nenhum registro retorna 1 para o primeiro cadastro
                return 1;
                throw new Exception("Erro na camada de negócios - Retorno. " + ex.Message);

            }
        }

        //Buscar Aluno_Curso todos
        public ListaAlunoCurso BuscarAlunosCursoPorMatricula(int matricula)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@matricula", matricula));

                ListaAlunoCurso listaAlunoCursos = new ListaAlunoCurso();
                AlunoCurso alunoCurso = new AlunoCurso();

                DataTable tabelaResultado;

                string comando = "exec uspBuscarAlunoCursoPorMatricula @matricula";
                tabelaResultado = sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    alunoCurso = new AlunoCurso();
                    alunoCurso.Aluno = new Aluno();
                    alunoCurso.Curso = new Curso();
                    alunoCurso.Professor = new Professor();
                    alunoCurso.Periodo = new Periodo();

                    alunoCurso.idAlunoCurso = Convert.ToInt32(registro[0]);
                    alunoCurso.diaSemanaCurso = (registro[1]).ToString();
                    //Curso
                    alunoCurso.Curso.idCurso = Convert.ToInt32(registro[2]);
                    alunoCurso.Curso.nomeCurso = registro[3].ToString();
                    //Aluno
                    alunoCurso.Aluno.idAluno = Convert.ToInt32(registro[4]);
                    alunoCurso.Aluno.nomeAluno = registro[5].ToString() + " " + registro[6].ToString();//Nome Completo
                    alunoCurso.Aluno.cpfAluno = registro[7].ToString();
                    alunoCurso.Aluno.celularAluno = registro[8].ToString();
                    alunoCurso.Aluno.idadeAluno =
                   (DateTime.Today.Year - Convert.ToDateTime(registro[9]).Year).ToString();
                    //Professor
                    alunoCurso.Professor.idProfessor = Convert.ToInt32(registro[10]);
                    alunoCurso.Professor.nomeProfessor = registro[11].ToString();
                    //Período
                    alunoCurso.Periodo.idPeriodo = Convert.ToInt32(registro[12]);
                    alunoCurso.Periodo.nomePeriodo = registro[13].ToString();
                    alunoCurso.statusCurso = registro[14].ToString();

                    listaAlunoCursos.Add(alunoCurso);
                }

                return listaAlunoCursos;
            }
            catch (Exception ex) { throw new Exception("Erro na camada de negócios Buscar Alunos Curso Por Matricula " + ex.Message); }
        }

        //Buscar Aluno_Curso todos
        public ListaAlunoCurso BuscarAlunosCursoTodos()
        {
            try
            {
                sqlServer.LimparParametros();

                ListaAlunoCurso listaAlunoCursos = new ListaAlunoCurso();
                AlunoCurso alunoCurso = new AlunoCurso();

                DataTable tabelaResultado;

                string comando = "exec uspBuscarAlunoCursoTodos";
                tabelaResultado = sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    alunoCurso = new AlunoCurso();
                    alunoCurso.Aluno = new Aluno();
                    alunoCurso.Curso = new Curso();
                    alunoCurso.Professor = new Professor();
                    alunoCurso.Periodo = new Periodo();

                    alunoCurso.idAlunoCurso = Convert.ToInt32(registro[0]);
                    //Curso
                    alunoCurso.Curso.nomeCurso = registro[1].ToString();
                    alunoCurso.Curso.duracaoCurso = registro[2].ToString();
                    //Aluno
                    alunoCurso.Aluno.nomeAluno = registro[3].ToString();
                    alunoCurso.Aluno.sobrenomeAluno = registro[4].ToString();
                    alunoCurso.Aluno.celularAluno = registro[5].ToString();
                    alunoCurso.Aluno.idadeAluno = registro[6].ToString();
                    //Professor
                    alunoCurso.Professor.nomeProfessor = registro[7].ToString();
                    alunoCurso.Professor.sobrenomeProfessor = registro[8].ToString();
                    //Aluno_Curso
                    alunoCurso.diaSemanaCurso = registro[9].ToString();
                    //Período
                    alunoCurso.Periodo.nomePeriodo = registro[10].ToString();
                    alunoCurso.Periodo.horarioInicialPeriodo = Convert.ToDateTime(registro[11]);
                    alunoCurso.Periodo.horarioFinalPeriodo = Convert.ToDateTime(registro[12]);
                    alunoCurso.statusCurso = (registro[13].ToString());

                    listaAlunoCursos.Add(alunoCurso);
                }

                return listaAlunoCursos;
            }
            catch (Exception ex) { throw new Exception("Erro na camada de negócios Buscar Alunos Curso Todos " + ex.Message); }
        }

        //Buscar Aluno_Curso todos
        public ListaAlunoCurso BuscarAlunosCursoPorFiltros(string nomeAluno,string nomeCurso,string nomeProfessor, string nomePeriodo)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeAluno",nomeAluno));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeCurso", nomeCurso));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeProfessor", nomeProfessor));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomePeriodo", nomePeriodo));

                ListaAlunoCurso listaAlunoCursos = new ListaAlunoCurso();
                AlunoCurso alunoCurso = new AlunoCurso();

                DataTable tabelaResultado;

                string comando = "exec uspBuscarAlunoCursoPorFiltros @nomeAluno, @nomeCurso, @nomeProfessor, @nomePeriodo";
                tabelaResultado = sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    alunoCurso = new AlunoCurso();
                    alunoCurso.Aluno = new Aluno();
                    alunoCurso.Curso = new Curso();
                    alunoCurso.Professor = new Professor();
                    alunoCurso.Periodo = new Periodo();

                    alunoCurso.idAlunoCurso = Convert.ToInt32(registro[0]);
                    //Curso
                    alunoCurso.Curso.nomeCurso = registro[1].ToString();
                    alunoCurso.Curso.duracaoCurso = registro[2].ToString();
                    //Aluno
                    alunoCurso.Aluno.nomeAluno = registro[3].ToString();
                    alunoCurso.Aluno.sobrenomeAluno = registro[4].ToString();
                    alunoCurso.Aluno.celularAluno = registro[5].ToString();
                    alunoCurso.Aluno.idadeAluno = registro[6].ToString();
                    //Professor
                    alunoCurso.Professor.nomeProfessor = registro[7].ToString();
                    alunoCurso.Professor.sobrenomeProfessor = registro[8].ToString();
                    //Aluno_Curso
                    alunoCurso.diaSemanaCurso = registro[9].ToString();
                    //Período
                    alunoCurso.Periodo.nomePeriodo = registro[10].ToString();
                    alunoCurso.Periodo.horarioInicialPeriodo = Convert.ToDateTime(registro[11]);
                    alunoCurso.Periodo.horarioFinalPeriodo = Convert.ToDateTime(registro[12]);
                    alunoCurso.statusCurso = (registro[13].ToString());

                    listaAlunoCursos.Add(alunoCurso);
                }

                return listaAlunoCursos;
            }
            catch (Exception ex) { throw new Exception("Erro na camada de negócios Buscar Alunos Curso Por Filtros " + ex.Message); }
        }
    }
}
