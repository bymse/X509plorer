namespace X509plorer.Site.Models.Certificate;

public interface IType
{
    string ReadableName { get; }
    Uri? RfcReference { get; }
}

