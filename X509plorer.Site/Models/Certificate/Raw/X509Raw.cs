namespace X509plorer.Site.Models.Certificate.Raw;

public class X509Raw
{
    public bool IsCertificate { get; init; }
    public int Version { get; init; }
    public string SerialNumber { get; init; } = string.Empty;
    public Validity Validity { get; init; } = new();
    
    public static X509Raw NotCertificate() => new()
    {
        IsCertificate = false
    };
}