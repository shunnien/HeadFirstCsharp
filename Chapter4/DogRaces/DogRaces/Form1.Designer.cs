namespace DogRaces {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.race = new System.Windows.Forms.Button();
            this.bets = new System.Windows.Forms.Button();
            this.dogNumber = new System.Windows.Forms.NumericUpDown();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.alBet = new System.Windows.Forms.Label();
            this.bobBet = new System.Windows.Forms.Label();
            this.joeBet = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.bettorName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minimumBet = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrack
            // 
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(18, 16);
            this.racetrack.Margin = new System.Windows.Forms.Padding(4);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(600, 200);
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(18, 29);
            this.dog1.Margin = new System.Windows.Forms.Padding(4);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(75, 20);
            this.dog1.TabIndex = 1;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(18, 77);
            this.dog2.Margin = new System.Windows.Forms.Padding(4);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(75, 20);
            this.dog2.TabIndex = 1;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(18, 131);
            this.dog3.Margin = new System.Windows.Forms.Padding(4);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(75, 20);
            this.dog3.TabIndex = 1;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = ((System.Drawing.Image)(resources.GetObject("dog4.Image")));
            this.dog4.Location = new System.Drawing.Point(18, 186);
            this.dog4.Margin = new System.Windows.Forms.Padding(4);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(75, 20);
            this.dog4.TabIndex = 1;
            this.dog4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.bets);
            this.groupBox1.Controls.Add(this.dogNumber);
            this.groupBox1.Controls.Add(this.betAmount);
            this.groupBox1.Controls.Add(this.alBet);
            this.groupBox1.Controls.Add(this.bobBet);
            this.groupBox1.Controls.Add(this.joeBet);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.joeRadioButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bettorName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.minimumBet);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(18, 237);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(600, 197);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // race
            // 
            this.race.Location = new System.Drawing.Point(439, 48);
            this.race.Margin = new System.Windows.Forms.Padding(4);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(153, 123);
            this.race.TabIndex = 5;
            this.race.Text = "Race!";
            this.race.UseVisualStyleBackColor = true;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // bets
            // 
            this.bets.Location = new System.Drawing.Point(55, 148);
            this.bets.Margin = new System.Windows.Forms.Padding(4);
            this.bets.Name = "bets";
            this.bets.Size = new System.Drawing.Size(60, 31);
            this.bets.TabIndex = 4;
            this.bets.Text = "Bets";
            this.bets.UseVisualStyleBackColor = true;
            this.bets.Click += new System.EventHandler(this.bets_Click);
            // 
            // dogNumber
            // 
            this.dogNumber.Location = new System.Drawing.Point(325, 153);
            this.dogNumber.Margin = new System.Windows.Forms.Padding(4);
            this.dogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumber.Name = "dogNumber";
            this.dogNumber.Size = new System.Drawing.Size(58, 27);
            this.dogNumber.TabIndex = 3;
            this.dogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(123, 152);
            this.betAmount.Margin = new System.Windows.Forms.Padding(4);
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(41, 27);
            this.betAmount.TabIndex = 3;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // alBet
            // 
            this.alBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBet.Location = new System.Drawing.Point(222, 115);
            this.alBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alBet.Name = "alBet";
            this.alBet.Size = new System.Drawing.Size(200, 21);
            this.alBet.TabIndex = 2;
            this.alBet.Text = "Al hasn\'t placed a bet";
            // 
            // bobBet
            // 
            this.bobBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBet.Location = new System.Drawing.Point(222, 88);
            this.bobBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bobBet.Name = "bobBet";
            this.bobBet.Size = new System.Drawing.Size(200, 21);
            this.bobBet.TabIndex = 2;
            this.bobBet.Text = "Bob bets 5 on dog #3";
            // 
            // joeBet
            // 
            this.joeBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBet.Location = new System.Drawing.Point(222, 58);
            this.joeBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.joeBet.Name = "joeBet";
            this.joeBet.Size = new System.Drawing.Size(200, 21);
            this.joeBet.TabIndex = 2;
            this.joeBet.Text = "Joe hasn\'t placed a bet";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(8, 111);
            this.alRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(131, 20);
            this.alRadioButton.TabIndex = 1;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "Al  has 45 bucks";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(8, 84);
            this.bobRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(142, 20);
            this.bobRadioButton.TabIndex = 1;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "Bob  has 75 bucks";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(8, 54);
            this.joeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(133, 20);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe has 50 bucks";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "bucks on dog number";
            // 
            // bettorName
            // 
            this.bettorName.AutoSize = true;
            this.bettorName.Location = new System.Drawing.Point(5, 155);
            this.bettorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bettorName.Name = "bettorName";
            this.bettorName.Size = new System.Drawing.Size(42, 16);
            this.bettorName.TabIndex = 0;
            this.bettorName.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bets";
            // 
            // minimumBet
            // 
            this.minimumBet.AutoSize = true;
            this.minimumBet.Location = new System.Drawing.Point(9, 24);
            this.minimumBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minimumBet.Name = "minimumBet";
            this.minimumBet.Size = new System.Drawing.Size(151, 16);
            this.minimumBet.TabIndex = 0;
            this.minimumBet.Text = "Minimum Bet: 5 bucks";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.racetrack);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Button bets;
        private System.Windows.Forms.NumericUpDown dogNumber;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Label alBet;
        private System.Windows.Forms.Label bobBet;
        private System.Windows.Forms.Label joeBet;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bettorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minimumBet;
    }
}

