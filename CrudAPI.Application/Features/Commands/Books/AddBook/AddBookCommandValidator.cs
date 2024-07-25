using FluentValidation;

namespace CrudAPI.Application.Features.Commands.Books.AddBook
{
    public class AddBookCommandValidator : AbstractValidator<AddBookCommand>
    {
        public AddBookCommandValidator()
        {
            RuleFor(b => b.Request.Title).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(b => b.Request.Description).MaximumLength(250);
            RuleFor(b => b.Request.BookGenre).NotNull().NotEmpty();
        }
    }
}
