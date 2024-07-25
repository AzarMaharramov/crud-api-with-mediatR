using CrudAPI.Application.DTOs.Request.Books;
using CrudAPI.Application.Features.Commands.Books.AddBook;
using CrudAPI.Application.Features.Commands.Books.DeleteBook;
using CrudAPI.Application.Features.Commands.Books.EditBook;
using CrudAPI.Application.Features.Queries.Books.GetBook;
using CrudAPI.Application.Features.Queries.Books.GetBooks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BooksController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            GetBooksQuery query = new();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetBook([FromQuery] long id)
        {
            GetBookQuery query = new() { Id = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        
        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] AddBookReqDto request)
        {
            AddBookCommand command = new() { Request = request };
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> EditBook([FromBody] EditBookReqDto request)
        {
            EditBookCommand command = new() { Request = request };
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBook([FromQuery] long id)
        {
            DeleteBookCommand command = new() { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
