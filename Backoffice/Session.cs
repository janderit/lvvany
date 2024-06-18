using Streckennetz.Tarife;

namespace Backoffice;

public interface Session
{
    public Task<FahrtInfo?> AktiveFahrtInfo();
    Task FahrkarteKaufen(Tarif tarif, int? starthaltestelle);

    Task<decimal> Kontostand();
}