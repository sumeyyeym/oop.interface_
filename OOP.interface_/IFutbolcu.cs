using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.interface_
{
    public interface IFutbolcu
    {
        string Adi { get; set; }
        string Soyadi { get; set; }
        string FormaNumarası { get; set; }
        string Takim { get; set; }
        string Mevki { get; set; }
        bool MilliFutbolcu { get; set; }
        byte Agresiflik { get; set; }
        decimal Fiyati { get; set; }
        byte TopHakimiyeti { get; set; }
        void SutCek();

        //public kullanımı yok, voidlerde gövde yani {} yok. bunların hepsi, oluşturulacak projede şekilleneceğinden buradan yerleştirmeye gerek yok.
    }
}
