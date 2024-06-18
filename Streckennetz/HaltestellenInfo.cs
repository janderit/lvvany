namespace Streckennetz;

public sealed record HaltestellenInfo(int Id, string Bezeichnung, Tarifgebiet Tarifgebiet, IReadOnlyCollection<Linie> Linien);
