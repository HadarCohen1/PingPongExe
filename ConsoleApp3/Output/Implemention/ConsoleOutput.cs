using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingPong.Output.Abstract;

namespace PingPong.Output.Implemention
{
    public class ConsoleOutput : IOutput<string>
    {
        public void Print(string toPrint)
        {
            Console.WriteLine(toPrint);
        }
    }
}
