
using System.Text;
using System.Globalization;

namespace Taxes.Entities
{
    internal class Individual : Player
    {
        public double HealthExpenditures { get; protected set; }
        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome) 
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Texas()
        {
            double healthDiscount = HealthExpenditures / 2.00;
            double texa;
            if (AnualIncome < 20000.00)
            {
                texa = AnualIncome * 0.15;
            }
            else
            {
                texa = AnualIncome * 0.20;
            }
            double TotalPay = texa - healthDiscount;
            return TotalPay;
        }
        public override void Print()
        {
           StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name}: $ {Texas().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(sb);
        }
    }
}
