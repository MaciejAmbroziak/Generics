using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Project
    {
        public string Name;

        public Project(string title)
        {
            Name = title;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
