using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Seção9_Exercicio5.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public Double Anuallncome { get; set; }

        protected TaxPayer(string name, double anuallncome)
        {
            Name = name;
            Anuallncome = anuallncome;
        }

        abstract public double Tax();

        public override string ToString()
        {
            return Name
                + ": $ "
                + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }

       


    }
}
