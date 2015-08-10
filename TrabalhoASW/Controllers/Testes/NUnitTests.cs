using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Controllers.Testes
{
    [TestFixture]
    public class NUnitTests
    {
        [Test]
        public void SumOfTwoNumbers()
        {
            Assert.AreEqual(10,5 + 5);
        }
        [Test]
        public void AreTheValuesTheSame()
        {
            String str = "";
            Assert.AreSame(str, str);
        }
    }
}