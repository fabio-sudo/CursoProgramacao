using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class AlunoCurso
    {
        public int? idAlunoCurso { get; set; }
        public Aluno Aluno { get; set; }
        public Curso Curso { get; set; }
        public Professor Professor { get; set; }
        public Periodo Periodo { get; set; }
        public string diaSemanaCurso { get; set; }
        public string statusCurso{get; set;}
    }

    public class ListaAlunoCurso : List<AlunoCurso> { }

}
