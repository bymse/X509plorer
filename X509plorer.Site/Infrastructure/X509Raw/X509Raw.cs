namespace X509plorer.Site.Infrastructure.X509Raw;

public class X509Raw
{
    public bool IsCertificate { get; }

    private X509Raw()
    {
        IsCertificate = false;
    }
    
    public static X509Raw NotCertificate() => new();
}