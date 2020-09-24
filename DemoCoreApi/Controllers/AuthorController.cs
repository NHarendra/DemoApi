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
    public class AuthorController : ControllerBase
    {
        private IRepository<Author> authorRepository;
        public AuthorController(IRepository<Author> authorRepository)
        { this.authorRepository = authorRepository; }

        [HttpGet]
        [Route("")]
        public IEnumerable<Author> GetAllAuthors() => authorRepository.GetAll();

        [HttpGet]
        [Route("{authorId}")]
        public Author GetAuthorById(Guid authorId) => authorRepository.GetById(authorId);

        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public void AddAuthor([FromBody] Author author) => authorRepository.Insert(author);

        [HttpDelete]
        [Route("{authorId}")]
        [AllowAnonymous]
        public void DeleteAuthor(Guid authorId) => authorRepository.Delete(authorId);
    }
}
