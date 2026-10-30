using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class Class1
    {
        private User usr;
        private Day day;

        [SetUp]
        public void Init()
        {
            usr = new User();
            day = new Day();
        }

        [Test]
        public void DayTest()
        {
            Assert.IsTrue(day.Equals(usr));
        }

        [Test]
        public void UserTest()
        {
            bool hasil = usr;
        }
    }
}
