namespace X509plorer.Application.UseCases.Explore;

public record ExploreFileRequest(string FileName, byte[] Bytes);