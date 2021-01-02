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
        public bool SellsProducts { get; private set; }

        public Department(int id, string name, bool sellsProducts)
        {
            Id = id;
            Name = name;
            SellsProducts = sellsProducts;
        }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}
