using Seção9_Exercicio5.Entities;
using System.Collections.Generic;
using System.Globalization;


namespace Seção9_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers:");
            int n = int.Parse(Console.ReadLine());
        
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c) ? ");
                char Individuo = char.Parse(Console.ReadLine());
                
                if(Individuo == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anuallncome = double.Parse(Console.ReadLine());
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anuallncome, healthExpenditures));
                    Console.WriteLine();

                } else if(Individuo == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anuallncome = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anuallncome, numberOfEmployees));
                    Console.WriteLine();
                }

            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer company in list)
            {
                double tax = company.Tax();
                Console.WriteLine(company.ToString());
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));



            //Console.WriteLine("TOTAL TAXES: $ " + );






        }
    }
}