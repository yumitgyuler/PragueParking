using Business;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WinFormUI
{
    public partial class CheckIn : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        Methods methods = new Methods(connectionString);
        public CheckIn()
        {
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
                Vehicle vehicle;
            vehicle = new Vehicle(txtLicensePlate.Text);

            if (rdbtnCar.Checked)
            {
                vehicle.VehicleTypeId = 1;
                vehicle = methods.AddVehicle(vehicle);
            }
            else if (rdbtnMc.Checked)
            {
                vehicle.VehicleTypeId = 2;
                vehicle = methods.AddVehicle(vehicle);
            }
            else
                MessageBox.Show("You must choose vehicle type!", "Din idiot");
            

            if (vehicle.SpotNumber != 0)
            {
                MessageBox.Show($"Car with license plate \"{vehicle.LicensePlate}\" is parked at position {vehicle.SpotNumber}", "Checked in");
            }
                            
        }
    }
}
