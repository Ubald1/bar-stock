using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prove
{
    internal class utilities
    {
        public int euroMese(int ore, int paga)
        {
            Console.WriteLine($"Questo mese prendi:  {ore * paga}");
            return ore * paga;
        }
    }
}
