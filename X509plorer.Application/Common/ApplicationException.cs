namespace X509plorer.Application.Common;

public class ApplicationException : Exception
{
    private readonly Reason reason;

    public ApplicationException(Reason reason)
    {
        this.reason = reason;
    }
}