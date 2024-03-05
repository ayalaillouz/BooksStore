using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BooksStoreDAL
{
    public class FileConnection
    {
        string filePath = Directory.GetCurrentDirectory() + @"\..\..\..\Src\BookList.txt";
        public List<BookDetails> ReadAllBooks()
        {
            var allLines = File.ReadAllLines(filePath);
            List<BookDetails> listOfBooks = new List<BookDetails>();
            foreach (var text in allLines)
            {
                string [] detailsAsString = text.Split(',');
                int id = int.Parse(detailsAsString[0]);
                string name = detailsAsString[1];
                int price = int.Parse(detailsAsString[2]);
                int numberOfPages = int.Parse(detailsAsString[3]);
                int minAge = int.Parse(detailsAsString[4]);
                int maxAge = int.Parse(detailsAsString[5]);
                bool isComics = bool.Parse(detailsAsString[6]);
                var newBook = new BookDetails(id, name, price, numberOfPages,
                    minAge, maxAge, isComics);
                listOfBooks.Add(newBook);
            }
            return listOfBooks;
        }
    }
}
