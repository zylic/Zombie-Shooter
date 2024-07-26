namespace ZombieShooter
{
    partial class HelpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpScreen));
            pictureBox1 = new PictureBox();
            HelpScreenLabel = new Label();
            exitButton = new Button();
            boosiefade = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boosiefade).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.zombiesBackgroundImage;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(586, 563);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // HelpScreenLabel
            // 
            HelpScreenLabel.AutoSize = true;
            HelpScreenLabel.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point);
            HelpScreenLabel.ForeColor = Color.White;
            HelpScreenLabel.Location = new Point(48, 9);
            HelpScreenLabel.Name = "HelpScreenLabel";
            HelpScreenLabel.Size = new Size(480, 308);
            HelpScreenLabel.TabIndex = 1;
            HelpScreenLabel.Text = resources.GetString("HelpScreenLabel.Text");
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.ActiveCaptionText;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Agency FB", 27.75F, FontStyle.Underline, GraphicsUnit.Point);
            exitButton.ForeColor = Color.FromArgb(255, 128, 0);
            exitButton.Location = new Point(471, 476);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(101, 73);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // boosiefade
            // 
            boosiefade.BackgroundImageLayout = ImageLayout.Stretch;
            boosiefade.Image = Properties.Resources.bruhwantedtheboosiedfade;
            boosiefade.Location = new Point(48, 320);
            boosiefade.Name = "boosiefade";
            boosiefade.Size = new Size(218, 229);
            boosiefade.SizeMode = PictureBoxSizeMode.StretchImage;
            boosiefade.TabIndex = 3;
            boosiefade.TabStop = false;
            // 
            // HelpScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(boosiefade);
            Controls.Add(exitButton);
            Controls.Add(HelpScreenLabel);
            Controls.Add(pictureBox1);
            Name = "HelpScreen";
            Text = "HelpScreen";
            Load += HelpScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)boosiefade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label HelpScreenLabel;
        private Button exitButton;
        private PictureBox boosiefade;
    }
}