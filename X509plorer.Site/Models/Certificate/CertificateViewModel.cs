﻿namespace X509plorer.Site.Models.Certificate;

public class CertificateViewModel
{
    public Status Status { get; init; }
    
    public IField[] Fields { get; init; }
}