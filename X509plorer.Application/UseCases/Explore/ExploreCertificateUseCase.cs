using X509plorer.Application.Adapters;
using X509plorer.Application.Common;
using X509plorer.Domain.Certificates;
using X509plorer.Domain.Helpers;
using X509plorer.Domain.Raw;
using X509plorer.Domain.Services;
using ApplicationException = X509plorer.Application.Common.ApplicationException;

namespace X509plorer.Application.UseCases.Explore;

public class ExploreCertificateUseCase
{
    private readonly IBytesEncoder bytesEncoder;
    private readonly IDataValidator dataValidator;
    private readonly DataToCertificateConverterService dataToCertificateConverterService;

    public ExploreCertificateUseCase(
        IBytesEncoder bytesEncoder,
        IDataValidator dataValidator,
        DataToCertificateConverterService dataToCertificateConverterService
    )
    {
        this.bytesEncoder = bytesEncoder;
        this.dataValidator = dataValidator;
        this.dataToCertificateConverterService = dataToCertificateConverterService;
    }

    public Certificate ExploreFile(ExploreFileRequest request)
    {
        var data = new Data(bytesEncoder);
        data.FromUploadedFile(request.FileName, request.Bytes);

        if (!dataValidator.IsCertificate(data))
        {
            throw new ApplicationException(Reason.NotACertificate);
        }

        return dataToCertificateConverterService.Convert(data);
    }
}