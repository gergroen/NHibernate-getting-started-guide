﻿using NHibernate.GettingStarted.Model;
using NUnit.Framework;

namespace NHibernate.GettingStarted.Test
{
    [TestFixture]
    public class PersonTest
    {
        [Test]
        public void GetFullNameTest()
        {
            var person = new Person
                             {
                                 FirstName = "Test",
                                 LastName = "Kees"
                             };

            Assert.AreEqual("Test", person.FirstName);
            Assert.AreEqual("Kees", person.LastName);

            Assert.AreEqual("Test Kees", person.GetFullName());
        }
    }
}
