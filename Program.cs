using csharp_oop_shop;

var prodotto1 = new Prodotto("Acqua", "Disseta molto", 10.99, 10);
var prodotto2 = new Prodotto("Aria", "Riempie i polmoni", 1.13, 22);

stampaProdotto(prodotto1);
stampaProdotto(prodotto2);

void stampaProdotto(Prodotto p)
{
    Console.WriteLine(p.fullName());
    Console.WriteLine(p.descrizione);
    Console.WriteLine("$" + p.taxedPrice());
    Console.WriteLine("Prezzo originale: $" + p.prezzo);
}