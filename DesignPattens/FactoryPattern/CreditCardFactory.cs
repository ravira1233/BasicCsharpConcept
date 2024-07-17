using BasicConcept.DesignPattens.FactoryPattern.Product;

namespace BasicConcept.DesignPattens.FactoryPattern
{
    internal class CreditCardFactory
    {
        //the Pattern creates an object without exposing the object creation logic to the client,
        //and the client refers to the newly created object using a common interface
        //In simple words, if we have a superclass and n number of subclasses, and based on the data provided, if we have to create and return the object of one of the subclasses,
        //then we need to use the Factory Design Pattern in C#.
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard cardDetails = null;

            if (cardType == "MoneyBack")
                cardDetails = new MoneyBack();
            else if (cardType == "Titanium")
                cardDetails = new Titanium();
            else if (cardType == "Platinum") cardDetails = new Platinum();

            return cardDetails;
        }
    }
}