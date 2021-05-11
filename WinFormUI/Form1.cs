using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
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
            //this.Location = Screen.AllScreens[1].WorkingArea.Location;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
