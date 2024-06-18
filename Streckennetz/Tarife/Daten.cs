namespace Streckennetz.Tarife;

static class Daten
{
    public static IReadOnlyCollection<TarifInfo> Tarife = new[]
    {
        new TarifInfo(Tarif.EinzelfahrtKurzstrecke, "Einzelfahrt Kurzstrecke", 1.00m, [], 1, Gueltigkeitsdauer.Fuer30Minuten),
        new TarifInfo(Tarif.EinzelfahrtNahbereich, "Einzelfahrt Nahbereich", 2.00m, [Tarifgebiet.Innenstadt], 2, Gueltigkeitsdauer.Fuer2Stunden),
        new TarifInfo(Tarif.EinzelfahrtGesamtnetz, "Einzelfahrt Gesamtnetz", 3.00m, [Tarifgebiet.Aussenbereich, Tarifgebiet.Innenstadt], null, Gueltigkeitsdauer.Fuer2Stunden),
        new TarifInfo(Tarif.TageskarteNahbereich, "Tageskarte Nahbereich", 4.00m, [Tarifgebiet.Innenstadt], null, Gueltigkeitsdauer.BisBetriebsschluss),
        new TarifInfo(Tarif.TageskarteGesamtnetz, "Tageskarte Gesamtnetz", 5.00m, [Tarifgebiet.Aussenbereich, Tarifgebiet.Innenstadt], null, Gueltigkeitsdauer.BisBetriebsschluss),
    };
}
