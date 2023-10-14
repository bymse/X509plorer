using X509plorer.Domain.Certificates;
using X509plorer.Domain.Helpers;
using X509plorer.Domain.Helpers.X509;
using X509plorer.Domain.Raw;

namespace X509plorer.Application.Handlers.Explore;

public class ExploreCertificateBytesHandler
{
    private readonly IBytesEncoder bytesEncoder;
    private readonly IX509RawParser x509RawParser;

    public ExploreCertificateBytesHandler(
        IBytesEncoder bytesEncoder,
        IX509RawParser x509RawParser
    )
    {
        this.bytesEncoder = bytesEncoder;
        this.x509RawParser = x509RawParser;
    }

    public Certificate Handle(ExploreCertificateFileModel model)
    {
        var data = new Data(bytesEncoder);
        data.FromFile(model.FileName, model.Bytes);

        var certificate = new Certificate(x509RawParser);
        certificate.FromData(data);

        return certificate;
    }
}