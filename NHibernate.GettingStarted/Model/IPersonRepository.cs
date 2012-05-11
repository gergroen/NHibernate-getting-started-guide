using System;

namespace NHibernate.GettingStarted.Model
{
    public interface IPersonRepository
    {
        /// <summary>
        /// Get person entity by id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>person</returns>
        Person Get(Guid id);

        /// <summary>
        /// Save person entity
        /// </summary>
        /// <param name="person">person</param>
        void Save(Person person);
        
        /// <summary>
        /// Update person entity
        /// </summary>
        /// <param name="person">person</param>
        void Update(Person person);

        /// <summary>
        /// Delete person entity
        /// </summary>
        /// <param name="person">person</param>
        void Delete(Person person);

        /// <summary>
        /// Row count person in db
        /// </summary>
        /// <returns>number of rows</returns>
        long RowCount();
    }
}
