
namespace WinFormUI
{
    partial class CheckOut
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
            this.rdbtnRecievePayment = new System.Windows.Forms.RadioButton();
            this.rdbtnDontRecievePayment = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRemoved = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblParkingTime = new System.Windows.Forms.Label();
            this.lblParkingFee = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbtnRecievePayment
            // 
            this.rdbtnRecievePayment.AutoSize = true;
            this.rdbtnRecievePayment.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnRecievePayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbtnRecievePayment.Location = new System.Drawing.Point(505, 63);
            this.rdbtnRecievePayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnRecievePayment.Name = "rdbtnRecievePayment";
            this.rdbtnRecievePayment.Size = new System.Drawing.Size(74, 33);
            this.rdbtnRecievePayment.TabIndex = 0;
            this.rdbtnRecievePayment.TabStop = true;
            this.rdbtnRecievePayment.Text = "Yes";
            this.rdbtnRecievePayment.UseVisualStyleBackColor = true;
            // 
            // rdbtnDontRecievePayment
            // 
            this.rdbtnDontRecievePayment.AutoSize = true;
            this.rdbtnDontRecievePayment.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnDontRecievePayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbtnDontRecievePayment.Location = new System.Drawing.Point(612, 63);
            this.rdbtnDontRecievePayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnDontRecievePayment.Name = "rdbtnDontRecievePayment";
            this.rdbtnDontRecievePayment.Size = new System.Drawing.Size(67, 33);
            this.rdbtnDontRecievePayment.TabIndex = 1;
            this.rdbtnDontRecievePayment.TabStop = true;
            this.rdbtnDontRecievePayment.Text = "No";
            this.rdbtnDontRecievePayment.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you want to receive payment?";
            // 
            // lblRemoved
            // 
            this.lblRemoved.AutoSize = true;
            this.lblRemoved.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoved.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemoved.Location = new System.Drawing.Point(29, 210);
            this.lblRemoved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemoved.Name = "lblRemoved";
            this.lblRemoved.Size = new System.Drawing.Size(824, 29);
            this.lblRemoved.TabIndex = 3;
            this.lblRemoved.Text = "Vehicle with registration number \"HJS404\" was succesfully removed";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrival.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArrival.Location = new System.Drawing.Point(29, 260);
            this.lblArrival.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(250, 29);
            this.lblArrival.TabIndex = 4;
            this.lblArrival.Text = "Arrival: 2021-05-01";
            // 
            // lblParkingTime
            // 
            this.lblParkingTime.AutoSize = true;
            this.lblParkingTime.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkingTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblParkingTime.Location = new System.Drawing.Point(29, 311);
            this.lblParkingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParkingTime.Name = "lblParkingTime";
            this.lblParkingTime.Size = new System.Drawing.Size(567, 29);
            this.lblParkingTime.TabIndex = 5;
            this.lblParkingTime.Text = "Total parking time: 5 days, 1 hours, 2 minutes";
            // 
            // lblParkingFee
            // 
            this.lblParkingFee.AutoSize = true;
            this.lblParkingFee.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkingFee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblParkingFee.Location = new System.Drawing.Point(32, 362);
            this.lblParkingFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParkingFee.Name = "lblParkingFee";
            this.lblParkingFee.Size = new System.Drawing.Size(313, 29);
            this.lblParkingFee.TabIndex = 6;
            this.lblParkingFee.Text = "Total parking fee: 2500kr";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(427, 116);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 28);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Check Out";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(285, 118);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(132, 22);
            this.txtLicensePlate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(28, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Enter license plate:";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblParkingFee);
            this.Controls.Add(this.lblParkingTime);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.lblRemoved);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbtnDontRecievePayment);
            this.Controls.Add(this.rdbtnRecievePayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnRecievePayment;
        private System.Windows.Forms.RadioButton rdbtnDontRecievePayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRemoved;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblParkingTime;
        private System.Windows.Forms.Label lblParkingFee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label label6;
    }
}