using X509plorer.Application.Services;
using X509plorer.Domain.Certificates;

namespace X509plorer.Application.Handlers.Explore;

public class ExploreCertificateBytesHandler
{
    private readonly IX509RawParserService ix509RawParserService;

    public ExploreCertificateBytesHandler(
        IX509RawParserService ix509RawParserService
    )
    {
        this.ix509RawParserService = ix509RawParserService;
    }

    public Certificate Handle(ExploreCertificateBytesModel model)
    {
        var raw = ix509RawParserService.Parse(model.Bytes);
        return new Certificate(raw);
    }
}