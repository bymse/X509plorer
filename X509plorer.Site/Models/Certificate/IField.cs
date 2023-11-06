namespace X509plorer.Site.Models.Certificate;

public interface IField
{
    string Name { get; }
    IType Type { get; }
}

public interface IAttributeField : IField
{
    string ShortName { get; }
    string Value { get; }
}

public interface IPrimitiveValueField : IField
{
    string Value { get; }
}

public interface IAttributesCollectionField : IField
{
    IEnumerable<IAttributeField> Attributes { get; }
}