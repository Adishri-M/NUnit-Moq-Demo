using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Moq1
{
    public interface IMocker
    {
        string PropertyToMock { get; }
    }

    //Class to test
    public class ClassToTest
    {
        //method to be tested
        public string GetPrefixedValue(IMocker provider)
        {
            return "Prefixed:" + provider.PropertyToMock;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
