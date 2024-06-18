using System.Collections.Immutable;
using Streckennetz.Tarife;

namespace Streckennetz;

public sealed class StreckennetzUndTarifDatenbank
{
    public Task<IReadOnlyCollection<TarifInfo>> Tarife()
        => Task.FromResult(Daten.Tarife);

    public Task<IReadOnlyCollection<LinienInfo>> Linien()
        => Task.FromResult((IReadOnlyCollection<LinienInfo>)StatischeDaten.Daten.Linien
            .Select(linie
                => new LinienInfo(
                    linie.Id,
                    linie.Name,
                    linie.Haltestellen.Select(haltestelle => StatischeDaten.Daten.Haltestellen[haltestelle]).ToImmutableList()))
            .ToImmutableList());

    public Task<IReadOnlyCollection<HaltestellenInfo>> Haltestellen()
        => Task.FromResult((IReadOnlyCollection<HaltestellenInfo>)StatischeDaten.Daten.Haltestellen.Values.Select(haltestelle => new HaltestellenInfo(
            haltestelle.Id,
            haltestelle.Bezeichnung,
            haltestelle.Id < 9 ? Tarifgebiet.Innenstadt : Tarifgebiet.Aussenbereich,
            StatischeDaten.Daten.Linien.Where(l => l.Haltestellen.Contains(haltestelle.Id)).ToImmutableList()
        )));
}
