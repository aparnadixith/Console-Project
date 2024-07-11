using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Project.Models
{
    public class ToDo
    {
        //Private fields
        private readonly int id;
        private string description;
        private bool done;
        private Person assignee;

        //Constructor
        public ToDo(int id, string description)
        {
            this.id = id;
            this.description = description; 
            done = false;
        }


        //Properties
        public int Id => id;
        public string Description
        {
            get => description;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Description cannot be null or empty.");
                }
                description = value;
            }

        }
        public bool Done
        {
            get => done;
            set => done = value;
        }
        public Person Assignee
        {
            get => assignee;
            set => assignee = value;
        }
        
    }

}
