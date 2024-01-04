using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Vegeterian : Pizza
    {
        public override string Name => base.Name + $" {nameof(Vegeterian)}";
        public override decimal Price => base.Price + 12;
    }
}
