using X509plorer.Site.Infrastructure.X509Raw;

namespace X509plorer.Site.Models.Certificate;

public class CertificateViewModelBuilder : ICertificateViewModelBuilder
{
    public CertificateViewModel Build(X509Raw raw)
    {
        if (!raw.IsCertificate)
        {
            return new CertificateViewModel
            {
                Status = Status.NotCertificate
            };
        }

        return new CertificateViewModel
        {
            Status = Status.Certificate
        };
    }
}