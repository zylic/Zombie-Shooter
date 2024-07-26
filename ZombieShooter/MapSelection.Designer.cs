namespace ZombieShooter
{
    partial class MapSelection
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
            testingMap = new PictureBox();
            originsMap = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)testingMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)originsMap).BeginInit();
            SuspendLayout();
            // 
            // testingMap
            // 
            testingMap.BackColor = Color.Black;
            testingMap.BackgroundImage = Properties.Resources.testingMapImage;
            testingMap.BackgroundImageLayout = ImageLayout.Stretch;
            testingMap.Location = new Point(49, 43);
            testingMap.Name = "testingMap";
            testingMap.Size = new Size(79, 79);
            testingMap.TabIndex = 0;
            testingMap.TabStop = false;
            testingMap.Click += MapButton_Click;
            // 
            // originsMap
            // 
            originsMap.BackColor = Color.Black;
            originsMap.BackgroundImage = Properties.Resources.originsMapImage;
            originsMap.Location = new Point(147, 43);
            originsMap.Name = "originsMap";
            originsMap.Size = new Size(79, 79);
            originsMap.TabIndex = 1;
            originsMap.TabStop = false;
            originsMap.Click += MapButton_Click;
            // 
            // MapSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.zombiesBackgroundImage;
            ClientSize = new Size(800, 450);
            Controls.Add(originsMap);
            Controls.Add(testingMap);
            Name = "MapSelection";
            Text = "MapSelection";
            Load += MapSelection_Load;
            ((System.ComponentModel.ISupportInitialize)testingMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)originsMap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox testingMap;
        private PictureBox originsMap;
    }
}