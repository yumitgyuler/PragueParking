using Business;
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
    public partial class Move : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        Methods methods = new Methods(connectionString);
        public Move()
        {
            InitializeComponent();
        }

        private void Move_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool result = false;
            try
            {
                result = methods.MoveVehicle(txtLicensePlate.Text, (int)nupSpot.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            if (result)
                MessageBox.Show("Vehicle has been moved!");
            else
                MessageBox.Show("Vehicle has not been moved!");
        }
    }
}
