using System;
using System.Collections.Generic;

namespace Grades.Gradebook
{
    public class Class
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Class(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }

    }
}