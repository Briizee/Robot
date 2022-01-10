using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot
{
    public partial class FrmRobot : Form
    {
        private Robot robot = new Robot();
        public FrmRobot()
        {
            InitializeComponent();
            robot.initializePoint();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            robot.changeDirection('N');
            lblRobot.Text = "é";
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            robot.changeDirection('S');
            lblRobot.Text = "ê";
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            robot.changeDirection('W');
            lblRobot.Text = "ç";
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            robot.changeDirection('E');
            lblRobot.Text = "è";
        }

        private void btnMvOne_Click(object sender, EventArgs e)
        {
            try
            {
                Point newPosition = robot.movePosition(1);
                lblRobot.Location = newPosition;
                string positionText = String.Format("(X={0}, Y={1})", newPosition.X - 100, -1 * (newPosition.Y - 100));
                lblPosition.Text = positionText;
            } catch (ArgumentOutOfRangeException )
            {
                MessageBox.Show("Movement is out of range");
            }
        }

        private void btnMvTen_Click(object sender, EventArgs e)
        {
            try
            {
                Point newPosition = robot.movePosition(10);
                lblRobot.Location = newPosition;
                string positionText = String.Format("(X={0}, Y={1})", newPosition.X - 100, -1*(newPosition.Y - 100));
                lblPosition.Text = positionText;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Movement is out of range");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
