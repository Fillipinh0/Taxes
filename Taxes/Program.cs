using System;
using Taxes.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            double anualIncome;
            List<Player> players = new List<Player>();
            Console.Write("Enter the number of tax payers: ");
            int NumberOfPlayers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= NumberOfPlayers; i++)
            {
                Console.WriteLine($"Tax player #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                Char IndividualOrCompany = Char.Parse(Console.ReadLine().ToLower());
                if (IndividualOrCompany == 'i')
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expeditures: ");
                    double healthExpeditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    players.Add(new Individual(name, anualIncome, healthExpeditures));
                }
                else
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    players.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0;
            foreach (Player p in players)
            {
                totalTaxes += p.Texas();
                p.Print();
            }
            Console.WriteLine($"Total taxes: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}