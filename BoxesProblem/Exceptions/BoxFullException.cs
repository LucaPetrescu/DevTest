public class BoxFullException : Exception
{
    public BoxFullException() { }

    public BoxFullException(string message) : base(message) { }

    public BoxFullException(string message, Exception innerException) : base(message, innerException) { }

}