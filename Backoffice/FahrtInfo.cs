namespace Backoffice;

public sealed record FahrtInfo(
    DateTimeOffset Fahrtbeginn,
    string TarifName
);
