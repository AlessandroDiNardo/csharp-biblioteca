
using csharp_biblioteca;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Registrazione
            Library biblioteca = new Library();

            //Console.WriteLine("Vuoi Creare ");
            //biblioteca.CreateUser();

            ////Creazione di un documento
            //biblioteca.CreateDocument();

            ////Creazione prestito
            //biblioteca.PrestitoDocumento();

            ////Ricerca prestito
            //biblioteca.RicercaPrestito();

            while (true)
            {
                int opzione;

                Console.WriteLine("Scegli una opzione: ");
                Console.WriteLine("1. Aggiungi un utente");
                Console.WriteLine("2. Aggiungi un documento");
                Console.WriteLine("3. Chiedi un prestito");
                Console.WriteLine("4. Cerca un prestito");
                Console.WriteLine("\n ------------------ \n");

                Console.Write("Inserisci opzione: ");
                if (!int.TryParse(Console.ReadLine(), out opzione))
                {
                    Console.WriteLine("Opzione non valida.");
                    continue;
                }

                switch (opzione)
                {
                    case 1:
                        biblioteca.CreateUser();
                        break;
                    case 2:
                        biblioteca.CreateDocument();
                        break;
                    case 3:
                        biblioteca.PrestitoDocumento();
                        break;
                    case 4:
                        biblioteca.RicercaPrestito();
                        break;
                }
            }


        }
    }
}