namespace X509plorer.Domain.Raw;

public interface ISource
{
}

public class UploadedFileSource : ISource
{
    public UploadedFileSource(string fileName)
    {
        FileName = fileName;
    }

    public string FileName { get; }
}