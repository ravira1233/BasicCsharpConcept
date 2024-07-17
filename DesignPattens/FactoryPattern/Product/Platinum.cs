using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcept.DesignPattens.FactoryPattern.Product
{
    internal class Platinum: ICreditCard
    {
        public string GetCardType()
        {
            return "Card type";
        }

        public string GetCreditLimit()
        {
            return "Card Limit is 10k";
        }

        public int GetAnnualCharge()
        {
            return 1000;
        }
    }
}
