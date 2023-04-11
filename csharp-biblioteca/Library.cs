using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {
        public List<User> Users = new();
        public List<Document> Documents = new();
        public List<Lending> Lendings = new();

        //metodo per aggiungere utente 
        public void AddUser(User user)
        {
           Users.Add(user);
        }

        //metodo per aggiungere documento
        public void AddDocument(Document document)
        {
            Documents.Add(document);
        }

        //metodo per aggiungere un prestito alla lista
        public void AddLendings(Lending lending)
        {
            Lendings.Add(lending);
        }

        //metodo di ricerca documento
        public List<Document> SearchForCode(string codice)
        {
            List<Document> risultati = new();
            foreach (Document document in Documents)
            {
                if (document.Code == codice)
                {
                    risultati.Add(document);
                }
            }
            return risultati;
        }
    }
}
