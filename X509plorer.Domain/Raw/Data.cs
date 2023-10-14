using X509plorer.Domain.Helpers;

namespace X509plorer.Domain.Raw;

public class Data
{
    private readonly IBytesEncoder bytesEncoder;
    private byte[]? derEncoded;

    public Data(IBytesEncoder bytesEncoder)
    {
        this.bytesEncoder = bytesEncoder;
    }

    public ISource Source { get; private set; }

    public byte[] DerEncoded
    {
        get => derEncoded ?? throw new InvalidOperationException("Data was not initialized");
        private set => derEncoded = value;
    }

    public void FromFile(string fileName, byte[] bytes)
    {
        Source = new UploadedFileSource(fileName);
        DerEncoded = bytesEncoder.ToDerEncoding(bytes);
    }
}