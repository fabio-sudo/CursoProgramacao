using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class Professor
    {
        public int? idProfessor { get; set; }
        public string nomeProfessor { get; set; }
        public string sobrenomeProfessor { get; set; }
        public string cpfProfessor { get; set; }
        public string celularProfessor { get; set; }
        public string enderecoProfessor { get; set; }
        public DateTime dataNascimentoProfessor { get; set; }

    }

    public class ListaProfessores : List<Professor> { }
}
