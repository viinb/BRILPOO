using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInterface
{
    interface IConta
    {
        void Depositar(double valor);
        void Sacar(double valor);
        double GetSaldo();
    }
}
