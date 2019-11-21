using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.interface_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        #region Uzuuuun Yol
        //Product LoadClass()
        //{
        //    return null;
        //}

        //Shipper LoadClass()
        //{
        //    Shipper shipper = new Shipper();
        //    Product.

        //    return null;
        //}

        //Employees LoadClass()
        //{
        //    return null;

        //} 
        #endregion

        T LoadClass<T>(T item) //generiz type. yukarıdakini kısaltmış olduk
        {
            foreach (PropertyInfo property in item.GetType().GetProperties()) //Propertyınfo için yukarı usinglere using                                                                     System.Reflection ekle.
            {
                var control = Controls.Find(property.Name, true)[0]; //grupbox içinde arasın diye true verdik
                                                                     //indexi sıfır verdik çünkü kontrolün name'i uniq                                             olduğundan dolayı başka aynı isimde control olması                                          mümkün değil. o yü<den 01 indexli

                if (property.PropertyType.Name == "String")
                {
                    property.SetValue(item, control.Text);
                }
                else if (property.PropertyType.Name == "Decimal")
                {
                    property.SetValue(item, decimal.Parse(control.Text));
                }
                if (property.PropertyType.Name == "Int16")
                {
                    property.SetValue(item, short.Parse(control.Text));
                }

                if (control is TextBox)
                {
                    property.SetValue(item, control.Text);
                }
            }

            return item;
        }

        void GetClass<T>(T item)
        {
            foreach (PropertyInfo property in item.GetType().GetProperties())
            {
                Control control = Controls.Find(property.Name, true)[0];

                if (control is TextBox)
                {
                    control.Text = property.GetValue(item).ToString();
                }
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Employees employee = LoadClass(new Employees());
            listBox1.Items.Add(employee);
            Clean(this);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Product product = LoadClass(new Product());
            listBox1.Items.Add(product);
            Clean(this);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Shipper shipper = LoadClass(new Shipper());
            listBox1.Items.Add(shipper);
            Clean(this);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }


        void Clean(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is GroupBox)
                {
                    Clean(item);
                }
            }
        }


        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            Clean(this);
            GetClass(listBox1.SelectedItem);
        }
    }
}
