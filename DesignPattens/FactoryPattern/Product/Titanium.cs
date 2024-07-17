using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcept.DesignPattens.FactoryPattern.Product
{
    internal class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Card type is Titanium";
        }

        public string GetCreditLimit()
        {
            return "Titanium Card Limit is 10k";
        }

        public int GetAnnualCharge()
        {
            return 2000;
        }
    
    }
}
