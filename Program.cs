using csharp_oop_shop;

var prodotto1 = new Prodotto("Acqua", "Disseta molto", 10.99, 10);
var prodotto2 = new Prodotto("Aria", "Riempie i polmoni", 1.13, 22);

prodotto1.stampa();
prodotto2.stampa();

prodotto1.nome = "Acqua frizzante";
prodotto1.descrizione = "Disseta di più!";
prodotto1.prezzo = 15.99;
prodotto1.iva = 22;

prodotto1.stampa();

