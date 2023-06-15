public class WrongMaterialException : Exception
{
    public WrongMaterialException() { }

    public WrongMaterialException(string message) : base(message) { }

    public WrongMaterialException(string message, Exception innerException) : base(message, innerException) { }
}