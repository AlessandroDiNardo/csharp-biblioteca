using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documenti
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public string Anno { get; set; }
        public string Settore { get; set; }
        public string Scaffale { get; set; }
        public string Autore { get; set; }

        public Documenti(string codice, string titolo, string anno, string settore, string scaffale, string autore)
        {
            Codice = codice;
            Titolo = titolo;
            Anno = anno;
            Settore = settore;
            Scaffale = scaffale;
            Autore = autore;
        }
    }

    internal class Dvd : Documenti
    {
        public string Durata { get; set; }

        public Dvd(string codice, string titolo, string anno, string settore, string scaffale, string autore, string durata) : base(codice, titolo, anno, settore, scaffale, autore)
        {
            Durata = durata;
        }
    }

    internal class Libri : Documenti
    {
        public string Pagine { get; set; }

        public Libri(string codice, string titolo, string anno, string settore, string scaffale, string autore, string pagine) : base(codice, titolo, anno, settore, scaffale, autore)
        {
            Pagine = pagine;
        }
    }
}
