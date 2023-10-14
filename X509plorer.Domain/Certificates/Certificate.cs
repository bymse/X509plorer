using X509plorer.Domain.Helpers.X509;
using X509plorer.Domain.Raw;

namespace X509plorer.Domain.Certificates;

public class Certificate
{
    private readonly IX509RawParser parser;

    public Certificate(IX509RawParser parser)
    {
        this.parser = parser;
    }
    
    public bool IsCertificate { get; private set; }
    
    public void FromData(Data data)
    {
        var raw = parser.Parse(data);
        IsCertificate = raw.IsCertificate;
        if (!IsCertificate)
        {
            return;
        }
    }
}