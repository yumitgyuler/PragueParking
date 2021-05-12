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
    public partial class MoreThan48Hours : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        Methods methods = new Methods(connectionString);
        public MoreThan48Hours()
        {
            InitializeComponent();
            OnLoad();
        }

        private void OnLoad()
        {
            List<Vehicle> vehicles = methods.ParkedMoreThan48h();
            foreach (Vehicle vehicle in vehicles)
            {
                listView1.Items.Add(new ListViewItem(new string[] { vehicle.LicensePlate, vehicle.SpotNumber.ToString(), vehicle.ArrivalTime.ToString() }));
            }
        }
    }
}
