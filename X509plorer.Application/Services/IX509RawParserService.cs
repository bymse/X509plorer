using X509plorer.Domain.Helpers.X509;

namespace X509plorer.Application.Services;

public interface IX509RawParserService
{
    IX509Raw Parse(byte[] bytes);
}