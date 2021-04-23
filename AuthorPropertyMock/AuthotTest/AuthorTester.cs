using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using AuthorPropertyMock;

namespace AuthotTest
{
    [TestFixture]
    class AuthorTester
    {
        [Test]
        [TestCase("Raj",10," Kumar")]
        public void TestAuthorMock(string name, int id, string lname)
        {
            var mock = new Mock<IAuthor>();
            mock.SetupGet(x => x.FirstName).Returns("Raj");
            mock.SetupGet(x => x.Id).Returns(10);
            mock.SetupGet(x => x.LastName).Returns(" Kumar");
            Assert.AreEqual(name,mock.Object.FirstName);
            Assert.AreEqual(id, mock.Object.Id);
            Assert.AreEqual(lname, mock.Object.LastName);
        }
    }
}
