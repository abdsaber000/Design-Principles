using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cheese : Pizza
    {
        public override string Name => base.Name + $" {nameof(Cheese)}";
        public override decimal Price => base.Price + 3;
    }
}
