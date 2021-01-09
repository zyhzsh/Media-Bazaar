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

        public void ChangeInfo(string updatedName, bool sells)
        {
            if (!string.IsNullOrEmpty(updatedName))
            {
                this.Name = updatedName;
            }
            SellsProducts = sells;
        }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}
