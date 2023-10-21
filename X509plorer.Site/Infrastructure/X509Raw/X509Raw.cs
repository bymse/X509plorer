namespace X509plorer.Site.Infrastructure.X509Raw;

public class X509Raw
{
    public bool IsCertificate { get; init; }
    
    public static X509Raw NotCertificate() => new()
    {
        IsCertificate = false
    };
}