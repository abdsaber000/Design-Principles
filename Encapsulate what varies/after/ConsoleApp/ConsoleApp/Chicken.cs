using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Chicken : Pizza
    {
        public override string Name => base.Name + $" {nameof(Chicken)}";
        public override decimal Price => base.Price + 8;
    }
}
