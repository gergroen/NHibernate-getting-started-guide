using System.IO;
using NHibernate.GettingStarted.Model;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace NHibernate.GettingStarted.Dao.Test
{
    [TestFixture]
    public class NHibernatePersonRepositoryTest
    {
        private IPersonRepository _personRepo;

        [SetUp]
        public void CreateSchema()
        {
            DeleteDatabaseIfExists();

            var schemaUpdate = new SchemaUpdate(NHibernateHelper.Configuration);
            schemaUpdate.Execute(false, true);

            _personRepo = new NHibernatePersonRepository();
        }

        [Test]
        public void CanSavePerson()
        {
            _personRepo.Save(new Person());
            Assert.AreEqual(1, _personRepo.RowCount());
        }

        [Test]
        public void CanGetPerson()
        {
            var person = new Person();
            _personRepo.Save(person);
            Assert.AreEqual(1, _personRepo.RowCount());

            person = _personRepo.Get(person.Id);
            Assert.IsNotNull(person);
        }

        [Test]
        public void CanUpdatePerson()
        {
            var person = new Person();
            _personRepo.Save(person);
            Assert.AreEqual(1, _personRepo.RowCount());

            person = _personRepo.Get(person.Id);
            person.FirstName = "Test";
            _personRepo.Update(person);

            Assert.AreEqual(1, _personRepo.RowCount());
            Assert.AreEqual("Test", _personRepo.Get(person.Id).FirstName);
        }

        [Test]
        public void CanDeletePerson()
        {
            var person = new Person();
            _personRepo.Save(person);
            Assert.AreEqual(1, _personRepo.RowCount());

            _personRepo.Delete(person);
            Assert.AreEqual(0, _personRepo.RowCount());
        }

        [TearDown]
        public void DeleteDatabaseIfExists()
        {
            if (File.Exists("test.db"))
                File.Delete("test.db");
        }
    }
}
