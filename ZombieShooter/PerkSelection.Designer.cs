namespace ZombieShooter
{
    partial class PerkSelection
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
            buttonJuggernog = new Button();
            buttonQuickRevive = new Button();
            buttonSpeedCola = new Button();
            buttonStaminUp = new Button();
            buttonDoubleTap2 = new Button();
            label1 = new Label();
            PerkInfoDescription = new Label();
            PerkInfoName = new Label();
            PerkInfoImage = new PictureBox();
            buttonWidowsWine = new Button();
            ((System.ComponentModel.ISupportInitialize)PerkInfoImage).BeginInit();
            SuspendLayout();
            // 
            // buttonJuggernog
            // 
            buttonJuggernog.BackColor = Color.Transparent;
            buttonJuggernog.BackgroundImage = Properties.Resources.juggernogPerkIcon;
            buttonJuggernog.BackgroundImageLayout = ImageLayout.Stretch;
            buttonJuggernog.Location = new Point(119, 69);
            buttonJuggernog.Name = "buttonJuggernog";
            buttonJuggernog.Size = new Size(80, 80);
            buttonJuggernog.TabIndex = 0;
            buttonJuggernog.UseVisualStyleBackColor = false;
            buttonJuggernog.Click += buttonPerk_Click;
            buttonJuggernog.MouseHover += buttonPerk_Hover;
            // 
            // buttonQuickRevive
            // 
            buttonQuickRevive.BackColor = Color.Transparent;
            buttonQuickRevive.BackgroundImage = Properties.Resources.quickRevivePerkIcon;
            buttonQuickRevive.BackgroundImageLayout = ImageLayout.Stretch;
            buttonQuickRevive.Location = new Point(14, 69);
            buttonQuickRevive.Name = "buttonQuickRevive";
            buttonQuickRevive.Size = new Size(80, 80);
            buttonQuickRevive.TabIndex = 1;
            buttonQuickRevive.UseVisualStyleBackColor = false;
            buttonQuickRevive.Click += buttonPerk_Click;
            buttonQuickRevive.MouseHover += buttonPerk_Hover;
            // 
            // buttonSpeedCola
            // 
            buttonSpeedCola.BackColor = Color.Transparent;
            buttonSpeedCola.BackgroundImage = Properties.Resources.speedColaPerkIcon;
            buttonSpeedCola.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSpeedCola.Location = new Point(225, 69);
            buttonSpeedCola.Name = "buttonSpeedCola";
            buttonSpeedCola.Size = new Size(80, 80);
            buttonSpeedCola.TabIndex = 2;
            buttonSpeedCola.UseVisualStyleBackColor = false;
            buttonSpeedCola.Click += buttonPerk_Click;
            buttonSpeedCola.MouseHover += buttonPerk_Hover;
            // 
            // buttonStaminUp
            // 
            buttonStaminUp.BackColor = Color.Transparent;
            buttonStaminUp.BackgroundImage = Properties.Resources.staminUpPerkIcon;
            buttonStaminUp.BackgroundImageLayout = ImageLayout.Stretch;
            buttonStaminUp.Location = new Point(451, 69);
            buttonStaminUp.Name = "buttonStaminUp";
            buttonStaminUp.Size = new Size(80, 80);
            buttonStaminUp.TabIndex = 3;
            buttonStaminUp.UseVisualStyleBackColor = false;
            buttonStaminUp.Click += buttonPerk_Click;
            buttonStaminUp.MouseHover += buttonPerk_Hover;
            // 
            // buttonDoubleTap2
            // 
            buttonDoubleTap2.BackColor = Color.Transparent;
            buttonDoubleTap2.BackgroundImage = Properties.Resources.doubleTapPerkICon;
            buttonDoubleTap2.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDoubleTap2.Location = new Point(337, 69);
            buttonDoubleTap2.Name = "buttonDoubleTap2";
            buttonDoubleTap2.Size = new Size(80, 80);
            buttonDoubleTap2.TabIndex = 4;
            buttonDoubleTap2.UseVisualStyleBackColor = false;
            buttonDoubleTap2.Click += buttonPerk_Click;
            buttonDoubleTap2.MouseHover += buttonPerk_Hover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Agency FB", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 40);
            label1.TabIndex = 5;
            label1.Text = "Perks:";
            // 
            // PerkInfoDescription
            // 
            PerkInfoDescription.BackColor = Color.Transparent;
            PerkInfoDescription.Font = new Font("Agency FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PerkInfoDescription.ForeColor = Color.FromArgb(255, 128, 0);
            PerkInfoDescription.Location = new Point(1027, 206);
            PerkInfoDescription.Name = "PerkInfoDescription";
            PerkInfoDescription.Size = new Size(227, 194);
            PerkInfoDescription.TabIndex = 6;
            PerkInfoDescription.Text = "Description:";
            // 
            // PerkInfoName
            // 
            PerkInfoName.BackColor = Color.Transparent;
            PerkInfoName.Font = new Font("Agency FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PerkInfoName.ForeColor = Color.FromArgb(255, 128, 0);
            PerkInfoName.Location = new Point(1026, 69);
            PerkInfoName.Name = "PerkInfoName";
            PerkInfoName.Size = new Size(228, 26);
            PerkInfoName.TabIndex = 7;
            PerkInfoName.Text = "Name:";
            // 
            // PerkInfoImage
            // 
            PerkInfoImage.BackColor = Color.Transparent;
            PerkInfoImage.BackgroundImageLayout = ImageLayout.Stretch;
            PerkInfoImage.Location = new Point(1030, 107);
            PerkInfoImage.Name = "PerkInfoImage";
            PerkInfoImage.Size = new Size(90, 90);
            PerkInfoImage.TabIndex = 8;
            PerkInfoImage.TabStop = false;
            // 
            // buttonWidowsWine
            // 
            buttonWidowsWine.BackColor = Color.Transparent;
            buttonWidowsWine.BackgroundImage = Properties.Resources.widowsWinePerkIcon;
            buttonWidowsWine.BackgroundImageLayout = ImageLayout.Stretch;
            buttonWidowsWine.Location = new Point(563, 69);
            buttonWidowsWine.Name = "buttonWidowsWine";
            buttonWidowsWine.Size = new Size(80, 80);
            buttonWidowsWine.TabIndex = 9;
            buttonWidowsWine.UseVisualStyleBackColor = false;
            buttonWidowsWine.Click += buttonPerk_Click;
            buttonWidowsWine.MouseHover += buttonPerk_Hover;
            // 
            // PerkSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.customizeBackgroundImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1268, 684);
            Controls.Add(buttonWidowsWine);
            Controls.Add(PerkInfoImage);
            Controls.Add(PerkInfoName);
            Controls.Add(PerkInfoDescription);
            Controls.Add(label1);
            Controls.Add(buttonDoubleTap2);
            Controls.Add(buttonStaminUp);
            Controls.Add(buttonSpeedCola);
            Controls.Add(buttonQuickRevive);
            Controls.Add(buttonJuggernog);
            Name = "PerkSelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PerkSelection";
            ((System.ComponentModel.ISupportInitialize)PerkInfoImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonJuggernog;
        private Button buttonQuickRevive;
        private Button buttonSpeedCola;
        private Button buttonStaminUp;
        private Button buttonDoubleTap2;
        private Label label1;
        private Label PerkInfoDescription;
        private Label PerkInfoName;
        private PictureBox PerkInfoImage;
        private Button buttonWidowsWine;
    }
}