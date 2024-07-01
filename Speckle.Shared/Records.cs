namespace Speckle.Shared;


public record ExcludedType(string Name, ExcludedMember[] ExcludedMembers);
public record ExcludedMember(string Name);
public record GeneratedMember(string Name);
public record GeneratedParameter(Type param, string Name);
public record GeneratedConstructor(List<GeneratedParameter> Parameters);
public record GeneratedTypeInfo(string Name, string? Base, List<GeneratedConstructor> Constructors, List<GeneratedMember> Members);

public enum GeneratedType
{
  Class,
  Struct,
  Interface
}
