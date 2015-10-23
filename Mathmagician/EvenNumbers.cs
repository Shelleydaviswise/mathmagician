using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class EvenNumbers : NaturalNumbers
    {
        public EvenNumbers()
        {
            first = 2;
        }

        public override int GetNext(int x)
        {
            //call the NaturalNumbers GetNext Method and augments it
            return base.GetNext(x) + 1;
        }

    }
}
