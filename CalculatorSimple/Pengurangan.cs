using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSimple
{
    class Pengurangan : Abstract
    {
        public int value1 { get; private set; }
        public int value2 { get; private set; }

        public Pengurangan(int aValue1, int aValue2)
        {
            value1 = aValue1;
            value2 = aValue2;
        }

        public override int Proccess()
        {
            return value1 - value2;
        }
    }
}
