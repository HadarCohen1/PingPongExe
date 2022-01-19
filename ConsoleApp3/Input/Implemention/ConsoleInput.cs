using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingPong.Input.Abstract;

namespace PingPong.Input.Implemention
{
    public class ConsoleInput : IInput<string>
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
