namespace Streckennetz;

public sealed record Linie(int Id, string Name, IReadOnlyCollection<int> Haltestellen);