﻿using X509plorer.Site.Infrastructure.X509Raw;
using X509plorer.Site.Models.Certificate.Raw;

namespace X509plorer.Site.Models.Certificate;

public interface ICertificateViewModelBuilder
{
    CertificateViewModel Build(X509Raw raw);
}