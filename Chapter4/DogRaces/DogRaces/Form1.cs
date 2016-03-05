using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaces {
    public partial class Form1 : Form {

        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];

        public Form1() {
            InitializeComponent();

            minimumBet.Text = string.Format("Minimum bet {0:c}", (int)betAmount.Minimum);
            for (int i = 0; i < dogs.Length; i++) {
                dogs[i] = new Greyhound() {
                    MyPictureBox = (PictureBox)Controls.Find(("dog" + (i+1).ToString()), false).FirstOrDefault(),
                    RacetrackLength = racetrack.Size.Width -(dog1.Right - racetrack.Left),
                    StartingPosition = dog1.Left
                };
            }

            guys = new Guy[3] {
                new Guy() { Name="Joe",MyBet=null,Cash=50,MyRadioButton = joeRadioButton,MyLabel=joeBet},
                new Guy() { Name="Bob",MyBet=null,Cash=75,MyRadioButton = bobRadioButton,MyLabel=bobBet},
                new Guy() { Name="Al",MyBet=null,Cash=45,MyRadioButton = alRadioButton,MyLabel=alBet}
            };

            foreach (var item in guys) {
                item.UpdateLabels();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            bool noWinner = true;
            int winningDog;
            while (noWinner) {
                this.Refresh();
                for (int i = 0; i < dogs.Length; i++) {
                    if (dogs[i].Run()) {
                        winningDog = i + 1;
                        timer1.Stop();
                        noWinner = false;
                        MessageBox.Show("We have a winner - dog #" + winningDog);

                        foreach (Guy guy in guys) {
                            if (guy.MyBet != null) {
                                guy.Collect(winningDog);
                                guy.ClearBet();
                                guy.UpdateLabels();
                            }
                        }
                        foreach (Greyhound greyhounds in dogs) {
                            greyhounds.TakeStartingPosition();
                        }
                        groupBox1.Enabled = true;
                        break;
                    }
                }
            }
        }

        private void race_Click(object sender, EventArgs e) {
            groupBox1.Enabled = false;
            timer1.Start();
        }

        private void bets_Click(object sender, EventArgs e) {
            int guyNumber = 0;
            if (joeRadioButton.Checked) {
                guyNumber = 0;
            }
            if (bobRadioButton.Checked) {
                guyNumber = 1;
            }
            if (alRadioButton.Checked) {
                guyNumber = 2;
            }
            guys[guyNumber].PlaceBet((int)betAmount.Value, (int)dogNumber.Value);
            guys[guyNumber].UpdateLabels();
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e) {
            bettorName.Text = "Joe";
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e) {
            bettorName.Text = "Bob";
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e) {
            bettorName.Text = "Al";
        }
    }
}
