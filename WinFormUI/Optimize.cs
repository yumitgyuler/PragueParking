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
    public partial class Optimize : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        Methods methods = new Methods(connectionString);
        public Optimize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                List<Vehicle> vehicles = methods.OptimizeParking();
                if (vehicles.Count == 0)
                {
                    break;
                }
                foreach (Vehicle vehicle in vehicles)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { vehicle.LicensePlate, vehicle.OldSpotNumber.ToString(), vehicle.SpotNumber.ToString() })); ;
                }
            }
            
        }
    }
}
