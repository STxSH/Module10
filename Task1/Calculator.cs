using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    public class Calculator : ISum
    {
        public int Solve(int x, int y)
        {
            return x + y;
        }
    }
}
