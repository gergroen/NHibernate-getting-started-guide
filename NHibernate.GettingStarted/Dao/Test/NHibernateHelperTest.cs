using System;
using System.Xml.Serialization;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace NHibernate.GettingStarted.Dao.Test
{
    [TestFixture]
    public class NHibernateMappingTest
    {
        [Test]
        public void CanGenerateXmlMapping()
        {
            var mapping = NHibernateHelper.Mapping;
            var xmlSerializer = new XmlSerializer(mapping.GetType());
 
            xmlSerializer.Serialize(Console.Out, mapping);
        }

        [Test]
        public void CanGenerateSchema()
        {
            var schemaUpdate = new SchemaUpdate(NHibernateHelper.Configuration);
            schemaUpdate.Execute(Console.WriteLine, true);
        }
    }
}
