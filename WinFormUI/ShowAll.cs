using Business;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class ShowAll : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        Methods methods = new Methods(connectionString);
        public ShowAll()
        {
            InitializeComponent();
            LoadList();
        }
        private void LoadList()
        {
            List<Vehicle> vehicles = methods.GetList();
            foreach (Vehicle vehicle in vehicles)
            {
                decimal price = methods.PriceCalculate(vehicle);
                listView1.Items.Add(new ListViewItem(new string[] { vehicle.LicensePlate, vehicle.VehicleType.ToString(),
                    vehicle.SpotNumber.ToString(), vehicle.ArrivalTime.ToString(), price.ToString("C2")}));
            }
        }
            
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
