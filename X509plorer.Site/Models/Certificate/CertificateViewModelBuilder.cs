using X509plorer.Site.Models.Certificate.Fields;
using X509plorer.Site.Models.Certificate.Raw;
using X509plorer.Site.Models.Certificate.Types;

namespace X509plorer.Site.Models.Certificate;

public class CertificateViewModelBuilder : ICertificateViewModelBuilder
{
    private readonly ICertificateFieldTypeProvider fieldTypeProvider;

    public CertificateViewModelBuilder(ICertificateFieldTypeProvider fieldTypeProvider)
    {
        this.fieldTypeProvider = fieldTypeProvider;
    }

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
            Status = Status.Certificate,
            Fields = new IField[]
            {
                GetPrimitiveField("version", raw.Version.ToString()),
                GetPrimitiveField("serialNumber", raw.SerialNumber),
            }
        };
    }

    private PrimitiveField GetPrimitiveField(string name, string value)
    {
        return new PrimitiveField(name, value, fieldTypeProvider.GetFieldType(name));
    }
}