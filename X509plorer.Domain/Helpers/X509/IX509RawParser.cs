using X509plorer.Domain.Raw;

namespace X509plorer.Domain.Helpers.X509;

public interface IX509RawParser
{
    IX509Raw Parse(Data data);
}