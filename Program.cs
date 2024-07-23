﻿using BasicConcept.DesignPattens.FactoryPattern.Product;
using BasicConcept.DesignPattens.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicConcept.DesignPattens.AbstractPattern.AbstractFactory;
using BasicConcept.DesignPattens.AbstractPattern.AbstractProducts;
using BasicConcept.DesignPattens.AbstractPattern.ConcreteFactory;
using BasicConcept.DesignPattens.SingleTon;

namespace BasicConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Factory pattarn called
            ICreditCard cardDetails = CreditCardFactory.GetCreditCard("MoneyBack");
            cardDetails.GetCreditLimit();

            //Abstract pattern called

            IVehicleFactory vehicleFactory = new RegularVehicleFactory();
            vehicleFactory.CreateBike();
            ICar car = vehicleFactory.CreateCar();
            car.GetDetails();

            //Singleton pattern is called
            Singleton _single = Singleton.GetInstance();
            _single.PrintDetails("is called");
            Singleton _single1 = Singleton.GetInstance();
            _single1.PrintDetails("is called");
            Console.ReadLine();



        }

    }
}
