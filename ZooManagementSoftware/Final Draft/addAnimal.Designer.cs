namespace ZooManageEncycloFA2
{
    partial class addAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAnimal));
            specSelect = new ComboBox();
            aniName = new TextBox();
            aniGender = new TextBox();
            aniNamelab = new Label();
            aniAgeLab = new Label();
            aniGenlab = new Label();
            hasManelab = new Label();
            lionNameLab = new Label();
            yesMane = new RadioButton();
            noMane = new RadioButton();
            aniAgecount = new NumericUpDown();
            addAniBtn2 = new Button();
            testLab2 = new Label();
            MessLab = new Label();
            checker1lab = new Label();
            checklab2 = new Label();
            label1 = new Label();
            clsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)aniAgecount).BeginInit();
            SuspendLayout();
            // 
            // specSelect
            // 
            specSelect.FormattingEnabled = true;
            specSelect.Items.AddRange(new object[] { "Lion" });
            specSelect.Location = new Point(337, 73);
            specSelect.Name = "specSelect";
            specSelect.Size = new Size(121, 23);
            specSelect.TabIndex = 0;
            specSelect.Text = "Choose a species";
            specSelect.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // aniName
            // 
            aniName.Location = new Point(337, 134);
            aniName.Name = "aniName";
            aniName.Size = new Size(121, 23);
            aniName.TabIndex = 1;
            aniName.Visible = false;
            aniName.TextChanged += aniName_TextChanged;
            // 
            // aniGender
            // 
            aniGender.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aniGender.Location = new Point(337, 228);
            aniGender.Name = "aniGender";
            aniGender.Size = new Size(121, 23);
            aniGender.TabIndex = 3;
            aniGender.Visible = false;
            aniGender.TextChanged += aniGender_TextChanged;
            // 
            // aniNamelab
            // 
            aniNamelab.AutoSize = true;
            aniNamelab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aniNamelab.Location = new Point(303, 111);
            aniNamelab.Name = "aniNamelab";
            aniNamelab.Size = new Size(233, 21);
            aniNamelab.TabIndex = 7;
            aniNamelab.Text = "What is the name of the animal?";
            aniNamelab.Visible = false;
            // 
            // aniAgeLab
            // 
            aniAgeLab.AutoSize = true;
            aniAgeLab.BackColor = Color.WhiteSmoke;
            aniAgeLab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aniAgeLab.Location = new Point(316, 160);
            aniAgeLab.Name = "aniAgeLab";
            aniAgeLab.Size = new Size(167, 21);
            aniAgeLab.TabIndex = 8;
            aniAgeLab.Text = "How old is the animal?";
            aniAgeLab.Visible = false;
            // 
            // aniGenlab
            // 
            aniGenlab.AutoSize = true;
            aniGenlab.BackColor = Color.WhiteSmoke;
            aniGenlab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aniGenlab.Location = new Point(303, 204);
            aniGenlab.Name = "aniGenlab";
            aniGenlab.Size = new Size(206, 21);
            aniGenlab.TabIndex = 9;
            aniGenlab.Text = "What is the animals gender?";
            aniGenlab.Visible = false;
            // 
            // hasManelab
            // 
            hasManelab.AutoSize = true;
            hasManelab.BackColor = Color.WhiteSmoke;
            hasManelab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hasManelab.Location = new Point(309, 254);
            hasManelab.Name = "hasManelab";
            hasManelab.Size = new Size(200, 21);
            hasManelab.TabIndex = 10;
            hasManelab.Text = "Does the lion have a mane?";
            hasManelab.Visible = false;
            // 
            // lionNameLab
            // 
            lionNameLab.AutoSize = true;
            lionNameLab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lionNameLab.Location = new Point(316, 111);
            lionNameLab.Name = "lionNameLab";
            lionNameLab.Size = new Size(212, 21);
            lionNameLab.TabIndex = 11;
            lionNameLab.Text = "What is the name of the lion?";
            lionNameLab.Visible = false;
            // 
            // yesMane
            // 
            yesMane.AutoSize = true;
            yesMane.Location = new Point(348, 288);
            yesMane.Name = "yesMane";
            yesMane.Size = new Size(42, 19);
            yesMane.TabIndex = 15;
            yesMane.TabStop = true;
            yesMane.Text = "Yes";
            yesMane.UseVisualStyleBackColor = true;
            yesMane.Visible = false;
            yesMane.CheckedChanged += yesMane_CheckedChanged;
            // 
            // noMane
            // 
            noMane.AutoSize = true;
            noMane.Location = new Point(430, 288);
            noMane.Name = "noMane";
            noMane.Size = new Size(41, 19);
            noMane.TabIndex = 16;
            noMane.TabStop = true;
            noMane.Text = "No";
            noMane.UseVisualStyleBackColor = true;
            noMane.Visible = false;
            noMane.CheckedChanged += noMane_CheckedChanged;
            // 
            // aniAgecount
            // 
            aniAgecount.Location = new Point(337, 184);
            aniAgecount.Name = "aniAgecount";
            aniAgecount.Size = new Size(120, 23);
            aniAgecount.TabIndex = 17;
            aniAgecount.Visible = false;
            aniAgecount.ValueChanged += aniAgecount_ValueChanged;
            // 
            // addAniBtn2
            // 
            addAniBtn2.Location = new Point(348, 393);
            addAniBtn2.Name = "addAniBtn2";
            addAniBtn2.Size = new Size(90, 34);
            addAniBtn2.TabIndex = 18;
            addAniBtn2.Text = "Submit";
            addAniBtn2.UseVisualStyleBackColor = true;
            addAniBtn2.Click += button1_Click;
            // 
            // testLab2
            // 
            testLab2.AutoSize = true;
            testLab2.Location = new Point(658, 95);
            testLab2.Name = "testLab2";
            testLab2.Size = new Size(0, 15);
            testLab2.TabIndex = 20;
            testLab2.Visible = false;
            // 
            // MessLab
            // 
            MessLab.AutoSize = true;
            MessLab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessLab.Location = new Point(268, 352);
            MessLab.Name = "MessLab";
            MessLab.Size = new Size(78, 21);
            MessLab.TabIndex = 21;
            MessLab.Text = "messages";
            MessLab.Visible = false;
            MessLab.TextChanged += MessLab_TextChanged;
            // 
            // checker1lab
            // 
            checker1lab.AutoSize = true;
            checker1lab.Location = new Point(588, 90);
            checker1lab.Name = "checker1lab";
            checker1lab.Size = new Size(54, 15);
            checker1lab.TabIndex = 22;
            checker1lab.Text = "checker1";
            checker1lab.Visible = false;
            // 
            // checklab2
            // 
            checklab2.AutoSize = true;
            checklab2.Location = new Point(587, 134);
            checklab2.Name = "checklab2";
            checklab2.Size = new Size(54, 15);
            checklab2.TabIndex = 23;
            checklab2.Text = "checker2";
            checklab2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 21);
            label1.Name = "label1";
            label1.Size = new Size(461, 32);
            label1.TabIndex = 24;
            label1.Text = "N.B. Only Lions can be added at this time!";
            // 
            // clsBtn
            // 
            clsBtn.Location = new Point(713, 415);
            clsBtn.Name = "clsBtn";
            clsBtn.Size = new Size(75, 23);
            clsBtn.TabIndex = 25;
            clsBtn.Text = "Close";
            clsBtn.UseVisualStyleBackColor = true;
            clsBtn.Click += clsBtn_Click;
            // 
            // addAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(clsBtn);
            Controls.Add(label1);
            Controls.Add(checklab2);
            Controls.Add(checker1lab);
            Controls.Add(MessLab);
            Controls.Add(testLab2);
            Controls.Add(addAniBtn2);
            Controls.Add(aniAgecount);
            Controls.Add(noMane);
            Controls.Add(yesMane);
            Controls.Add(lionNameLab);
            Controls.Add(hasManelab);
            Controls.Add(aniGenlab);
            Controls.Add(aniAgeLab);
            Controls.Add(aniNamelab);
            Controls.Add(aniGender);
            Controls.Add(aniName);
            Controls.Add(specSelect);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "addAnimal";
            Text = "Add a New Animal";
            ((System.ComponentModel.ISupportInitialize)aniAgecount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox specSelect;
        private TextBox aniName;
        private TextBox aniGender;
        private Label aniNamelab;
        private Label aniAgeLab;
        private Label aniGenlab;
        private Label hasManelab;
        private Label lionNameLab;
        private RadioButton yesMane;
        private RadioButton noMane;
        private NumericUpDown aniAgecount;
        private Button addAniBtn2;
        private Label testLab2;
        private Label MessLab;
        private Label checker1lab;
        private Label checklab2;
        private Label label1;
        private Button clsBtn;
    }
}