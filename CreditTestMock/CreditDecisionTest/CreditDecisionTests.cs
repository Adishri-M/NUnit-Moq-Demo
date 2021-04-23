using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using CreditTestMock;

namespace CreditDecisionTest
{
    [TestFixture]
    class CreditDecisionTests
    {
        Mock<ICreditDecisionService> mock;
        CreditDecision systemUnderTest;

        [Test]
        [TestCase(100, "Declined")]
        [TestCase(549, "Declined")]
        [TestCase(550, "Maybe")]
        [TestCase(674, "Maybe")]
        [TestCase(675, "We look forward to doing business with you!")]
        public void MakeCreditDecision_Always_ReturnsExpectedResult(int creditScore, string expectedResult)
        {

            mock = new Mock<ICreditDecisionService>(MockBehavior.Strict);
            mock.Setup(p => p.GetCreditDecision(creditScore)).Returns(expectedResult);
            systemUnderTest = new CreditDecision(mock.Object);
            string actual = systemUnderTest.MakeCreditDecision(creditScore);
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
