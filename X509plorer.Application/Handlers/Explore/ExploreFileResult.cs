using X509plorer.Domain.Certificates;

namespace X509plorer.Application.Handlers.Explore;

public class ExploreFileResult
{
    private ExploreFileResult(Certificate? certificate)
    {
        Certificate = certificate;
    }

    public Certificate? Certificate { get; }
    
    public static ExploreFileResult NotACertificate() => new(null);
    public static ExploreFileResult Success(Certificate certificate) => new(certificate);
}