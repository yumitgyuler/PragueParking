
namespace WinFormUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowInterval = new System.Windows.Forms.Button();
            this.btThan48 = new System.Windows.Forms.Button();
            this.btnShowRevenuePerDay = new System.Windows.Forms.Button();
            this.btnOptimizeParking = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnMoveVehicle = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 76);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1205, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prague Parking";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnShowInterval);
            this.panel2.Controls.Add(this.btThan48);
            this.panel2.Controls.Add(this.btnShowRevenuePerDay);
            this.panel2.Controls.Add(this.btnOptimizeParking);
            this.panel2.Controls.Add(this.btnDisplayAll);
            this.panel2.Controls.Add(this.btnMoveVehicle);
            this.panel2.Controls.Add(this.btnCheckOut);
            this.panel2.Controls.Add(this.btnCheckIn);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 634);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(0, 579);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(267, 55);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowInterval
            // 
            this.btnShowInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnShowInterval.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowInterval.FlatAppearance.BorderSize = 0;
            this.btnShowInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowInterval.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInterval.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowInterval.Location = new System.Drawing.Point(0, 440);
            this.btnShowInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowInterval.Name = "btnShowInterval";
            this.btnShowInterval.Size = new System.Drawing.Size(267, 55);
            this.btnShowInterval.TabIndex = 8;
            this.btnShowInterval.Text = "Show revenue per day or interval";
            this.btnShowInterval.UseVisualStyleBackColor = false;
            this.btnShowInterval.Click += new System.EventHandler(this.btnShowInterval_Click);
            // 
            // btThan48
            // 
            this.btThan48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btThan48.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThan48.FlatAppearance.BorderSize = 0;
            this.btThan48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThan48.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThan48.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btThan48.Location = new System.Drawing.Point(0, 385);
            this.btThan48.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThan48.Name = "btThan48";
            this.btThan48.Size = new System.Drawing.Size(267, 55);
            this.btThan48.TabIndex = 7;
            this.btThan48.Text = "Show parked vehicle more than 48h ";
            this.btThan48.UseVisualStyleBackColor = false;
            this.btThan48.Click += new System.EventHandler(this.btThan48_Click);
            // 
            // btnShowRevenuePerDay
            // 
            this.btnShowRevenuePerDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnShowRevenuePerDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowRevenuePerDay.FlatAppearance.BorderSize = 0;
            this.btnShowRevenuePerDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRevenuePerDay.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRevenuePerDay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowRevenuePerDay.Location = new System.Drawing.Point(0, 330);
            this.btnShowRevenuePerDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowRevenuePerDay.Name = "btnShowRevenuePerDay";
            this.btnShowRevenuePerDay.Size = new System.Drawing.Size(267, 55);
            this.btnShowRevenuePerDay.TabIndex = 6;
            this.btnShowRevenuePerDay.Text = "Show revenue per day";
            this.btnShowRevenuePerDay.UseVisualStyleBackColor = false;
            this.btnShowRevenuePerDay.Click += new System.EventHandler(this.btnShowRevenuePerDay_Click);
            // 
            // btnOptimizeParking
            // 
            this.btnOptimizeParking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnOptimizeParking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptimizeParking.FlatAppearance.BorderSize = 0;
            this.btnOptimizeParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptimizeParking.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptimizeParking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOptimizeParking.Location = new System.Drawing.Point(0, 275);
            this.btnOptimizeParking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOptimizeParking.Name = "btnOptimizeParking";
            this.btnOptimizeParking.Size = new System.Drawing.Size(267, 55);
            this.btnOptimizeParking.TabIndex = 5;
            this.btnOptimizeParking.Text = "Optimize Parking";
            this.btnOptimizeParking.UseVisualStyleBackColor = false;
            this.btnOptimizeParking.Click += new System.EventHandler(this.btnOptimizeParking_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDisplayAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisplayAll.FlatAppearance.BorderSize = 0;
            this.btnDisplayAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAll.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDisplayAll.Location = new System.Drawing.Point(0, 220);
            this.btnDisplayAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(267, 55);
            this.btnDisplayAll.TabIndex = 4;
            this.btnDisplayAll.Text = "Display all";
            this.btnDisplayAll.UseVisualStyleBackColor = false;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnMoveVehicle
            // 
            this.btnMoveVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnMoveVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMoveVehicle.FlatAppearance.BorderSize = 0;
            this.btnMoveVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveVehicle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveVehicle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMoveVehicle.Location = new System.Drawing.Point(0, 165);
            this.btnMoveVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoveVehicle.Name = "btnMoveVehicle";
            this.btnMoveVehicle.Size = new System.Drawing.Size(267, 55);
            this.btnMoveVehicle.TabIndex = 3;
            this.btnMoveVehicle.Text = "Move vehicle";
            this.btnMoveVehicle.UseVisualStyleBackColor = false;
            this.btnMoveVehicle.Click += new System.EventHandler(this.btnMoveVehicle_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCheckOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckOut.Location = new System.Drawing.Point(0, 110);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(267, 55);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCheckIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckIn.Location = new System.Drawing.Point(0, 55);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(267, 55);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check in";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(267, 55);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(267, 76);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1000, 634);
            this.pnlMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 710);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnMoveVehicle;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnOptimizeParking;
        private System.Windows.Forms.Button btnShowRevenuePerDay;
        private System.Windows.Forms.Button btThan48;
        private System.Windows.Forms.Button btnShowInterval;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMain;
    }
}

