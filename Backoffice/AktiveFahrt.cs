using Streckennetz.Tarife;

namespace Backoffice;

public sealed record AktiveFahrt(
    Tarif Tarif,
    int? Starthaltestelle,
    DateTimeOffset Fahrtbeginn
);