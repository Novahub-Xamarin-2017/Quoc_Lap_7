using Exercise3.Models.BaseModel;

namespace Exercise3.Models
{
    public class Author : EasyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Author()
        {
        }

        public Author(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}