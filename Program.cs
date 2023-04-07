using csharp_oop_shop;

Prodotto[] prodotti = new Prodotto[]
{
new Prodotto("Acqua", "Disseta molto", 10.99, 10),
new Prodotto("Aria", "Riempie i polmoni", 1.13, 22),
new Prodotto("Humus", "Concima", 5.65, 22),
new Prodotto("Diamanti", "Svuotano i portafigli", 9999.99, 22),
new Prodotto("Pane", "Appena sfornato", 0.99, 4),
new Prodotto("Libro Bello", "Nutre la mente", 16.50, 22),
new Prodotto("Computer", "Fa calcoli", 1000.00, 22),
};

foreach (var prodotto in prodotti)
{
    prodotto.stampa();
    Console.Write("\n");
}

Console.WriteLine("Fine elenco");

prodotti[0].nome = "Acqua frizzante";
prodotti[0].descrizione = "Disseta di più!";
prodotti[0].prezzo = 15.99;
prodotti[0].iva = 22;

Console.WriteLine("\n Prodotto modificato:");
prodotti[0].stampa();

