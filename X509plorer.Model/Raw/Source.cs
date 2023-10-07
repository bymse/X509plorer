namespace X509plorer.Model.Raw;

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