using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.interface_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Forvet fr = new Forvet()
        {
            Adi = "Sabri",
            Soyadi = "Sarıoğlu",
            FormaNumarası = "1",
            Agresiflik = 100,
            Takim = "GS",
            MilliFutbolcu = true,
            Fiyati = 0,
            Mevki = "ara eleman",
            TopHakimiyeti = 0
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            Kaleci kl = new Kaleci()
            {
                Adi = "Tafarel",
                Soyadi = "Tefal",
                FormaNumarası = "1",
                Agresiflik = 30,
                Takim = "GS",
                MilliFutbolcu = false,
                Fiyati = 100000000000000,
                Mevki = "Kale",
                TopHakimiyeti = 60,
                ElleTopKontrolu = 100
            };
    }

        //interface şablon üretir. bir nesne oluşturulduğunda interface'den implement edilir. projemize göre içeriğini biz dolduruyoruz.
    }
}
