using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxes.Entities
{
    internal abstract class Player
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        protected Player()
        {

        }
        protected Player(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double Texas();
        public abstract void Print();
    }
}
