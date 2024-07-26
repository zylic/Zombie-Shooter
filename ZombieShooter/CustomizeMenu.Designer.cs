namespace ZombieShooter
{
    partial class CustomizeMenu
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            perk1BrewButton = new Button();
            perk2ColaButton = new Button();
            perk3FizzButton = new Button();
            perk4PopButton = new Button();
            perk1BrewImage = new Panel();
            perk2ColaImage = new Panel();
            perk3FizzImage = new Panel();
            perk4PopImage = new Panel();
            exitButton = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.perk1brew;
            panel1.Location = new Point(381, 296);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 99);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.perk2cola;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(584, 296);
            panel2.Name = "panel2";
            panel2.Size = new Size(141, 99);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.perk3fizz;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(782, 296);
            panel3.Name = "panel3";
            panel3.Size = new Size(141, 99);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.perk4pop;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(997, 296);
            panel4.Name = "panel4";
            panel4.Size = new Size(141, 99);
            panel4.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Agency FB", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(381, 130);
            label1.Name = "label1";
            label1.Size = new Size(65, 34);
            label1.TabIndex = 8;
            label1.Text = "Perks";
            // 
            // perk1BrewButton
            // 
            perk1BrewButton.BackColor = Color.Black;
            perk1BrewButton.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            perk1BrewButton.ForeColor = Color.White;
            perk1BrewButton.Location = new Point(381, 514);
            perk1BrewButton.Name = "perk1BrewButton";
            perk1BrewButton.Size = new Size(141, 70);
            perk1BrewButton.TabIndex = 9;
            perk1BrewButton.Text = "Perk";
            perk1BrewButton.UseVisualStyleBackColor = false;
            perk1BrewButton.Click += perk1BrewButton_Click;
            perk1BrewButton.MouseLeave += customLabel_MouseLeave;
            perk1BrewButton.MouseHover += customLabel_MouseHover;
            // 
            // perk2ColaButton
            // 
            perk2ColaButton.BackColor = Color.Black;
            perk2ColaButton.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            perk2ColaButton.ForeColor = Color.White;
            perk2ColaButton.Location = new Point(584, 514);
            perk2ColaButton.Name = "perk2ColaButton";
            perk2ColaButton.Size = new Size(141, 70);
            perk2ColaButton.TabIndex = 10;
            perk2ColaButton.Text = "Perk";
            perk2ColaButton.UseVisualStyleBackColor = false;
            perk2ColaButton.Click += perk2ColaButton_Click;
            perk2ColaButton.MouseLeave += customLabel_MouseLeave;
            perk2ColaButton.MouseHover += customLabel_MouseHover;
            // 
            // perk3FizzButton
            // 
            perk3FizzButton.BackColor = Color.Black;
            perk3FizzButton.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            perk3FizzButton.ForeColor = Color.White;
            perk3FizzButton.Location = new Point(782, 514);
            perk3FizzButton.Name = "perk3FizzButton";
            perk3FizzButton.Size = new Size(141, 70);
            perk3FizzButton.TabIndex = 11;
            perk3FizzButton.Text = "Perk";
            perk3FizzButton.UseVisualStyleBackColor = false;
            perk3FizzButton.Click += perk3FizzButton_Click;
            perk3FizzButton.MouseLeave += customLabel_MouseLeave;
            perk3FizzButton.MouseHover += customLabel_MouseHover;
            // 
            // perk4PopButton
            // 
            perk4PopButton.BackColor = Color.Black;
            perk4PopButton.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            perk4PopButton.ForeColor = Color.White;
            perk4PopButton.Location = new Point(997, 514);
            perk4PopButton.Name = "perk4PopButton";
            perk4PopButton.Size = new Size(141, 70);
            perk4PopButton.TabIndex = 12;
            perk4PopButton.Text = "Perk";
            perk4PopButton.UseVisualStyleBackColor = false;
            perk4PopButton.Click += perk4PopButton_Click;
            perk4PopButton.MouseLeave += customLabel_MouseLeave;
            perk4PopButton.MouseHover += customLabel_MouseHover;
            // 
            // perk1BrewImage
            // 
            perk1BrewImage.BackColor = Color.Transparent;
            perk1BrewImage.BackgroundImage = Properties.Resources.HUDplayerperk;
            perk1BrewImage.BackgroundImageLayout = ImageLayout.Stretch;
            perk1BrewImage.Location = new Point(417, 422);
            perk1BrewImage.Name = "perk1BrewImage";
            perk1BrewImage.Size = new Size(64, 64);
            perk1BrewImage.TabIndex = 13;
            // 
            // perk2ColaImage
            // 
            perk2ColaImage.BackColor = Color.Transparent;
            perk2ColaImage.BackgroundImage = Properties.Resources.HUDplayerperk;
            perk2ColaImage.BackgroundImageLayout = ImageLayout.Stretch;
            perk2ColaImage.Location = new Point(620, 422);
            perk2ColaImage.Name = "perk2ColaImage";
            perk2ColaImage.Size = new Size(64, 64);
            perk2ColaImage.TabIndex = 14;
            // 
            // perk3FizzImage
            // 
            perk3FizzImage.BackColor = Color.Transparent;
            perk3FizzImage.BackgroundImage = Properties.Resources.HUDplayerperk;
            perk3FizzImage.BackgroundImageLayout = ImageLayout.Stretch;
            perk3FizzImage.Location = new Point(819, 422);
            perk3FizzImage.Name = "perk3FizzImage";
            perk3FizzImage.Size = new Size(64, 64);
            perk3FizzImage.TabIndex = 15;
            // 
            // perk4PopImage
            // 
            perk4PopImage.BackColor = Color.Transparent;
            perk4PopImage.BackgroundImage = Properties.Resources.HUDplayerperk;
            perk4PopImage.BackgroundImageLayout = ImageLayout.Stretch;
            perk4PopImage.Location = new Point(1036, 422);
            perk4PopImage.Name = "perk4PopImage";
            perk4PopImage.Size = new Size(64, 64);
            perk4PopImage.TabIndex = 16;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Black;
            exitButton.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(12, 806);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(167, 43);
            exitButton.TabIndex = 18;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            exitButton.MouseLeave += customLabel_MouseLeave;
            exitButton.MouseHover += customLabel_MouseHover;
            // 
            // CustomizeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.customizeBackgroundImage;
            ClientSize = new Size(1584, 861);
            Controls.Add(exitButton);
            Controls.Add(perk4PopImage);
            Controls.Add(perk3FizzImage);
            Controls.Add(perk2ColaImage);
            Controls.Add(perk1BrewImage);
            Controls.Add(perk4PopButton);
            Controls.Add(perk3FizzButton);
            Controls.Add(perk2ColaButton);
            Controls.Add(perk1BrewButton);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomizeMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomizeMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Button perk1BrewButton;
        private Button perk2ColaButton;
        private Button perk3FizzButton;
        private Button perk4PopButton;
        private Panel perk1BrewImage;
        private Panel perk2ColaImage;
        private Panel perk3FizzImage;
        private Panel perk4PopImage;
        private Button exitButton;
    }
}