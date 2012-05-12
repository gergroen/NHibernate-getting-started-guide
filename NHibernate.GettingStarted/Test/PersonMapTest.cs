using System;
using System.Xml.Serialization;
using NHibernate.GettingStarted.Dao;
using NHibernate.Mapping.ByCode;
using NUnit.Framework;

namespace NHibernate.GettingStarted.Test
{
    [TestFixture]
    public class PersonMapTest
    {
        [Test]
        public void CanGenerateXmlMapping()
        {
            var mapper = new ModelMapper();
            mapper.AddMapping<PersonMap>();

            var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
            var xmlSerializer = new XmlSerializer(mapping.GetType());
 
            xmlSerializer.Serialize(Console.Out, mapping);
        }
    }
}
