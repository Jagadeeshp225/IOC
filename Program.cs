using System;

namespace IOC
{
    public class DataAccessLayer
    {
        public void getempsalary()
        {
            Console.WriteLine("return successfuuly");
        }
    }
    public class inverting
    {
        public static DataAccessLayer Creatinginstance()
        {
            return new DataAccessLayer();
        }
    }
    public class Businesslayer // it is dependent on dal class
    {
        // DataAccessLayer obj = new DataAccessLayer();
        DataAccessLayer obj = inverting.Creatinginstance();
        public void getemp()
        {
            obj.getempsalary();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Businesslayer bal = new Businesslayer();
            bal.getemp();

        }
    }
}
