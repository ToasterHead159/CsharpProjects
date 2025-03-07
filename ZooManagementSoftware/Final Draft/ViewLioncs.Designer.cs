
namespace ZooManageEncycloFA2
{
    partial class ViewLions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLions));
            lionChoice = new ComboBox();
            lionNamelab = new Label();
            button1 = new Button();
            climbLab = new Label();
            EatsLab = new Label();
            sleepLab1 = new Label();
            lionAgelab = new Label();
            lionGenderlab = new Label();
            lionHasManelab = new Label();
            button2 = new Button();
            swimlab = new Label();
            Hablab = new Label();
            anilab2 = new Label();
            foodlab2 = new Label();
            SuspendLayout();
            // 
            // lionChoice
            // 
            lionChoice.FormattingEnabled = true;
            lionChoice.Location = new Point(249, 150);
            lionChoice.Name = "lionChoice";
            lionChoice.Size = new Size(300, 23);
            lionChoice.TabIndex = 0;
            lionChoice.Text = "Choose a Lion:";
            lionChoice.SelectedIndexChanged += lionChoice_SelectedIndexChanged;
            // 
            // lionNamelab
            // 
            lionNamelab.AutoSize = true;
            lionNamelab.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lionNamelab.Location = new Point(63, 194);
            lionNamelab.Name = "lionNamelab";
            lionNamelab.Size = new Size(75, 15);
            lionNamelab.TabIndex = 1;
            lionNamelab.Text = "lionNamelab";
            lionNamelab.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(310, 392);
            button1.Name = "button1";
            button1.Size = new Size(149, 23);
            button1.TabIndex = 2;
            button1.Text = "More info...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // climbLab
            // 
            climbLab.AutoSize = true;
            climbLab.Location = new Point(63, 307);
            climbLab.Name = "climbLab";
            climbLab.Size = new Size(52, 15);
            climbLab.TabIndex = 3;
            climbLab.Text = "climable";
            climbLab.Visible = false;
            // 
            // EatsLab
            // 
            EatsLab.AutoSize = true;
            EatsLab.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EatsLab.Location = new Point(123, 9);
            EatsLab.Name = "EatsLab";
            EatsLab.Size = new Size(51, 30);
            EatsLab.TabIndex = 4;
            EatsLab.Text = "Eats";
            EatsLab.TextAlign = ContentAlignment.TopCenter;
            EatsLab.TextChanged += EatsLab_TextChanged;
            // 
            // sleepLab1
            // 
            sleepLab1.AutoSize = true;
            sleepLab1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sleepLab1.Location = new Point(60, 45);
            sleepLab1.Name = "sleepLab1";
            sleepLab1.Size = new Size(55, 21);
            sleepLab1.TabIndex = 5;
            sleepLab1.Text = "Sleeps";
            sleepLab1.TextAlign = ContentAlignment.TopCenter;
            sleepLab1.TextChanged += sleepLab1_TextChanged;
            // 
            // lionAgelab
            // 
            lionAgelab.AutoSize = true;
            lionAgelab.Location = new Point(63, 221);
            lionAgelab.Name = "lionAgelab";
            lionAgelab.Size = new Size(64, 15);
            lionAgelab.TabIndex = 6;
            lionAgelab.Text = "lionAgelab";
            lionAgelab.Visible = false;
            // 
            // lionGenderlab
            // 
            lionGenderlab.AutoSize = true;
            lionGenderlab.Location = new Point(63, 250);
            lionGenderlab.Name = "lionGenderlab";
            lionGenderlab.Size = new Size(81, 15);
            lionGenderlab.TabIndex = 7;
            lionGenderlab.Text = "lionGenderlab";
            lionGenderlab.Visible = false;
            // 
            // lionHasManelab
            // 
            lionHasManelab.AutoSize = true;
            lionHasManelab.Location = new Point(63, 279);
            lionHasManelab.Name = "lionHasManelab";
            lionHasManelab.Size = new Size(93, 15);
            lionHasManelab.TabIndex = 8;
            lionHasManelab.Text = "lionHasManelab";
            lionHasManelab.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(772, 415);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(89, 26);
            button2.TabIndex = 9;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // swimlab
            // 
            swimlab.AutoSize = true;
            swimlab.Location = new Point(63, 333);
            swimlab.Name = "swimlab";
            swimlab.Size = new Size(57, 15);
            swimlab.TabIndex = 10;
            swimlab.Text = "swimable";
            swimlab.Visible = false;
            // 
            // Hablab
            // 
            Hablab.AutoSize = true;
            Hablab.Location = new Point(421, 194);
            Hablab.Name = "Hablab";
            Hablab.Size = new Size(44, 15);
            Hablab.TabIndex = 11;
            Hablab.Text = "habitat";
            Hablab.Visible = false;
            // 
            // anilab2
            // 
            anilab2.AutoSize = true;
            anilab2.Location = new Point(421, 221);
            anilab2.Name = "anilab2";
            anilab2.Size = new Size(47, 15);
            anilab2.TabIndex = 12;
            anilab2.Text = "aniType";
            anilab2.Visible = false;
            // 
            // foodlab2
            // 
            foodlab2.AutoSize = true;
            foodlab2.Location = new Point(421, 250);
            foodlab2.Name = "foodlab2";
            foodlab2.Size = new Size(55, 15);
            foodlab2.TabIndex = 13;
            foodlab2.Text = "foodtype";
            foodlab2.Visible = false;
            // 
            // ViewLions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 456);
            Controls.Add(foodlab2);
            Controls.Add(anilab2);
            Controls.Add(Hablab);
            Controls.Add(swimlab);
            Controls.Add(button2);
            Controls.Add(lionHasManelab);
            Controls.Add(lionGenderlab);
            Controls.Add(lionAgelab);
            Controls.Add(sleepLab1);
            Controls.Add(EatsLab);
            Controls.Add(climbLab);
            Controls.Add(button1);
            Controls.Add(lionNamelab);
            Controls.Add(lionChoice);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(889, 495);
            MinimumSize = new Size(889, 495);
            Name = "ViewLions";
            Text = "Lions at City Zoo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox lionChoice;
        private Label lionNamelab;
        private Button button1;
        private Label climbLab;
        private Label EatsLab;
        private Label sleepLab1;
        private Label lionAgelab;
        private Label lionGenderlab;
        private Label lionHasManelab;
        private Button button2;
        private Label swimlab;
        private Label Hablab;
        private Label anilab2;
        private Label foodlab2;
    }
}