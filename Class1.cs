using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        public int codice { get; private init; }
        public string nome { get; set; }
        public string descrizione { get; set; }
        public double prezzo { get; set; }
        public int iva { get; set; }

        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            var rand = new Random();

            codice = rand.Next(0, 99999999);
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = Math.Round(prezzo, 2);
            this.iva = iva;
        }

        public double taxedPrice()
        {
            return Math.Round(prezzo * (100 + iva) / 100, 2);
        }

        public string fullName()
        {
            return padCodice() + " " + nome;
        }

        public void stampa()
        {
            Console.WriteLine(fullName());
            Console.WriteLine(descrizione);
            Console.WriteLine("$" + taxedPrice());
            Console.WriteLine("Prezzo originale: $" + prezzo);
        }

        public string padCodice()
        {
            string stringCode = codice.ToString();
            int zerosToAdd = 8 - stringCode.Length;
            for (int i = 0; i < zerosToAdd; i++)
                stringCode = "0" + stringCode;
            return stringCode;
        }
    }
}
