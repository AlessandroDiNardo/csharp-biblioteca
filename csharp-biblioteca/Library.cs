using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {
        private List<Documenti> documents = new List<Documenti>();

        public Library() 
        {
            AddDocument();
        }

        private void AddDocument()
        {
            //DvD gia esistenti
            Dvd dvd1 = new Dvd("D01A", "Iron Man", "2005", "Azione", "D1", "Marvel", "1:45:00");
            Dvd dvd2 = new Dvd("D02B", "Inception", "2010", "Fantascienza", "D2", "Christopher Nolan", "2:28:00");
            Dvd dvd3 = new Dvd("D03C", "Pirati dei Caraibi: La Maledizione del forziere fantasma", "2006", "Avventura", "D3", "Gore Verbinski", "2:31:00");
            Dvd dvd4 = new Dvd("D04D", "The Avengers", "2012", "Azione", "D4", "Marvel", "2:23:00");
            Dvd dvd5 = new Dvd("D02B", "Jurassic Park", "1993", "Fantascienza", "B", "Steven Spielberg", "2:06:00");


            //Libri gia esistenti
            Libri libro1 = new Libri("L01B", "Il signore degli anelli", "1954", "Fantasy", "B", "J.R.R. Tolkien", "1216");
            Libri libro2 = new Libri("L02C", "Il nome della rosa", "1980", "Giallo", "C", "Umberto Eco", "536");
            Libri libro3 = new Libri("L03A", "La solitudine dei numeri primi", "2008", "Drammatico", "A", "Paolo Giordano", "296");
            Libri libro4 = new Libri("L04B", "Le città invisibili", "1972", "Romanzo", "B", "Italo Calvino", "165");
            Libri libro5 = new Libri("L05C", "L'isola del giorno prima", "1994", "Romanzo", "C", "Umberto Eco", "360");

            documents.Add(dvd1);
            documents.Add(dvd2);
            documents.Add(dvd3);
            documents.Add(dvd4);
            documents.Add(dvd5);
            documents.Add(libro1);
            documents.Add(libro2);
            documents.Add(libro3);
            documents.Add(libro4);
            documents.Add(libro5);
        }

        private List<User> Utenti = new List<User>();

        private List<Lending> Prestiti = new List<Lending>();

        //Registrazione
        public User CreateUser()
        {
            Console.Write("Registrati!");

            //Cognome
            Console.Write("Inserisci il tuo nome: ");
            string nome = Console.ReadLine();

            //Nome
            Console.Write("Inserisci il tuo cognome: ");
            string cognome = Console.ReadLine();


            //Cognome
            Console.Write("Inserisci il tuo email: ");
            string email = Console.ReadLine();

            //Password
            Console.Write("Inserisci la tua password: ");
            string password = Console.ReadLine();

            //Telefono
            Console.Write("Inserisci il tuo numero di telefono: ");
            string telefono = Console.ReadLine();

            User nuovoUtente = new User(nome, cognome, email, password, telefono);

            Console.WriteLine($"Cognome: {nuovoUtente.Name} \n " +
                    $"Nome: {nuovoUtente.Surname} \n " +
                    $"Email: {nuovoUtente.Email} \n " +
                    $"Password: {nuovoUtente.Password} \n " +
                    $"Telefono: {nuovoUtente.PhoneNumber}"
                    );

            Utenti.Add(nuovoUtente);

            return nuovoUtente;
        }

        //Crea documento
        public void CreateDocument()
        {
            Console.WriteLine();
            Console.WriteLine("Vuoi aggiungere un DVD o un libro nuovo?");
            string risposta = Console.ReadLine();
            risposta = risposta.ToLower();

            if (risposta == "si")
            {
                Console.Write("Codice: ");
                string codice = Console.ReadLine();

                Console.Write("Titolo: ");
                string titolo = Console.ReadLine();

                Console.Write("Anno di pubblicazione: ");
                string anno = Console.ReadLine();

                Console.Write("Settore: ");
                string settore = Console.ReadLine();

                Console.Write("Scaffale: ");
                string scaffale = Console.ReadLine();

                Console.Write("Autore: ");
                string autore = Console.ReadLine();

                Console.Write("Tipo di documento (dvd/libro): ");
                string tipo = Console.ReadLine();
                tipo = tipo.ToLower();

                if (tipo == "dvd")
                {
                    Console.Write("Durata: ");
                    string durata = Console.ReadLine();
                    Documenti nuovoDocumento = new Dvd(codice, titolo, anno, settore, scaffale, autore, durata);
                    documents.Add(nuovoDocumento);
                }
                else if (tipo == "libro")
                {
                    Console.Write("Numero di pagine: ");
                    string pagine = Console.ReadLine();
                    Documenti nuovoDocumento = new Libri(codice, titolo, anno, settore, scaffale, autore, pagine);
                    documents.Add(nuovoDocumento);
                }

                Console.WriteLine("Grazie arrivederci!");
            }
            else
            {
                Console.WriteLine("Grazie Arrivederci!");
            }


        }

        //Crea prestito
        public void PrestitoDocumento()
        {
            Console.WriteLine("Vuoi cercare tramite codice o titolo?");
            string ricerca = Console.ReadLine();
            ricerca = ricerca.ToLower();

            if (ricerca == "codice")
            {
                Console.WriteLine("Inserisci il codice");
                string codiceRicerca = Console.ReadLine();
                documents.FindAll(Documenti => Documenti.Codice == codiceRicerca);

                if (documents.Find(doc => doc.Codice == codiceRicerca) != null)
                {
                    Console.Write("Inserisci il nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Inserisci il cognome: ");
                    string cognome = Console.ReadLine();

                    Console.WriteLine("Prestito eseguito correttamente");


                }
                else
                {
                    Console.WriteLine("Documento non trovato!");
                }


            }

            if (ricerca == "titolo")
            {
                Console.WriteLine("Inserisci il titolo");
                string titoloRicerca = Console.ReadLine();
                documents.FindAll(Documenti => Documenti.Titolo == titoloRicerca);

                if (documents.Find(doc => doc.Titolo == titoloRicerca) != null)
                {
                    Console.WriteLine("Prestito eseguito correttamente");

                }
                else
                {
                    Console.WriteLine("Documento non trovato!");
                }
            }

        }

        //Ricerca Prestito
        public void RicercaPrestito()
        {
            Console.Write("Inserisci il nome dell'utente da cercare: ");
            string nomeDaCercare = Console.ReadLine();

            Console.Write("Inserisci il cognome dell'utente da cercare: ");
            string cognomeDaCercare = Console.ReadLine();

            foreach (User utente in Utenti)
            {
                if (utente.Name == nomeDaCercare && utente.Surname == cognomeDaCercare)
                {
                    Console.WriteLine("Utente trovato!");

                    Console.WriteLine("Nome: " + utente.Name);
                    Console.WriteLine("Cognome: " + utente.Surname);
                    Console.WriteLine("Email: " + utente.Email);
                    Console.WriteLine("Telefono: " + utente.PhoneNumber);

                }

            }

        }
    }
}
