
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
            moreInfoLab = new Label();
            EatsLab = new Label();
            sleepLab1 = new Label();
            lionAgelab = new Label();
            lionGenderlab = new Label();
            lionHasManelab = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // lionChoice
            // 
            lionChoice.FormattingEnabled = true;
            lionChoice.Items.AddRange(new object[] { "Peter", "Lucy" });
            lionChoice.Location = new Point(286, 228);
            lionChoice.Margin = new Padding(3, 4, 3, 4);
            lionChoice.Name = "lionChoice";
            lionChoice.Size = new Size(342, 28);
            lionChoice.TabIndex = 0;
            lionChoice.Text = "Choose a Lion:";
            lionChoice.SelectedIndexChanged += lionChoice_SelectedIndexChanged;
            // 
            // lionNamelab
            // 
            lionNamelab.AutoSize = true;
            lionNamelab.Location = new Point(72, 296);
            lionNamelab.Name = "lionNamelab";
            lionNamelab.Size = new Size(95, 20);
            lionNamelab.TabIndex = 1;
            lionNamelab.Text = "lionNamelab";
            lionNamelab.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(354, 523);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(170, 31);
            button1.TabIndex = 2;
            button1.Text = "More info...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // moreInfoLab
            // 
            moreInfoLab.AutoSize = true;
            moreInfoLab.Location = new Point(409, 455);
            moreInfoLab.Name = "moreInfoLab";
            moreInfoLab.Size = new Size(70, 20);
            moreInfoLab.TabIndex = 3;
            moreInfoLab.Text = "moreInfo";
            moreInfoLab.Visible = false;
            // 
            // EatsLab
            // 
            EatsLab.AutoSize = true;
            EatsLab.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EatsLab.Location = new Point(143, 27);
            EatsLab.Name = "EatsLab";
            EatsLab.Size = new Size(65, 37);
            EatsLab.TabIndex = 4;
            EatsLab.Text = "Eats";
            EatsLab.TextAlign = ContentAlignment.TopCenter;
            // 
            // sleepLab1
            // 
            sleepLab1.AutoSize = true;
            sleepLab1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sleepLab1.Location = new Point(59, 93);
            sleepLab1.Name = "sleepLab1";
            sleepLab1.Size = new Size(68, 28);
            sleepLab1.TabIndex = 5;
            sleepLab1.Text = "Sleeps";
            sleepLab1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lionAgelab
            // 
            lionAgelab.AutoSize = true;
            lionAgelab.Location = new Point(72, 331);
            lionAgelab.Name = "lionAgelab";
            lionAgelab.Size = new Size(82, 20);
            lionAgelab.TabIndex = 6;
            lionAgelab.Text = "lionAgelab";
            lionAgelab.Visible = false;
            // 
            // lionGenderlab
            // 
            lionGenderlab.AutoSize = true;
            lionGenderlab.Location = new Point(72, 364);
            lionGenderlab.Name = "lionGenderlab";
            lionGenderlab.Size = new Size(103, 20);
            lionGenderlab.TabIndex = 7;
            lionGenderlab.Text = "lionGenderlab";
            lionGenderlab.Visible = false;
            // 
            // lionHasManelab
            // 
            lionHasManelab.AutoSize = true;
            lionHasManelab.Location = new Point(72, 401);
            lionHasManelab.Name = "lionHasManelab";
            lionHasManelab.Size = new Size(117, 20);
            lionHasManelab.TabIndex = 8;
            lionHasManelab.Text = "lionHasManelab";
            lionHasManelab.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(882, 553);
            button2.Name = "button2";
            button2.Size = new Size(102, 35);
            button2.TabIndex = 9;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ViewLions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 600);
            Controls.Add(button2);
            Controls.Add(lionHasManelab);
            Controls.Add(lionGenderlab);
            Controls.Add(lionAgelab);
            Controls.Add(sleepLab1);
            Controls.Add(EatsLab);
            Controls.Add(moreInfoLab);
            Controls.Add(button1);
            Controls.Add(lionNamelab);
            Controls.Add(lionChoice);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1014, 647);
            MinimumSize = new Size(1014, 647);
            Name = "ViewLions";
            Text = "Lions at City Zoo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox lionChoice;
        private Label lionNamelab;
        private Button button1;
        private Label moreInfoLab;
        private Label EatsLab;
        private Label sleepLab1;
        private Label lionAgelab;
        private Label lionGenderlab;
        private Label lionHasManelab;
        private Button button2;
    }
}