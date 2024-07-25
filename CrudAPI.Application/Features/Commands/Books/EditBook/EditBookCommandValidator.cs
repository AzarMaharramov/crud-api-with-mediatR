using FluentValidation;

namespace CrudAPI.Application.Features.Commands.Books.EditBook
{
    public class EditBookCommandValidator : AbstractValidator<EditBookCommand>
    {
        public EditBookCommandValidator()
        {
            RuleFor(b => b.Request.Title).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(b => b.Request.Description).MaximumLength(250);
            RuleFor(b => b.Request.BookGenre).NotNull().NotEmpty();
        }
    }
}
