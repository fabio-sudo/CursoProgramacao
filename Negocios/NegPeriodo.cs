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
   public class NegPeriodo
    {
        //Instancia objeto conexao sql
        ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Cadastrar Periodo
        public Boolean cadastraPeriodo(Periodo Periodo)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomePeriodo", Periodo.nomePeriodo));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@horarioInicialPeriodo", Periodo.horarioInicialPeriodo));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@horarioFinalPeriodo", Periodo.horarioFinalPeriodo));


                string comando = "exec uspCadastrarPeriodo @nomePeriodo, @horarioInicialPeriodo, @horarioFinalPeriodo";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao cadastrar Periodo
                }
                else
                    return true;

            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Cadastro de Periodo " + ex.Message);

            }

        }

        //Alterar Periodo
        public Boolean AlterarPeriodo(Periodo Periodo)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@idPeriodo", Periodo.idPeriodo));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomePeriodo", Periodo.nomePeriodo));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@horarioInicialPeriodo", Periodo.horarioInicialPeriodo));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@horarioFinalPeriodo", Periodo.horarioFinalPeriodo));

                string comando = "exec uspAlterarPeriodo @idPeriodo, @nomePeriodo, @horarioInicialPeriodo, @horarioFinalPeriodo";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao alterar Periodo
                }
                else
                    return true;

            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Alteração de Periodo " + ex.Message);

            }

        }

        //Excluir Periodo
        public Boolean ExcluirPeriodo(Periodo Periodo)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@idPeriodo", Periodo.idPeriodo));

                string comando = "exec uspExcluirPeriodo @idPeriodo";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao excluir Periodo
                }
                else
                    return true;

            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Exclusão de Periodo " + ex.Message);

            }

        }

        //Buscar Periodo por código
        public Periodo BuscarPeriodoPorCodigo(int codigo)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoPeriodo", codigo));
            string comandoSql = "exec uspBuscarPeriodoPorCodigo @codigoPeriodo";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);


            if (tabelaRetorno.Rows.Count > 0)
            {
                Periodo Periodo = new Periodo();
                DataRow registro = tabelaRetorno.Rows[0];


                Periodo.idPeriodo = Convert.ToInt32(registro[0]);
                Periodo.nomePeriodo = registro[1].ToString();
                Periodo.horarioInicialPeriodo = Convert.ToDateTime(registro[2]);
                Periodo.horarioFinalPeriodo = Convert.ToDateTime(registro[3]);



                return Periodo;
            }
            else
                return null;

        }

        //Buscar Periodo por nome
        public ListaPeriodos BuscarPeriodosPorNome(String nomePeriodo)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomePeriodo", nomePeriodo));


                ListaPeriodos listaPeriodos = new ListaPeriodos();
                Periodo Periodo = new Periodo();

                DataTable tabelaResultado;

                string comando = "exec uspBuscarPeriodoPorNome @nomePeriodo";
                tabelaResultado = sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    Periodo = new Periodo();

                    Periodo.idPeriodo = Convert.ToInt32(registro[0]);
                    Periodo.nomePeriodo = registro[1].ToString();
                    Periodo.horarioInicialPeriodo = Convert.ToDateTime(registro[2]);
                    Periodo.horarioFinalPeriodo = Convert.ToDateTime(registro[3]);

                    listaPeriodos.Add(Periodo);
                }
                return listaPeriodos;

            }
            catch (Exception ex) { throw new Exception("Erro na camada de negócios Buscar Periodos Por Nome " + ex.Message); }
        }
    }
}
