using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitaptur
{
    interface IBook
    {
        string Name { get; set; }
        string Isbn { get; set; }
        string Yazar { get; set; }
        string Yayinevi { get; set; }
    }
}
