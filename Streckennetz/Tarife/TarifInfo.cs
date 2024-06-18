namespace Streckennetz.Tarife;

public sealed record TarifInfo(
    Tarif Tarif,
    string Bezeichnung,
    decimal Betrag,
    IReadOnlyCollection<Tarifgebiet> Tarifgebiete,
    int? Haltestellenbegrenzung,
    Gueltigkeitsdauer Gueltigkeitsdauer
);
