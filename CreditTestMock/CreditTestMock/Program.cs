using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditTestMock
{
    public interface ICreditDecisionService
    {
        string GetCreditDecision(int creditScore);
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
