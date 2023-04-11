using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Document
    {
        public int Duration { get; set; }

        public Dvd( string code, string title, int year, string genre, int duration, string author, int shelf) : base(code, title, year, genre, author, shelf)  
        { 
            Duration = duration;
        }
    }
}
