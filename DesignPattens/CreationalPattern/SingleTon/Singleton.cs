using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcept.DesignPattens.SingleTon
{
    public   class Singleton
    {
        private static Singleton instance;
        private static int Counter = 0;

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        public Singleton()
        {
            ++Counter;
            Console.WriteLine("Counter Value " + Counter.ToString());


        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        // we can inherit via like this nested class to avaoid this we will use sealed class
        //public class Decoration : Singleton
        //{

        //}
    }
}
