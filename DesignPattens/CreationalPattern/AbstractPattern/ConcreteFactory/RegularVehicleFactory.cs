using BasicConcept.DesignPattens.AbstractPattern.AbstractFactory;
using BasicConcept.DesignPattens.AbstractPattern.AbstractProducts;
using BasicConcept.DesignPattens.AbstractPattern.ConcreateProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcept.DesignPattens.AbstractPattern.ConcreteFactory
{
    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }
        public ICar CreateCar()
        {
            return new RegularCar();    
        }
    }
}
