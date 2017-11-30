using Exercise3.Models.BaseModel;

namespace Exercise3.Models
{
    public class Catalog : EasyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Catalog()
        {
        }

        public Catalog(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}