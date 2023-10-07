namespace X509plorer.Domain.Helpers;

public interface IBytesEncoder
{
    byte[] ToDerEncoding(byte[] bytes);
}