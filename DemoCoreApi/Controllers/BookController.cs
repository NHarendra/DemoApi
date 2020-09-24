using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoCoreApi.Models;
using DemoCoreApi.RepositoryInterface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IRepository<Book> bookRepository;
        public BookController(IRepository<Book> bookRepository)
        { this.bookRepository = bookRepository; }

        [HttpGet]
        [Route("")]
        public IEnumerable<Book> GetAllBooks() => bookRepository.GetAll();

        [HttpGet]
        [Route("{bookId}")]
        public Book GetBookById(Guid bookId) => bookRepository.GetById(bookId);

        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public void AddBook([FromBody] Book book) => bookRepository.Insert(book);

        [HttpDelete]
        [Route("{bookId}")]
        [AllowAnonymous]
        public void DeleteBook(Guid bookId) => bookRepository.Delete(bookId);
    }
}
