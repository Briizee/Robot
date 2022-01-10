
namespace Robot
{
    partial class FrmRobot
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRobot = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnMvOne = new System.Windows.Forms.Button();
            this.btnMvTen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblRobot);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 220);
            this.panel1.TabIndex = 0;
            // 
            // lblRobot
            // 
            this.lblRobot.AutoSize = true;
            this.lblRobot.Font = new System.Drawing.Font("Wingdings", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRobot.Location = new System.Drawing.Point(100, 100);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(19, 15);
            this.lblRobot.TabIndex = 0;
            this.lblRobot.Tag = "";
            this.lblRobot.Text = "é";
            this.lblRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(24, 20);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(60, 15);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "(X=0,Y=0)";
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(112, 280);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(20, 20);
            this.btnNorth.TabIndex = 2;
            this.btnNorth.Text = "N";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(92, 300);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(20, 20);
            this.btnWest.TabIndex = 3;
            this.btnWest.Text = "W";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(132, 300);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(20, 20);
            this.btnEast.TabIndex = 4;
            this.btnEast.Text = "E";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(112, 320);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(20, 20);
            this.btnSouth.TabIndex = 5;
            this.btnSouth.Text = "S";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnMvOne
            // 
            this.btnMvOne.Location = new System.Drawing.Point(47, 300);
            this.btnMvOne.Name = "btnMvOne";
            this.btnMvOne.Size = new System.Drawing.Size(39, 20);
            this.btnMvOne.TabIndex = 6;
            this.btnMvOne.Text = "Go 1";
            this.btnMvOne.UseVisualStyleBackColor = true;
            this.btnMvOne.Click += new System.EventHandler(this.btnMvOne_Click);
            // 
            // btnMvTen
            // 
            this.btnMvTen.Location = new System.Drawing.Point(158, 300);
            this.btnMvTen.Name = "btnMvTen";
            this.btnMvTen.Size = new System.Drawing.Size(49, 20);
            this.btnMvTen.TabIndex = 7;
            this.btnMvTen.Text = "Go 10";
            this.btnMvTen.UseVisualStyleBackColor = true;
            this.btnMvTen.Click += new System.EventHandler(this.btnMvTen_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(132, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMvTen);
            this.Controls.Add(this.btnMvOne);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRobot";
            this.Text = "Robot";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblRobot;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnMvOne;
        private System.Windows.Forms.Button btnMvTen;
        private System.Windows.Forms.Button btnExit;
    }
}

