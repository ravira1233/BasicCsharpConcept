using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcept.EnumerableConcept
{
    internal class Customer
    {
        public List<ModelCustomer> cust = new List<ModelCustomer>()
        {
            new ModelCustomer() { Age = "1", Name = "Raja", Phone = "23456781", ID = 1 },
            new ModelCustomer() { Age = "2", Name = "Sanchu", Phone = "789456123", ID = 2 },
            new ModelCustomer() { Age = "3", Name = "Kiru", Phone = "789456123", ID = 1 }
        };

        public void GetName()
        {
            foreach (var modelCustomer in cust)
            {
                string name = modelCustomer.Name;
            }
        }
    }

    public class ModelCustomer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Phone { get; set; }
    }
}
