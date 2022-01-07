using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitaptur
{
    
    public class Book:IBook
    {
        public string Name { get; set; }
        public string Isbn { get; set; }
        public string Yazar { get; set; }
        public string Yayinevi { get; set; }
        public Book(string name,string isbn,string yazar,string yayin)
        {
            Isbn = isbn;
            Name = name;
            Yazar = yazar;
            Yayinevi = yayin;
        }
    }
}
