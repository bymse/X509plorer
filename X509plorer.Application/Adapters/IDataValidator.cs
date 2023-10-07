using X509plorer.Domain.Raw;

namespace X509plorer.Application.Adapters;

public interface IDataValidator
{
    bool IsCertificate(Data data);
}