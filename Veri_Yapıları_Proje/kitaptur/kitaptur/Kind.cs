using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace kitaptur
{
    public class Kind:IKind<Book>
    {
        public string Name { get; set; }

        
        public SinglyLinkedList<Book> BooksSLL { get; set; } = new SinglyLinkedList<Book>();
        public Kind(string name) 
        { Name = name; }

        public Kind(string name, Book book) : this(name)
        {
            AddBook(book, BooksSLL);
        }
        public void AddBook(Book book,SinglyLinkedList<Book> sll)
        {
            if (sll.Find(book)!=-1)
            {
                throw new Exception("Bu kitap zaten listeye ekli");
            }
            else
            {
                sll.Add(book);
                Console.WriteLine("Kitap Eklendi");
            }
        }
        
        public Book RemoveBook(Book book,SinglyLinkedList<Book> sll)
        {
            if (sll.Find(book)==-1)
            {
                throw new Exception("Kitap bulunamadı");
            }
            else
            {
                sll.Remove(sll.Find(book));
                Console.WriteLine("Kitap kaldırıldı");
            }
            return book;
        }


        public void Print(string filename,SinglyLinkedList<Book> sll)
        {
            string Path= @"C:\Users\emira\Desktop\Veri_Yapıları_Proje\kitaptur\kitaptur\"+filename+".txt";
            
            FileStream fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write);

            int sayac = 1;
            string baslık = ($"{Name} Türündeki Kitaplar");
            Console.WriteLine(baslık);
            fs.Close();
            File.AppendAllText(Path, Environment.NewLine + baslık);
            Console.WriteLine("\n");
            foreach (var item in sll.GetEnumerator())
            {

                string kitaplar = ($"{sayac}){item.Name}-{item.Isbn}-{item.Yazar}");
                File.AppendAllText(Path, Environment.NewLine +kitaplar);
                Console.WriteLine(kitaplar);
                sayac++;
                fs.Close();

            }
            
            Console.WriteLine(  "\n");
        }
        
        

    }
}
