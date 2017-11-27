using System.Collections.Generic;
using EX3.models;

namespace EX3.controllers
{
    public class DataGenegator
    {
        public static List<Book> GenerateBooks() => new List<Book>()
        {
            new Book(1,"name1",1,1997,1,3.9),
            new Book(2,"name5",1,1997,2,4.1),
            new Book(3,"name3",1,1997,1,4.3),
            new Book(4,"name2",2,1997,1,4.1),
            new Book(5,"name4",2,1997,2,3.9),
        };

        public static List<Catalog> GenerateCatalogs() => new List<Catalog>()
        {
            new Catalog(1,"cata1"),
            new Catalog(2,"cata2"),
        };

        public static List<Author> GenerateAuthors() => new List<Author>()
        {
            new Author(1,"author1"),
            new Author(2,"author2"),
        };
    }
}