using System;
using System.Xml.Serialization;
using NHibernate.GettingStarted.Dao;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace NHibernate.GettingStarted.Test
{
    [TestFixture]
    public class NHibernateMappingTest
    {
        [Test]
        public void CanGenerateSchema()
        {
            var schemaUpdate = new SchemaUpdate(NHibernateHelper.Configuration);
            schemaUpdate.Execute(Console.WriteLine, true);
        }
    }
}
