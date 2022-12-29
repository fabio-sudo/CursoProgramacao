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
   public class NegProfessor
    {
        //Instancia objeto conexao sql
        ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Cadastrar Professor
        public Boolean cadastraProfessor(Professor Professor)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeProfessor", Professor.nomeProfessor));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sobrenomeProfessor", Professor.sobrenomeProfessor));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cpfProfessor", Professor.cpfProfessor));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@celularProfessor", Professor.celularProfessor));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@enderecoProfessor", Professor.enderecoProfessor));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataNascimentoProfessor", Professor.dataNascimentoProfessor));


                string comando = "exec uspCadastrarProfessor @nomeProfessor, @sobrenomeProfessor, @cpfProfessor, @celularProfessor, @enderecoProfessor," +
                    "@dataNascimentoProfessor";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao cadastrar Professor
                }
                else
                    return true;

            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Cadastro de Professor " + ex.Message);

            }

        }

        //Alterar Professor
        public Boolean AlterarProfessor(Professor Professor)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@idProfessor", Professor.idProfessor));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeProfessor", Professor.nomeProfessor));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sobrenomeProfessor", Professor.sobrenomeProfessor));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cpfProfessor", Professor.cpfProfessor));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@celularProfessor", Professor.celularProfessor));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@enderecoProfessor", Professor.enderecoProfessor));
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataNascimentoProfessor", Professor.dataNascimentoProfessor));

                string comando = "exec uspAlterarProfessor @idProfessor, @nomeProfessor, @sobrenomeProfessor, @cpfProfessor, @celularProfessor, @enderecoProfessor," +
                    "@dataNascimentoProfessor";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao alterar Professor
                }
                else
                    return true;

            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Alteração de Professor " + ex.Message);

            }

        }

        //Excluir Professor
        public Boolean ExcluirProfessor(Professor Professor)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@idProfessor", Professor.idProfessor));

                string comando = "exec uspExcluirProfessor @idProfessor";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao excluir Professor
                }
                else
                    return true;

            }

            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios. Exclusão de Professor " + ex.Message);

            }

        }

        //Buscar Professor por código
        public Professor BuscarProfessorPorCodigo(int codigo)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoProfessor", codigo));
            string comandoSql = "exec uspBuscarProfessorPorCodigo @codigoProfessor";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);


            if (tabelaRetorno.Rows.Count > 0)
            {
                Professor Professor = new Professor();
                DataRow registro = tabelaRetorno.Rows[0];


                Professor.idProfessor = Convert.ToInt32(registro[0]);
                Professor.nomeProfessor = registro[1].ToString();
                Professor.sobrenomeProfessor = registro[2].ToString();
                Professor.cpfProfessor = registro[3].ToString();
                Professor.celularProfessor = registro[4].ToString();
                Professor.enderecoProfessor = registro[5].ToString();
                Professor.dataNascimentoProfessor = Convert.ToDateTime(registro[6]);


                return Professor;
            }
            else
                return null;

        }

        //Buscar Professor por nome
        public ListaProfessores BuscarProfessorsPorNome(String nomeProfessor)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeProfessor", nomeProfessor));


                ListaProfessores listaProfessors = new ListaProfessores();
                Professor Professor = new Professor();

                DataTable tabelaResultado;

                string comando = "exec uspBuscarProfessorPorNome @nomeProfessor";
                tabelaResultado = sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    Professor = new Professor();

                    Professor.idProfessor = Convert.ToInt32(registro[0]);
                    Professor.nomeProfessor = registro[1].ToString();
                    Professor.sobrenomeProfessor = registro[2].ToString();
                    Professor.cpfProfessor = registro[3].ToString();
                    Professor.celularProfessor = registro[4].ToString();
                    Professor.enderecoProfessor = registro[5].ToString();
                    Professor.dataNascimentoProfessor = Convert.ToDateTime(registro[6]);

                    listaProfessors.Add(Professor);
                }
                return listaProfessors;

            }
            catch (Exception ex) { throw new Exception("Erro na camada de negócios Buscar Professores Por Nome " + ex.Message); }
        }
    }
}
