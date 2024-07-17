using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcept.DesignPattens.FactoryPattern.Product
{
    internal class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "Card type is MoneyBack";
        }

        public string GetCreditLimit()
        {
            return "MoneyBack Card Limit is 10k";
        }

        public int GetAnnualCharge()
        {
            return 3000;
        }
    
    }
}
