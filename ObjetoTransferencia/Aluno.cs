using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Aluno
    {

        public int? idAluno { get; set; }
        public string nomeAluno { get; set; }
        public string sobrenomeAluno { get; set; }
        public string cpfAluno { get; set; }
        public string celularAluno { get; set; }
        public string enderecoAluno { get; set; }
        public string idadeAluno { get; set; }
        public DateTime dataNascimentoAluno { get; set; }
        public string  statusAluno { get; set; }

    }

    public class ListaAlunos :List<Aluno>{ }
}
