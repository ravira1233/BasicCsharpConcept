﻿using BasicConcept.DesignPattens.AbstractPattern.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcept.DesignPattens.AbstractPattern.ConcreateProducts
{
    public class SportsCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsCar Details..");
        }
    }
}
