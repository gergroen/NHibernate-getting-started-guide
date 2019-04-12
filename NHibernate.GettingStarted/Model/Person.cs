using System;

namespace NHibernate.GettingStarted.Model
{
    public class Person
    {
        public virtual Guid Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}