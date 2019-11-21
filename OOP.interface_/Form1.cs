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
        
        //interface şablon üretir. bir nesne oluşturulduğunda interface'den implement edilir. projemize göre içeriğini biz dolduruyoruz.

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

            listBox1.Items.Add(kl);
            listBox1.Items.Add(fr);
    }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            #region ÖRN 1:
            //if (listBox1.SelectedItem is Kaleci)
            //{
            //    Kaleci kaleci = (Kaleci)listBox1.SelectedItem;
            //    foreach (var item in kaleci.GetType().GetProperties())
            //    {
            //        Label label = new Label();
            //        label.Text = $"{item.Name} : {item.GetValue(kaleci)}";
            //        label.Width = flowLayoutPanel1.Width;
            //        flowLayoutPanel1.Controls.Add(label);
            //    }
            //}
            //else if (listBox1.SelectedItem is Forvet)
            //{
            //    Forvet forvet = (Forvet)listBox1.SelectedItem;
            //    foreach (var item in forvet.GetType().GetProperties())
            //    {
            //        Label label = new Label();
            //        label.Text = $"{item.Name} : {item.GetValue(forvet)}";
            //        label.Width = flowLayoutPanel1.Width;
            //        flowLayoutPanel1.Controls.Add(label);
            //    }
            //}
            #endregion

            if (listBox1.SelectedItem.GetType().GetInterface("IFutbolcu") != null)
            {
                IFutbolcu futbolcu = (IFutbolcu)listBox1.SelectedItem; //cast ettik çünkü futbolcu obje olarak dönüyor ama                                                         listeboxa obje ekleyemeyyiz.

                foreach (var item in futbolcu.GetType().GetProperties())
                {
                    Label label = new Label();
                    label.Width = flowLayoutPanel1.Width;
                    label.Text = $"{item.Name} : {item.GetValue(futbolcu)}";

                    flowLayoutPanel1.Controls.Add(label);
                }
            }
        }
    }
}
