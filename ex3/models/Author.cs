namespace EX3.models
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