using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoFixture;
using Books.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Books.WebApi.Controllers.v1
{
    [Route("v1/books")]
    public class BooksController : BaseController
    {
        private readonly Fixture _fixture;

        public BooksController()
        {
            _fixture = new Fixture();
        }

        /// <summary>
        /// Get list of books
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<BookViewModel>> GetByToken()
        {
            var result = _fixture.CreateMany<BookViewModel>().ToList();

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Get a book by ID
        /// </summary>
        /// <param name="id">Book ID</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<BookViewModel> GetById(Guid id)
        {
            var result = _fixture.Create<BookViewModel>();

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Create a book
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        public async Task<Guid> Create(BookViewModel book)
        {
            var result = _fixture.Create<Guid>();

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Update a book
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("")]
        public async Task Update(BookViewModel book)
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// Delete a book by ID
        /// </summary>
        /// <param name="id">Book ID</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public async Task Delete(Guid id)
        {
            await Task.CompletedTask;
        }
    }
}
