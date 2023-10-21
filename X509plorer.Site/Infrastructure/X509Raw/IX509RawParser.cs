namespace X509plorer.Site.Infrastructure.X509Raw;

public interface IX509RawParser
{
    X509Raw Parse(byte[] data);
}