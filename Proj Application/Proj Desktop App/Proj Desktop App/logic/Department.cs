using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class Department
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}
