using Org.BouncyCastle.X509;
using X509plorer.Site.Models.Certificate.Raw;

namespace X509plorer.Site.Infrastructure.Raw;

public class BouncyCastleIx509RawParser : IX509RawParser
{
    private readonly BouncyCastleCertificateAdapter certificateAdapter;
    
    public BouncyCastleIx509RawParser()
    {
        certificateAdapter = new BouncyCastleCertificateAdapter();
    }
    
    public Models.Certificate.Raw.X509Raw Parse(byte[] bytes)
    {
        try
        {
            var certificate = new X509CertificateParser().ReadCertificate(bytes);
            return certificateAdapter.Adapt(certificate.CertificateStructure);
        }
        catch
        {
            return Models.Certificate.Raw.X509Raw.NotCertificate();
        }
    }
}