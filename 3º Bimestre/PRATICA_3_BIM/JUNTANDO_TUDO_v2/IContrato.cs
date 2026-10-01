using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUNTANDO_TUDO_v2
{
    interface IContrato
    {
        int NumContrato { get; set; }
        int DescContrato { get; set; }
        string ImprimeContrato();
    }
}
