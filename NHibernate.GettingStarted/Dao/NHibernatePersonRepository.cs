using System;
using NHibernate.GettingStarted.Model;

namespace NHibernate.GettingStarted.Dao
{
    public class NHibernatePersonRepository : IPersonRepository
    {
        public void Save(Person person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(person);
                transaction.Commit();
            }
        }

        public Person Get(Guid id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Person>(id);
        }

        public void Update(Person person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(person);
                transaction.Commit();
            }
        }

        public void Delete(Person person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(person);
                transaction.Commit();
            }
        }

        public void Add<T>(T entity)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(entity);
                transaction.Commit();
            }
        }

        public long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Person>().RowCountInt64();
            }
        }
    }
}