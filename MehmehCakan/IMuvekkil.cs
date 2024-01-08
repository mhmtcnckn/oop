using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmehCakan
{
    interface IMuvekkil
    {
        int MuvekkilId { get; set; }
        string AdSoyad { get; set; }
        DateTime DogumTarihi { get; set; }
        string Adres { get; set; }
    }
}
