using FluentValidation;

namespace CrudAPI.Application.Features.Queries.Books.GetBook
{
    public class GetBookQueryValidator : AbstractValidator<GetBookQuery>
    {
        public GetBookQueryValidator()
        {
            RuleFor(b => b.Id).GreaterThan(0);
        }
    }

}
