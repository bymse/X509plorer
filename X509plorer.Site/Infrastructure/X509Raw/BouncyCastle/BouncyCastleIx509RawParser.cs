using Org.BouncyCastle.X509;

namespace X509plorer.Site.Infrastructure.X509Raw.BouncyCastle;

public class BouncyCastleIx509RawParser : IX509RawParser
{
    private readonly BouncyCastleCertificateAdapter certificateAdapter;
    
    public BouncyCastleIx509RawParser()
    {
        certificateAdapter = new BouncyCastleCertificateAdapter();
    }
    
    public X509Raw Parse(byte[] bytes)
    {
        try
        {
            var certificate = new X509CertificateParser().ReadCertificate(bytes);
            return certificateAdapter.Adapt(certificate);
        }
        catch
        {
            return X509Raw.NotCertificate();
        }
    }
}