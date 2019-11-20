using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.interface_
{
    public class Kaleci : IFutbolcu //miras işleminden sonra yanda bir ampul çıkacak. oradan implement interface seçeneğine tıkla. Gövde kısmı otomatik dolacak.
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string FormaNumarası { get; set; }
        public string Takim { get; set; }
        public string Mevki { get; set; }
        public bool MilliFutbolcu { get; set; }
        public byte Agresiflik { get; set; }
        public decimal Fiyati { get; set; }
        public byte TopHakimiyeti { get; set; }
        public byte ElleTopKontrolu { get; set; }

        public void SutCek()
        {
            throw new NotImplementedException();
        }
    }

    //Alt tuşuna basılı tutarak seçim yaptığında çoklu satırda seçim yapmış oluyorsun !!!

    public class Forvet : IFutbolcu
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string FormaNumarası { get; set; }
        public string Takim { get; set; }
        public string Mevki { get; set; }
        public bool MilliFutbolcu { get; set; }
        public byte Agresiflik { get; set; }
        public decimal Fiyati { get; set; }

        public byte TopHakimiyeti { get; set; }

        public void SutCek()
        {
            throw new NotImplementedException();
        }
    }
}
