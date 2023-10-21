using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    public class Calculator : ISum
    {
        ILogger Logger { get; set; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public int Solve(int x, int y)
        {
            Logger.Event($"Считаем сумму чисел {x} и {y}");
            return x + y;
        }
    }
}
