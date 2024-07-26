namespace ZombieShooter
{
    partial class SettingsMenu
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
            settingsLabel = new Label();
            exitButton = new Button();
            label1 = new Label();
            nameTextBox = new TextBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            checkBox_PerformanceMode = new CheckBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.BackColor = Color.Transparent;
            settingsLabel.Font = new Font("Agency FB", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            settingsLabel.ForeColor = Color.FromArgb(192, 64, 0);
            settingsLabel.Location = new Point(12, 39);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(82, 34);
            settingsLabel.TabIndex = 0;
            settingsLabel.Text = "Settings";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Black;
            exitButton.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(12, 508);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(82, 41);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(64, 96);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(109, 23);
            nameTextBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(188, 95);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(100, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(100, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // checkBox_PerformanceMode
            // 
            checkBox_PerformanceMode.AutoSize = true;
            checkBox_PerformanceMode.Font = new Font("Agency FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_PerformanceMode.ForeColor = Color.FromArgb(192, 64, 0);
            checkBox_PerformanceMode.Location = new Point(141, 148);
            checkBox_PerformanceMode.Name = "checkBox_PerformanceMode";
            checkBox_PerformanceMode.Size = new Size(15, 14);
            checkBox_PerformanceMode.TabIndex = 6;
            checkBox_PerformanceMode.UseVisualStyleBackColor = true;
            checkBox_PerformanceMode.CheckedChanged += checkBox_PerformanceMode_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(123, 24);
            label2.TabIndex = 7;
            label2.Text = "Performance Mode:";
            // 
            // SettingsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.customizeBackgroundImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 561);
            Controls.Add(label2);
            Controls.Add(checkBox_PerformanceMode);
            Controls.Add(button1);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(settingsLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SettingsMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label settingsLabel;
        private Button exitButton;
        private Label label1;
        private TextBox nameTextBox;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private CheckBox checkBox_PerformanceMode;
        private Label label2;
    }
}