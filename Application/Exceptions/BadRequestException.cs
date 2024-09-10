using FluentValidation.Results;

namespace Application.Exceptions;

public class BadRequestException : Exception
{
    public List<string>? Errors { get; set; }

    public BadRequestException(string message) : base(message)
    {
        
    }
    public BadRequestException(string message, ValidationResult validationResult) : base(message)
    {
        Errors = [];
        foreach (var error in validationResult.Errors)
        {
            Errors.Add(error.ToString());
        }
    }
}