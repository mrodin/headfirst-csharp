namespace ADayAtTheRaces
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raceButton = new System.Windows.Forms.Button();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dogNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.dog1PictureBox = new System.Windows.Forms.PictureBox();
            this.dog2PictureBox = new System.Windows.Forms.PictureBox();
            this.dog3PictureBox = new System.Windows.Forms.PictureBox();
            this.dog4PictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("racetrackPictureBox.BackgroundImage")));
            this.racetrackPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.racetrackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(600, 200);
            this.racetrackPictureBox.TabIndex = 0;
            this.racetrackPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raceButton);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dogNumericUpDown);
            this.groupBox1.Controls.Add(this.betNumericUpDown);
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.joeRadioButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(439, 64);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(145, 79);
            this.raceButton.TabIndex = 9;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(200, 120);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(215, 23);
            this.alBetLabel.TabIndex = 8;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(200, 93);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(215, 23);
            this.bobBetLabel.TabIndex = 8;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(200, 64);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(215, 23);
            this.joeBetLabel.TabIndex = 8;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "bucks on dog number";
            // 
            // dogNumericUpDown
            // 
            this.dogNumericUpDown.Location = new System.Drawing.Point(380, 164);
            this.dogNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumericUpDown.Name = "dogNumericUpDown";
            this.dogNumericUpDown.Size = new System.Drawing.Size(84, 22);
            this.dogNumericUpDown.TabIndex = 6;
            this.dogNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betNumericUpDown
            // 
            this.betNumericUpDown.Location = new System.Drawing.Point(138, 164);
            this.betNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betNumericUpDown.Name = "betNumericUpDown";
            this.betNumericUpDown.Size = new System.Drawing.Size(84, 22);
            this.betNumericUpDown.TabIndex = 6;
            this.betNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(56, 163);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 5;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 165);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 17);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "name";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(9, 119);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(41, 21);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "Al";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(9, 92);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(54, 21);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "Bob";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(9, 64);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(52, 21);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(197, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bets";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimumBetLabel.Location = new System.Drawing.Point(6, 34);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(164, 17);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimum bet: 5 bucks";
            // 
            // dog1PictureBox
            // 
            this.dog1PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog1PictureBox.BackgroundImage")));
            this.dog1PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog1PictureBox.Location = new System.Drawing.Point(12, 21);
            this.dog1PictureBox.Name = "dog1PictureBox";
            this.dog1PictureBox.Size = new System.Drawing.Size(75, 20);
            this.dog1PictureBox.TabIndex = 10;
            this.dog1PictureBox.TabStop = false;
            // 
            // dog2PictureBox
            // 
            this.dog2PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog2PictureBox.BackgroundImage")));
            this.dog2PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog2PictureBox.Location = new System.Drawing.Point(12, 70);
            this.dog2PictureBox.Name = "dog2PictureBox";
            this.dog2PictureBox.Size = new System.Drawing.Size(75, 20);
            this.dog2PictureBox.TabIndex = 10;
            this.dog2PictureBox.TabStop = false;
            // 
            // dog3PictureBox
            // 
            this.dog3PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog3PictureBox.BackgroundImage")));
            this.dog3PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog3PictureBox.Location = new System.Drawing.Point(12, 125);
            this.dog3PictureBox.Name = "dog3PictureBox";
            this.dog3PictureBox.Size = new System.Drawing.Size(75, 20);
            this.dog3PictureBox.TabIndex = 10;
            this.dog3PictureBox.TabStop = false;
            // 
            // dog4PictureBox
            // 
            this.dog4PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog4PictureBox.BackgroundImage")));
            this.dog4PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog4PictureBox.Location = new System.Drawing.Point(12, 177);
            this.dog4PictureBox.Name = "dog4PictureBox";
            this.dog4PictureBox.Size = new System.Drawing.Size(75, 20);
            this.dog4PictureBox.TabIndex = 10;
            this.dog4PictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 428);
            this.Controls.Add(this.dog4PictureBox);
            this.Controls.Add(this.dog3PictureBox);
            this.Controls.Add(this.dog2PictureBox);
            this.Controls.Add(this.dog1PictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.racetrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown dogNumericUpDown;
        private System.Windows.Forms.NumericUpDown betNumericUpDown;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.PictureBox dog1PictureBox;
        private System.Windows.Forms.PictureBox dog2PictureBox;
        private System.Windows.Forms.PictureBox dog3PictureBox;
        private System.Windows.Forms.PictureBox dog4PictureBox;
        private System.Windows.Forms.Timer timer1;
    }
}

