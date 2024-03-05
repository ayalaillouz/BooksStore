using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksStoreDAL;
using Entities;

namespace BooksStoreBL
{
    public class BookStoreBL
    {
        List<BookDetails> ListOfBooks;
        FileConnection fileConnection;
        public BookStoreBL()
        {
            fileConnection = new FileConnection();
            ListOfBooks = fileConnection.ReadAllBooks();
        }

        public IEnumerable<BookDetails> GetAllBooks()
        {
            return ListOfBooks;
        }
        public IEnumerable<BookDetails> GetAllBooksOver30()
        {

            ListOfBooks = ListOfBooks.Where(book => book.Price > 30).ToList();
            return ListOfBooks;
        }
        public IEnumerable<BookDetails> GetAllOrderBooks()
        {
            ListOfBooks = ListOfBooks.OrderBy(book => book.Id).ToList();
            return ListOfBooks;
        }
        public IEnumerable<BookDetails> GetAllPriceBookComics()
        {
            var comics = from book in ListOfBooks
                         where book.IsComics == true
                         select book;
         
            var newpricebook=from book in comics
                             where book.Price > 0
                             select book.Price;

            return newpricebook.ToList();
        }
        public IEnumerable<BookDetails> GetAllnamebppkforgirls9()
        { 
            var books = from book in ListOfBooks
                        where book.MinAge <= 0 && book.MaxAge >= 9
                        select book;
            var namebooks = from book in books
                             select book.Name;

            return namebooks.ToList();
        }


    }
}
