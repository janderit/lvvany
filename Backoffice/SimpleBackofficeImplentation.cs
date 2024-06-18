using Streckennetz;
using Streckennetz.Tarife;

namespace Backoffice;

public sealed class SimpleBackofficeImplentation(StreckennetzUndTarifDatenbank streckennetzUndTarife) : Session
{
    private decimal _kontostand;
    private AktiveFahrt? _aktiveFahrt;

    public async Task<FahrtInfo?> AktiveFahrtInfo()
    {
        if (_aktiveFahrt == null) return null;

        var tarif = (await streckennetzUndTarife.Tarife()).Single(t => t.Tarif == _aktiveFahrt.Tarif);

        return new FahrtInfo(
            _aktiveFahrt.Fahrtbeginn,
            tarif.Bezeichnung
        );
    }

    public async Task FahrkarteKaufen(Tarif tarif, int? starthaltestelle)
    {
        if (_aktiveFahrt is not null)
        {
            throw new InvalidOperationException("Es läuft bereits eine Fahrt.");
        }

        var tarifinfo = (await streckennetzUndTarife.Tarife()).Single(t => t.Tarif == tarif);

        await Console.Out.WriteLineAsync($"Fahrkarte gekauft: {tarifinfo.Bezeichnung} für EUR {tarifinfo.Betrag:0.00}.");

        _kontostand -= tarifinfo.Betrag;
        _aktiveFahrt = new AktiveFahrt(tarif, starthaltestelle, DateTimeOffset.Now);
    }

    public Task<decimal> Kontostand()
    {
        return Task.FromResult(_kontostand);
    }
}
