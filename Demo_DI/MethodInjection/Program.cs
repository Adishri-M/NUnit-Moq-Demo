using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInjection
{
    public interface IAutomobile//abstraction layer
    {
        void Travel();
    }
    public class Jeep : IAutomobile
    {
        //IAutomobile Members
        public void Travel()
        {
            Console.WriteLine(" Travelling in Jeep");
        }
    }
    public class SUV : IAutomobile
    {
        //IAutomobile Members
        public void Travel()
        {
            Console.WriteLine(" Travelling in SUV");
        }
    }
    public class AutomobileController// higher level module
    {
        public void Ride(IAutomobile m_Automobile)
        {
            m_Automobile.Travel();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAutomobile automobile = new Jeep();
            AutomobileController automobileController = new AutomobileController();
            automobileController.Ride(automobile);

            automobile = new SUV();
            automobileController.Ride(automobile);
            Console.Read();

        }
    }
}
