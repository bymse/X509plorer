using X509plorer.Site.Infrastructure.X509Raw;
using X509plorer.Site.Models.Certificate.Raw;

namespace X509plorer.Site.Models.Certificate;

public class CertificateFormHandler
{
    private readonly IX509RawParser x509RawParser;
    private readonly ICertificateViewModelBuilder certificateViewModelBuilder;

    public CertificateFormHandler(IX509RawParser x509RawParser,
        ICertificateViewModelBuilder certificateViewModelBuilder)
    {
        this.x509RawParser = x509RawParser;
        this.certificateViewModelBuilder = certificateViewModelBuilder;
    }

    public CertificateViewModel Handle(IFormFile file)
    {
        var x509Raw = GetX509Raw(file);
        return certificateViewModelBuilder.Build(x509Raw);
    }

    private X509Raw GetX509Raw(IFormFile file)
    {
        using var stream = file.OpenReadStream();
        var bytes = new byte[file.Length];
        var read = stream.Read(bytes, 0, bytes.Length);
        if (read != bytes.Length)
        {
            throw new Exception("Could not read the entire file");
        }

        return x509RawParser.Parse(bytes);
    }
}