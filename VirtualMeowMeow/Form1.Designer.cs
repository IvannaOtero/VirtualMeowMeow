namespace VirtualMeowMeow
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picCat = new PictureBox();
            lblTitle = new Label();
            lblHunger = new Label();
            lblHappiness = new Label();
            lblEnergy = new Label();
            barHunger = new ProgressBar();
            barHappiness = new ProgressBar();
            BarEnergy = new ProgressBar();
            btnPlay = new Button();
            btnFeed = new Button();
            btnNap = new Button();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picCat).BeginInit();
            SuspendLayout();
            // 
            // picCat
            // 
            picCat.BackgroundImage = (Image)resources.GetObject("picCat.BackgroundImage");
            picCat.Location = new Point(182, 53);
            picCat.Name = "picCat";
            picCat.Size = new Size(541, 467);
            picCat.TabIndex = 0;
            picCat.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(409, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(110, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "MeowMeow";
            // 
            // lblHunger
            // 
            lblHunger.AutoSize = true;
            lblHunger.Location = new Point(67, 544);
            lblHunger.Name = "lblHunger";
            lblHunger.Size = new Size(80, 25);
            lblHunger.TabIndex = 2;
            lblHunger.Text = "Hunger: ";
            // 
            // lblHappiness
            // 
            lblHappiness.AutoSize = true;
            lblHappiness.Location = new Point(409, 544);
            lblHappiness.Name = "lblHappiness";
            lblHappiness.Size = new Size(104, 25);
            lblHappiness.TabIndex = 3;
            lblHappiness.Text = "Happiness: ";
            // 
            // lblEnergy
            // 
            lblEnergy.AutoSize = true;
            lblEnergy.Location = new Point(760, 544);
            lblEnergy.Name = "lblEnergy";
            lblEnergy.Size = new Size(75, 25);
            lblEnergy.TabIndex = 4;
            lblEnergy.Text = "Energy: ";
            // 
            // barHunger
            // 
            barHunger.Location = new Point(33, 597);
            barHunger.Name = "barHunger";
            barHunger.Size = new Size(150, 34);
            barHunger.TabIndex = 5;
            barHunger.Value = 50;
            // 
            // barHappiness
            // 
            barHappiness.Location = new Point(385, 597);
            barHappiness.Name = "barHappiness";
            barHappiness.Size = new Size(150, 34);
            barHappiness.TabIndex = 6;
            barHappiness.Value = 50;
            // 
            // BarEnergy
            // 
            BarEnergy.Location = new Point(717, 597);
            BarEnergy.Name = "BarEnergy";
            BarEnergy.Size = new Size(150, 34);
            BarEnergy.TabIndex = 7;
            BarEnergy.Value = 50;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(407, 654);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(112, 34);
            btnPlay.TabIndex = 8;
            btnPlay.Text = "Play ";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnFeed
            // 
            btnFeed.Location = new Point(182, 654);
            btnFeed.Name = "btnFeed";
            btnFeed.Size = new Size(112, 34);
            btnFeed.TabIndex = 9;
            btnFeed.Text = "Feed";
            btnFeed.UseVisualStyleBackColor = true;
            btnFeed.Click += btnFeed_Click;
            // 
            // btnNap
            // 
            btnNap.Location = new Point(647, 654);
            btnNap.Name = "btnNap";
            btnNap.Size = new Size(112, 34);
            btnNap.TabIndex = 10;
            btnNap.Text = "Nap";
            btnNap.UseVisualStyleBackColor = true;
            btnNap.Click += btnNap_Click;
            // 
            // timer
            // 
            timer.Interval = 2000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 728);
            Controls.Add(btnNap);
            Controls.Add(btnFeed);
            Controls.Add(btnPlay);
            Controls.Add(BarEnergy);
            Controls.Add(barHappiness);
            Controls.Add(barHunger);
            Controls.Add(lblEnergy);
            Controls.Add(lblHappiness);
            Controls.Add(lblHunger);
            Controls.Add(lblTitle);
            Controls.Add(picCat);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picCat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCat;
        private Label lblTitle;
        private Label lblHunger;
        private Label lblHappiness;
        private Label lblEnergy;
        private ProgressBar barHunger;
        private ProgressBar barHappiness;
        private ProgressBar BarEnergy;
        private Button btnPlay;
        private Button btnFeed;
        private Button btnNap;
        private System.Windows.Forms.Timer timer;
    }
}
