using FluentValidation;

namespace CrudAPI.Application.Features.Commands.Books.DeleteBook
{
    public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
    {
        public DeleteBookCommandValidator()
        {
            RuleFor(b => b.Id).GreaterThan(0);
        }
    }

}
