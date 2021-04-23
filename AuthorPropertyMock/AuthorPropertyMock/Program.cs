using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorPropertyMock
{
    public interface IAuthor
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
