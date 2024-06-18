using System.Collections.Immutable;

namespace Streckennetz.StatischeDaten;

static class Daten
{
    public static readonly ImmutableDictionary<int, Haltestelle> Haltestellen = ImmutableDictionary<int, Haltestelle>.Empty
        .Add(1, new Haltestelle(1, "Hauptbahnhof"))
        .Add(2, new Haltestelle(2, "Rathaus"))
        .Add(3, new Haltestelle(3, "Marktplatz"))
        .Add(4, new Haltestelle(4, "Osttor"))
        .Add(5, new Haltestelle(5, "Krankenhaus"))
        .Add(6, new Haltestelle(6, "Friedhof"))
        .Add(7, new Haltestelle(7, "Nordkreuz"))
        .Add(8, new Haltestelle(8, "Alte Oper"))
        .Add(9, new Haltestelle(9, "Industriegebiet Süd"))
        .Add(10, new Haltestelle(10, "Gewerbegebiet Nord"))
        .Add(11, new Haltestelle(11, "Wohngebiet"))
        .Add(12, new Haltestelle(12, "Schwimmbad"))
        .Add(13, new Haltestelle(13, "Einkaufszentrum"))
        .Add(14, new Haltestelle(14, "Vorstadt"))
        .Add(15, new Haltestelle(15, "Heinrichstraße"))
        .Add(16, new Haltestelle(16, "Stadtmusem"))
        .Add(17, new Haltestelle(17, "Ost-Bahnhof"))
        .Add(18, new Haltestelle(18, "Park"))
        .Add(19, new Haltestelle(19, "Tierpark"))
        .Add(20, new Haltestelle(20, "Lenastraße"))
        .Add(21, new Haltestelle(21, "Stadion"))
        .Add(22, new Haltestelle(22, "Marienkirche"))
        .Add(23, new Haltestelle(23, "Einkaufszentrum Nord"));

    public static readonly ImmutableList<Linie> Linien =
        ImmutableList<Linie>.Empty
            .Add(new Linie(1, "U1", ImmutableList<int>.Empty
                .Add(20)
                .Add(18)
                .Add(19)
                .Add(1)
                .Add(2)
                .Add(3)
                .Add(4)
                .Add(13)
                .Add(11)
                .Add(14)
                .Add(17)
            ))
            .Add(new Linie(2, "U2", ImmutableList<int>.Empty
                .Add(16)
                .Add(15)
                .Add(1)
                .Add(8)
                .Add(7)
                .Add(22)
                .Add(21)
            ))
            .Add(new Linie(3, "U3", ImmutableList<int>.Empty
                .Add(9)
                .Add(12)
                .Add(4)
                .Add(5)
                .Add(6)
                .Add(7)
                .Add(10)
                .Add(23)
            ));

}
