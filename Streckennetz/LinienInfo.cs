namespace Streckennetz;

public sealed record LinienInfo(int Id, string Name, IReadOnlyCollection<Haltestelle> Haltestellen);