
namespace WinFormUI
{
    partial class CheckIn
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
            this.rdbtnCar = new System.Windows.Forms.RadioButton();
            this.rdbtnMc = new System.Windows.Forms.RadioButton();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbtnCar
            // 
            this.rdbtnCar.AutoSize = true;
            this.rdbtnCar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbtnCar.Location = new System.Drawing.Point(313, 185);
            this.rdbtnCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnCar.Name = "rdbtnCar";
            this.rdbtnCar.Size = new System.Drawing.Size(75, 33);
            this.rdbtnCar.TabIndex = 0;
            this.rdbtnCar.TabStop = true;
            this.rdbtnCar.Text = "Car";
            this.rdbtnCar.UseVisualStyleBackColor = true;
            // 
            // rdbtnMc
            // 
            this.rdbtnMc.AutoSize = true;
            this.rdbtnMc.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbtnMc.Location = new System.Drawing.Point(589, 185);
            this.rdbtnMc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnMc.Name = "rdbtnMc";
            this.rdbtnMc.Size = new System.Drawing.Size(71, 33);
            this.rdbtnMc.TabIndex = 1;
            this.rdbtnMc.TabStop = true;
            this.rdbtnMc.Text = "MC";
            this.rdbtnMc.UseVisualStyleBackColor = true;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(543, 276);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(132, 22);
            this.txtLicensePlate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(286, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter license plate:";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnCheckIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckIn.Location = new System.Drawing.Point(416, 350);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(127, 28);
            this.btnCheckIn.TabIndex = 4;
            this.btnCheckIn.Text = "Check in";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbtnMc);
            this.Controls.Add(this.rdbtnCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnCar;
        private System.Windows.Forms.RadioButton rdbtnMc;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckIn;
    }
}