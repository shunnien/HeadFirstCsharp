using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p146___TypeCast {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            decimal myDecimalValue = 10;
            int myIntValue = myDecimalValue;

            MessageBox.Show("The myInterValue is " + myIntValue);
        }
    }
}
