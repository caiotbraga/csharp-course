using System;
using System.Globalization;
using System.Collections.Generic;
using AbstractM_Ex02.Entities;
namespace AbstractM_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> List = new List<TaxPayer>();
            int n, i, employeeNumber;
            char type;
            string name;
            double anualIncome, healthExpeditures;
            Console.Write("Insert the number of tax payers: "); n = int.Parse(Console.ReadLine());
            for(i = 0; i < n; i++){
                Console.WriteLine($"Tax payer #{i+1} data: ");
                Console.Write("Individual or company (i/c) ? "); type = char.Parse(Console.ReadLine());
                Console.Write("Name: "); name = Console.ReadLine();
                Console.Write("Anual income : "); anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(type == 'i')
                {
                    Console.Write("Health expeditures: "); healthExpeditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Individual individual = new Individual(name, anualIncome, healthExpeditures);
                    List.Add(individual);
                }
                else if(type == 'c'){
                    Console.Write("Number of employees: "); employeeNumber = int.Parse(Console.ReadLine());
                    Company company = new Company(name, anualIncome, employeeNumber);
                    List.Add(company);
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAIDED:");
            foreach(TaxPayer taxPayer in List){
                Console.WriteLine(taxPayer.Name+": $ "+taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            double sum = 0.0;
            foreach(TaxPayer taxPayer in List)
            {
                sum += taxPayer.Tax();
            }
            Console.WriteLine("TOTAL TAXES: $ "+sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
