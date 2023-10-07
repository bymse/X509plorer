using X509plorer.Domain.Certificates;
using X509plorer.Domain.Helpers.X509;
using X509plorer.Domain.Raw;

namespace X509plorer.Domain.Services;

public class DataToCertificateConverterService
{
    private readonly IX509RawParser x509RawParser;

    public DataToCertificateConverterService(IX509RawParser x509RawParser)
    {
        this.x509RawParser = x509RawParser;
    }

    public Certificate Convert(Data data)
    {
        var raw = x509RawParser.Parse(data);
        return new Certificate();
    }
}