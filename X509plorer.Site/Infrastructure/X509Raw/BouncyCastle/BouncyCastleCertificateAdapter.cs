
using Org.BouncyCastle.X509;

namespace X509plorer.Site.Infrastructure.X509Raw.BouncyCastle;

public class BouncyCastleCertificateAdapter
{
    public X509Raw Adapt(X509Certificate certificate)
    {
        return new X509Raw
        {
            IsCertificate = false
        };
    }
}