namespace X509plorer.Model.Helpers;

public interface IBytesEncoder
{
    byte[] ToDerEncoding(byte[] bytes);
}