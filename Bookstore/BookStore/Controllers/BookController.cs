using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult GetAllbooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }

        //public ViewResult GetBook(int Id)
        //{
        //    var oBook = new BookModel { Id=5, Title="Vb", Author="Saif" };
        //    return_bookRepository.GetBookById(Id);
        //}

        public List<BookModel> SearchBooks(string title, string author)
        {
            return _bookRepository.SearchBook(title,author);
        }
    }
}
