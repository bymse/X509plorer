using X509plorer.Domain.Helpers.X509;

namespace X509plorer.Domain.Certificates;

public class Certificate
{
    public Certificate(IX509Raw x509Raw)
    {
        IsCertificate = x509Raw.IsCertificate;
        if (!IsCertificate)
        {
            return;
        }
    }
    
    public bool IsCertificate { get; private set; }
}