using System;
using System.Collections.Generic;
using System.Linq;
using Exercise3.controllers;
using Exercise3.models;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = DataGenegator.GenerateBooks();
            var authors = DataGenegator.GenerateAuthors();
            var catalogs = DataGenegator.GenerateCatalogs();
            DisplayBooksInOrderOfTitle(books, catalogs, authors);
            DisplayBooksInPage(books,catalogs,authors,2,2);
            DisplayCatalogDetail(books, catalogs);
            DisplayAuthorDetails(books, catalogs, authors);
            var keyword = "1";
            Search(books, catalogs, authors,keyword);
            Console.ReadKey();
        }

        private static void Search(List<Book> books, List<Catalog> catalogs, List<Author> authors, string keyword)
        {
            var searchResult = from book in books
                join author in authors on book.Author equals author.Id
                join catalog in catalogs on book.Catalog equals catalog.Id
                where book.Title.Contains(keyword) || author.Name.Contains(keyword) || catalog.Name.Contains(keyword)
                select new
                {
                    book.Id,
                    book.Title,
                    Catalog = catalog.Name,
                    Author = author.Name,
                    book.Rate
                };
            Console.WriteLine("\nSearch result :");
            searchResult.ToList().ForEach(Console.WriteLine);
        }

        private static void DisplayAuthorDetails(List<Book> books, List<Catalog> catalogs, List<Author> authors)
        {
            var authorDetails = from author in authors
                join book in books on author.Id equals book.Author into g
                from authorGroup in g
                join catalog in catalogs on authorGroup.Catalog equals catalog.Id 
                select new
                {
                    author,
                    AverageRate = g.Average(b => b.Rate),
                    BookCount = g.Count(),
                    CatalogExample = g.Aggregate("", (a, b) => a + (catalog.Name + " ")),
                };
            Console.WriteLine("\nAuthor details : ");
            authorDetails.ToList().ForEach(Console.WriteLine);
        }

        private static void DisplayCatalogDetail(List<Book> books, List<Catalog> catalogs)
        {
            var catalogDetail = from catalog in catalogs
                join book in books on catalog.Id equals book.Catalog
                    into catalogGroup
                select new
                {
                    catalog.Id,
                    catalog.Name,
                    AverageRate = catalogGroup.Average(b => b.Rate),
                    BookExample = catalogGroup.Take(3).Aggregate("",(a,b) => a + (b.Title + " ")),
                    BookCount = catalogGroup.Count()
                };
            Console.WriteLine("\nCatalogs Detail : ");
            catalogDetail.ToList().ForEach(Console.WriteLine);
        }

        private static void DisplayBooksInOrderOfTitle(List<Book> books, List<Catalog> catalogs, List<Author> authors)
        {
            var booksInOrderOfTitle = from book in books
                join author in authors on book.Author equals author.Id
                join catalog in catalogs on book.Catalog equals catalog.Id
                select new
                {
                    book.Id,
                    book.Title,
                    Catalog = catalog.Name,
                    Author = author.Name,
                    book.Rate
                };
                
            Console.WriteLine("List of books in order of title :");
            booksInOrderOfTitle.ToList().ForEach(Console.WriteLine);
        }

        private static void DisplayBooksInPage(List<Book> books, List<Catalog> catalogs, List<Author> authors, int pageId, int maxItemPerPage)
        {
            var booksInPage = (from book in books
                join author in authors on book.Author equals author.Id
                join catalog in catalogs on book.Catalog equals catalog.Id
                select new
                {
                    book.Id,
                    book.Title,
                    Catalog = catalog.Name,
                    Author = author.Name,
                    book.Rate
                }).Skip(maxItemPerPage * (pageId - 1)).Take(maxItemPerPage);

            Console.WriteLine($"List of books in page {pageId} :");
            booksInPage.ToList().ForEach(Console.WriteLine);
        }
    }
}
