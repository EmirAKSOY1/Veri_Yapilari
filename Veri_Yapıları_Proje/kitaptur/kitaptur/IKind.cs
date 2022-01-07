using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitaptur
{
    interface IKind<T>
    {
        string Name { get; set; }
        void AddBook(Book book,SinglyLinkedList<T> sll);
        void Print(string filename,SinglyLinkedList<T> sll);


    }
}
