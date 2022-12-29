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
   public class NegCurso
    {
        //Instancia objeto conexao sql
        ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Cadastrar Curso
        public Boolean cadastraCurso(Curso Curso)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeCurso", Curso.nomeCurso));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@ementaCurso", Curso.ementaCurso));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@duracaoCurso", Curso.duracaoCurso));

                string comando = "exec uspCadastrarCurso @nomeCurso, @ementaCurso, @duracaoCurso";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao cadastrar Curso
                }
                else
                    return true;

            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Cadastro de Curso " + ex.Message);

            }

        }

        //Alterar Curso
        public Boolean AlterarCurso(Curso Curso)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@idCurso", Curso.idCurso));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeCurso", Curso.nomeCurso));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@ementaCurso", Curso.ementaCurso));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@duracaoCurso", Curso.duracaoCurso));

                string comando = "exec uspAlterarCurso @idCurso, @nomeCurso, @ementaCurso, @duracaoCurso";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao alterar Curso
                }
                else
                    return true;

            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Alteração de Curso " + ex.Message);

            }

        }

        //Excluir Curso
        public Boolean ExcluirCurso(Curso Curso)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@idCurso", Curso.idCurso));

                string comando = "exec uspExcluirCurso @idCurso";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao excluir Curso
                }
                else
                    return true;

            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Exclusão de Curso " + ex.Message);

            }

        }

        //Buscar Curso por código
        public Curso BuscarCursoPorCodigo(int codigo)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoCurso", codigo));
            string comandoSql = "exec uspBuscarCursoPorCodigo @codigoCurso";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);


            if (tabelaRetorno.Rows.Count > 0)
            {
                Curso Curso = new Curso();
                DataRow registro = tabelaRetorno.Rows[0];


                Curso.idCurso = Convert.ToInt32(registro[0]);
                Curso.nomeCurso = registro[1].ToString();
                Curso.ementaCurso = registro[2].ToString();
                Curso.duracaoCurso = registro[3].ToString();

                return Curso;
            }
            else
                return null;

        }

        //Buscar Curso por nome
        public ListaCursos BuscarCursosPorNome(String nomeCurso)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeCurso", nomeCurso));


                ListaCursos listaCursos = new ListaCursos();
                Curso Curso = new Curso();

                DataTable tabelaResultado;

                string comando = "exec uspBuscarCursoPorNome @nomeCurso";
                tabelaResultado = sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    Curso = new Curso();

                    Curso.idCurso = Convert.ToInt32(registro[0]);
                    Curso.nomeCurso = registro[1].ToString();
                    Curso.ementaCurso = registro[2].ToString();
                    Curso.duracaoCurso = registro[3].ToString();

                    listaCursos.Add(Curso);
                }
                return listaCursos;

            }
            catch (Exception ex) { throw new Exception("Erro na camada de negócios Buscar Cursos Por Nome " + ex.Message); }
        }

    }
}
