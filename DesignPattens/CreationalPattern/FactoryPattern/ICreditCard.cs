using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcept.DesignPattens.FactoryPattern
{
    internal interface ICreditCard
    {
        string GetCardType();
        string GetCreditLimit();
        int GetAnnualCharge();
    }
}
