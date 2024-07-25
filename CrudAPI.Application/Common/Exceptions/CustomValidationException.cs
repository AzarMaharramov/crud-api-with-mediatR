using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Application.Common.Exceptions
{
    [Serializable]
    public class CustomValidationException : ValidationException
    {
        public CustomValidationException() : base("One or more validation failures have occurred.") { }
    }
}
