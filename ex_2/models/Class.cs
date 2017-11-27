namespace Exercise2.models
{
    public class Class : EasyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Class(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}