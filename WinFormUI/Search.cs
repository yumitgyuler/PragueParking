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
    public partial class Search : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        Methods methods = new Methods(connectionString);
        public Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string licansePlate = textBox1.Text;
            Vehicle vehicle = methods.SearchVehicle(licansePlate);
            //Get back vehicle from database
            decimal price = methods.PriceCalculate(vehicle);

            lblVehicleType.Text = vehicle.VehicleType.ToString();
            lblLicensePlate.Text = vehicle.LicensePlate.ToString();
            lblArrival.Text = vehicle.ArrivalTime.ToString();
            lblParkingFee.Text = price.ToString("C2");
            lblParkingTime.Text = vehicle.ParkedTime.Days.ToString() + "D " + vehicle.ParkedTime.Hours.ToString() + "H " + vehicle.ParkedTime.Minutes.ToString() + "M";
            lblSpot.Text = vehicle.SpotNumber.ToString();
        }
    }
}
