using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search serachForm = new Search();
            LoadForm(serachForm);
        }
        Form activeFrom = null;
        private void LoadForm(Form form)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckIn checkIn = new CheckIn();
            LoadForm(checkIn);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut();
            LoadForm(checkOut);
        }

        private void btnMoveVehicle_Click(object sender, EventArgs e)
        {
            Move move = new Move();
            LoadForm(move);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            ShowAll showAll = new ShowAll();
            LoadForm(showAll);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
