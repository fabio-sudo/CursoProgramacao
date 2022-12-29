using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class Curso
    {

       public int? idCurso { get; set; }
       public string nomeCurso { get; set; }
       public string ementaCurso { get; set; }
       public string duracaoCurso { get; set; }


    }

   public class ListaCursos : List<Curso> { }
}
