using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Project.Models
{
    public class Person
    {
        private readonly int id;
        private string firstName;
        private string lastName;

        //Constructor
        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }
       
       
        // public propereties to access private field while getting and setting

        public int Id => this.id;

        public string FirstName
        {
            get { return FirstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Firstname cannot be null or empty");                    }
                else
                    FirstName = value;
            }
        }
        public string LastName
        {
            get { return LastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Lastname cannot be null or empty");
                }
                else
                    LastName = value;
            }
        }
    }
}
