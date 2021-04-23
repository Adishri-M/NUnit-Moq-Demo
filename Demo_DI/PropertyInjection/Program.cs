using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInjection
{
    public interface ISalary
    {
        void CalculateSalary();
    }
    public class Employee : ISalary
    {
        public void CalculateSalary() { Console.WriteLine("Employee salary calaculated"); }
    }
    public class Vendor : ISalary
    {
        public void CalculateSalary() { Console.WriteLine("Vendor salary  calaculated"); }
    }
    public class SalaryCalculator
    {
        private ISalary _service;
        public ISalary Service
        {
            set { this._service = value; }
        }
        public void SalaryChecker() 
        { 
            this._service.CalculateSalary(); 
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating object
            Employee s1 = new Employee();

            SalaryCalculator client = new SalaryCalculator();
            client.Service = s1; //passing dependency
            client.SalaryChecker();

            Vendor s2 = new Vendor();
            client.Service = s2; //passing dependency
            client.SalaryChecker();
            Console.Read();
        }
    }
}
