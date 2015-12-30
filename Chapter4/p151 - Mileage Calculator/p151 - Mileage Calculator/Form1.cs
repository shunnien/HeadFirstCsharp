using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p151___Mileage_Calculator {
    public partial class Form1 : Form {

        int startingMileage, endingMileage;
        double milesTraveled, reimburseRate = 0.39, amountOwed;

        private void button1_Click(object sender, EventArgs e) {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;
            if (startingMileage < endingMileage) {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled *= reimburseRate;
                label4.Text = "$" + amountOwed;
            }
            else {
                MessageBox.Show("The starting mileage must be less than the ending mileage", "Cannot Calculate");
            }
        }

        public Form1() {
            InitializeComponent();
        }
    }
}
