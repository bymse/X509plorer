namespace X509plorer.Site.Models.Certificate.Fields;

public class PrimitiveField : IPrimitiveValueField
{
    public PrimitiveField(string name, string value, IType type)
    {
        Name = name;
        Type = type;
        Value = value;
    }

    public string Name { get; }
    public IType Type { get; }
    public string Value { get; }
}