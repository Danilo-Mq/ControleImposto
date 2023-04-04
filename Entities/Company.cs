using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção9_Exercicio5.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anuallncome, int numberOfEmployees) : base (name, anuallncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }


        public override double Tax()
        {
            if ( NumberOfEmployees <= 10)
            {
                return Anuallncome * 0.16;
            } else
            {
                return Anuallncome * 0.14;
            }
        }



    }
}
