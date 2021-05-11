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
    public partial class CheckOut : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        Methods methods = new Methods(connectionString);
        public CheckOut()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle(txtLicensePlate.Text);

            if (rdbtnRecievePayment.Checked)
            {
                vehicle = methods.RemoveVehicle(vehicle, true);
            }
            else if (rdbtnDontRecievePayment.Checked)
            {
                vehicle = methods.RemoveVehicle(vehicle, false);
            }

            if (vehicle != null)
            {
                lblRemoved.Text = $"Vehicle with registration number {vehicle.LicensePlate} was succesfully removed";
                lblArrival.Text = $"Arrival: {vehicle.ArrivalTime}";
                lblParkingTime.Text = $"Parked for: {vehicle.ParkedTime}";
                lblParkingFee.Text = $"Parking fee: {vehicle.TotalCost.ToString("C2")}";
            }

        }

        private void CheckOut_Load(object sender, EventArgs e)
        {

        }
    }
}
