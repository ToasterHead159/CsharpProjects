namespace ZooManageEncycloFA2
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            visitBtn1 = new Button();
            ManBtn1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // visitBtn1
            // 
            visitBtn1.Location = new Point(64, 383);
            visitBtn1.Margin = new Padding(3, 4, 3, 4);
            visitBtn1.Name = "visitBtn1";
            visitBtn1.Size = new Size(194, 73);
            visitBtn1.TabIndex = 0;
            visitBtn1.Text = "Visitors";
            visitBtn1.UseVisualStyleBackColor = true;
            visitBtn1.Click += visitBtn1_Click;
            // 
            // ManBtn1
            // 
            ManBtn1.Location = new Point(469, 383);
            ManBtn1.Margin = new Padding(3, 4, 3, 4);
            ManBtn1.Name = "ManBtn1";
            ManBtn1.Size = new Size(216, 73);
            ManBtn1.TabIndex = 1;
            ManBtn1.Text = "Zoo Management";
            ManBtn1.UseVisualStyleBackColor = true;
            ManBtn1.Click += ManBtn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("CMG Sans Medium Cn CAPS", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 81);
            label1.Name = "label1";
            label1.Size = new Size(281, 83);
            label1.TabIndex = 2;
            label1.Text = "City Zoo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("CMG Sans Medium Cn CAPS", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(133, 169);
            label2.Name = "label2";
            label2.Size = new Size(469, 83);
            label2.TabIndex = 3;
            label2.Text = "Welcomes You";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Picture1_50;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(751, 557);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ManBtn1);
            Controls.Add(visitBtn1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "City Zoo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button visitBtn1;
        private Button ManBtn1;
        private Label label1;
        private Label label2;
    }
}
