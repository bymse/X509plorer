namespace X509plorer.Site.Models.Certificate.Types;

public interface ICertificateFieldTypeProvider
{
    IType GetFieldType(string name);
}