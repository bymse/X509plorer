using Org.BouncyCastle.Asn1.X509;
using X509plorer.Site.Models.Certificate.Raw;

namespace X509plorer.Site.Infrastructure.Raw;

public class BouncyCastleCertificateAdapter
{
    public Models.Certificate.Raw.X509Raw Adapt(X509CertificateStructure certificate)
    {
        return new Models.Certificate.Raw.X509Raw
        {
            IsCertificate = true,
            Version = certificate.Version,
            SerialNumber = certificate.SerialNumber.ToString()!,
            Validity = new Validity
            {
                NotBefore = certificate.StartDate.ToDateTime(),
                NotAfter = certificate.EndDate.ToDateTime()
            },
        };
    }
}