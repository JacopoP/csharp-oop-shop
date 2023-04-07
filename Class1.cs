using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        public int codice { get; init; }
        public string nome { get; set; }
        public string descrizione { get; set; }
        public double prezzo { get; set; }
        public int iva { get; set; }

        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            var rand = new Random();

            codice = rand.Next(1000, 9999);
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }
    }
}
