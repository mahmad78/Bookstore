using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return Datasource();
        }

        public BookModel GetBookById(int Id)
        {
            return Datasource().Where(b => b.Id == Id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return Datasource().Where(x => x.Title == title && x.Author == author).ToList();
        }

        private  List<BookModel> Datasource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id=1, Title="MVC", Author="Nitsh"},
                new BookModel(){ Id=2, Title="CSharpt", Author="xyz"}
            };
        }
    }
}
