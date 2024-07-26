namespace ZombieShooter
{
    partial class CHEATMENU
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(327, 47);
            label1.TabIndex = 0;
            label1.Text = "ZYLCI CHEAT MENU";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.BlueViolet;
            button1.Location = new Point(69, 94);
            button1.Name = "button1";
            button1.Size = new Size(227, 89);
            button1.TabIndex = 1;
            button1.Text = "GIVE 10K POINT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CHEATMENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "CHEATMENU";
            Text = "CHEATMENU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}