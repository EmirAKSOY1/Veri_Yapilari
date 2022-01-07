using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
namespace kitaptur
{
    class Program
    {
        static void Main(string[] args)
        {

            SinglyLinkedList<Book> Books = new SinglyLinkedList<Book>();

            Kind kindaksiyon = new Kind("Aksiyon");
            kindaksiyon.AddBook(new Book("Börü", "9789752444577", "Çağlayan Yılmaz","Panama Yayıncılık"), kindaksiyon.BooksSLL);
            kindaksiyon.AddBook(new Book("Harry Potter ve Felsefe Taşı", "9789750802942", "J. K. Rowling", "Yapı Kredi Yayınları"), kindaksiyon.BooksSLL);
            kindaksiyon.Print("aksiyonkitaplar",kindaksiyon.BooksSLL);
            
            

            Kind kindkorku = new Kind("Korku");
            kindkorku.AddBook(new Book ("Şeytanın Eli", "9786052064795", "McMahon ", "Ephesus Yayınları"), kindkorku.BooksSLL);
            kindkorku.AddBook(new Book("Ucubeler", "9786050949643", "Tess GERRITSEN ", "Doğan Kİtap"), kindkorku.BooksSLL);
            kindkorku.Print("korkukitaplar", kindkorku.BooksSLL);

            Kind kindtarih = new Kind("Tarih");
            kindtarih.AddBook(new Book("Kavgam", "9786059725347", "Adolf Hİtler","GirdaP Kitap"), kindtarih.BooksSLL);
            kindtarih.AddBook(new Book("Son Cüret ", "9786254440489", "Yılmaz Özdil","SİA Kitap"), kindtarih.BooksSLL);
            kindtarih.Print("tarih kitaplar", kindtarih.BooksSLL);

            Kind kindklasik = new Kind("Dünya Klasikleri");
            kindklasik.AddBook(new Book("Ütopya", "9786050816600", "Thomas More", "Timaş Yayınları"), kindklasik.BooksSLL);
            kindklasik.AddBook(new Book("Sefiller", "9786057795533", "Victor Hugo", "Koloni"), kindklasik.BooksSLL);
            kindklasik.Print("dünyaklasiklerikitaplar", kindklasik.BooksSLL);
            foreach (var item in Books.GetEnumerator())
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
            

        }
    }
}
