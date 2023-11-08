namespace shortner.Api.ExceptionHelper;

public class DataBaseException : ApplicationException
{
    public DataBaseException() : base(ErrorTypes.DataBaseException.ToString())
    {
    }
}

public class NotFoundException : ApplicationException
{
    public NotFoundException() : base(ErrorTypes.NotFoundeException.ToString())
    {
    }
}