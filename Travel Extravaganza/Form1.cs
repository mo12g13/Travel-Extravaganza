using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Extravaganza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            String streetAddress = txtStreet.Text;
            String cityName = txtCity.Text;
            String stateName = txtState.Text;
            String zipCodeAddress = txtZipCode.Text;
            try
            {
                StringBuilder addressQuery = new StringBuilder();
                addressQuery.Append("http://maps.google.com/?q=your+query?=");
                if(streetAddress != "")
                {
                    addressQuery.Append(streetAddress + "," + "+");
                }
                else if(cityName != "")
                {
                    addressQuery.Append(cityName+ "," + "+");
                }
                else if(stateName != "")
                {
                    addressQuery.Append(zipCodeAddress + "," + "+");
                }
                webBrowser1.Navigate(addressQuery.ToString());
            }
            catch(Exception exe)
            {
                Console.WriteLine("Error has occur");
            }
        }

        private void hotelSearch(object sender, EventArgs e)
        {

        }
    }
}
