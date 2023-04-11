using System.Security.Cryptography.X509Certificates;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creazione istanza biblioteca
            Library library = new Library();

            //aggiunta utenti alla lista  utenti
            library.AddUser( new User("Alessandro", "Di Nardo", "dna@gmail.com", "password12345", "+39 3335467898"));
            library.AddUser(new User("Giovanni", "Rossi", "rossi@gmail.com", "password12345", "+39 3333456787"));

            //aggiunta documenti alla lista documenti
            library.AddDocument(new Book(760, "BK123243", "Harry Potter e la pietra filosofale", 2002, "fantasy", "J.K. Rowling", 12));
            library.AddDocument(new Dvd(120, "DV123454", "Harry Potter e il principe mezzosangue", 2009, "fantasy", "J.K. Rowling", 34));

            //esempio di ricerca documenti della lista documenti
            string codeDoc = "Harry Potter e la pietra filosofale";
            Console.WriteLine($"Risultati della ricerca per codice: {codeDoc}");
            foreach( Document doc in library.SearchForTitle(codeDoc))
            {
                Console.WriteLine($"{doc.Title} ({doc.Year}) di {doc.Author}");
            }
        }
    }
}