using X509plorer.Site.Models.Certificate;
using X509plorer.Site.Models.Certificate.Types;

namespace X509plorer.Site.Infrastructure.Types;

public class ConfigurationCertificateFieldTypeProvider : ICertificateFieldTypeProvider
{
    private readonly IConfiguration configuration;

    public ConfigurationCertificateFieldTypeProvider(IConfiguration configuration)
    {
        this.configuration = configuration.GetRequiredSection("CertificateFieldTypes");
    }

    public IType GetFieldType(string name)
    {
        return configuration.Get<ConfigurationFieldType>()
               ?? throw new InvalidOperationException($"No field type configuration found for field {name}");
    }
    
    private class ConfigurationFieldType : IType
    {
        public string Name { get; init; }
        public string Reference { get; init; }
        
        string IType.ReadableName => Name;
        Uri? IType.RfcReference => new Uri(Reference);
    }
}