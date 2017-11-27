namespace Exercise3.models
{
    public class Book : EasyModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Catalog { get; set; }
        public int PublishYear { get; set; }
        public int Author { get; set; }
        public double Rate { get; set; }

        public Book()
        {
        }

        public Book(int id, string title, int catalog, int publishYear, int author, double rate)
        {
            Id = id;
            Title = title;
            Catalog = catalog;
            PublishYear = publishYear;
            Author = author;
            Rate = rate;
        }
    }
}