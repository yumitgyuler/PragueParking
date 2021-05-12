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
    public partial class RevenuePerDay : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        Methods methods = new Methods(connectionString);
        public RevenuePerDay()
        {
            InitializeComponent();
            OnLoad();
        }

        private void OnLoad()
        {
            List<Vehicle> vehicles = methods.RevenuePerDay();
            foreach (Vehicle vehicle in vehicles)
            {
                listView1.Items.Add(new ListViewItem(new string[] { vehicle.ArrivalTime.ToString("yyyy-MM-dd"), vehicle.TotalCost.ToString("C2")}));
            }
        }
    }
}
