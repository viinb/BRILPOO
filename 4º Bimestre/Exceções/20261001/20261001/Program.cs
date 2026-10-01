using _20261001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula_20261001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFSP U = new IFSP();
            U.Gravar("");
            Console.WriteLine(U.ToString());
        }
    }
}
