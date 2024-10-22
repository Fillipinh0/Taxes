
using Taxes.Entities;
using System.Globalization;
using System.Text;


namespace Taxes.Entities
{
    internal class Company : Player
    {
        public int NumberOfEmployees;
        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Texas()
        {
            double texa = AnualIncome / 100.00;
            if (NumberOfEmployees <= 10)
            {
                texa *= 16.00;
            }
            else
            {
                texa *= 14.00;
            }
            double TotalPay = texa;
            return TotalPay;
        }

        public override void Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name}: $ {Texas().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(sb.ToString());
        }
    }
}

