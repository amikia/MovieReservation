namespace MovieReservation.Shared.Exceptions;

public class CustomException : Exception
{
    public CustomException() : base()
    {
    }
    public CustomException(string message) : base(message)
    {
    }
    public CustomException(string message, params object[] args) : base(String.Format(message, args))
    {
    }
}