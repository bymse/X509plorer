namespace X509plorer.Site.Models.Certificate.Raw;

public interface IX509RawParser
{
    X509Raw Parse(byte[] data);
}