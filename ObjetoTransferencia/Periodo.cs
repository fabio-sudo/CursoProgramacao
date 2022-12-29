using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class Periodo
    {
       public int? idPeriodo { get; set; }
       public string nomePeriodo { get; set; }
       public DateTime horarioInicialPeriodo { get; set; }
       public DateTime horarioFinalPeriodo { get; set; }

    }

   public class ListaPeriodos : List<Periodo> { }
}
