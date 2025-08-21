using FluentValidation.Results;

public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    {
        ValidationErrors = new List<string>();
    }

    public BadRequestException(string message, ValidationResult validationResult) : base(message)
    {
        ValidationErrors = new();
        foreach (var error in validationResult.Errors)
        {
            ValidationErrors.Add(error.ErrorMessage);
        }
    }

    public List<string> ValidationErrors { get; set; }
}