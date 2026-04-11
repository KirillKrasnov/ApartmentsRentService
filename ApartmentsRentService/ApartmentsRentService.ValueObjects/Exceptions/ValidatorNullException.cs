namespace ApartmentsRentService.ValueObjects.Exceptions;

public sealed class ValidatorNullException : ArgumentNullException
{
    public ValidatorNullException(string paramName) 
        : base(paramName, "Валидатор не может быть пустым")
    {

    }
   
} 
