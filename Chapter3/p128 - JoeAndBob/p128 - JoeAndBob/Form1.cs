using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p128___JoeAndBob {
    public partial class Form1 : Form {
        Guy joe;
        Guy bob;
        int bank = 100;
        public Form1() {
            InitializeComponent();
            joe = new Guy() {
                Name = "Joe",
                Cash = 50
            };

            bob = new Guy() {
                Name = "Bob",
                Cash = 100
            };

            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (bank >= 100) {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void UpdateForm() {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }

        private void button2_Click(object sender, EventArgs e) {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e) {
            if (joe.Cash >= 10) {
                bob.ReceiveCash(joe.GiveCash(10));
                UpdateForm();
            }
            else {
                MessageBox.Show("Joe dosen't have enough money.");
            }
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e) {
            if (bob.Cash >= 5) {
                joe.ReceiveCash(bob.GiveCash(5));
                UpdateForm();
            }
            else {
                MessageBox.Show("Bob dosen't have enough money.");
            }
        }
    }
}
