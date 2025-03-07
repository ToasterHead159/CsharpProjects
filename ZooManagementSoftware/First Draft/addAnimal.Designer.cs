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
            aniAge = new TextBox();
            aniGender = new TextBox();
            textBos = new TextBox();
            textBox6 = new TextBox();
            aniNamelab = new Label();
            aniAgeLab = new Label();
            aniGenlab = new Label();
            hasManelab = new Label();
            lionNameLab = new Label();
            parNamelab = new Label();
            yesMane = new RadioButton();
            noMane = new RadioButton();
            aniAgecount = new NumericUpDown();
            addAniBtn2 = new Button();
            testLab1 = new Label();
            testLab2 = new Label();
            ((System.ComponentModel.ISupportInitialize)aniAgecount).BeginInit();
            SuspendLayout();
            // 
            // specSelect
            // 
            specSelect.FormattingEnabled = true;
            specSelect.Items.AddRange(new object[] { "Lion", "Parrot", "Turtle" });
            specSelect.Location = new Point(318, 26);
            specSelect.Name = "specSelect";
            specSelect.Size = new Size(121, 23);
            specSelect.TabIndex = 0;
            specSelect.Text = "Choose a species";
            specSelect.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // aniName
            // 
            aniName.Location = new Point(318, 87);
            aniName.Name = "aniName";
            aniName.Size = new Size(121, 23);
            aniName.TabIndex = 1;
            aniName.Visible = false;
            aniName.TextChanged += aniName_TextChanged;
            // 
            // aniAge
            // 
            aniAge.Location = new Point(118, 279);
            aniAge.Name = "aniAge";
            aniAge.Size = new Size(121, 23);
            aniAge.TabIndex = 2;
            aniAge.Visible = false;
            // 
            // aniGender
            // 
            aniGender.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aniGender.Location = new Point(318, 181);
            aniGender.Name = "aniGender";
            aniGender.Size = new Size(121, 23);
            aniGender.TabIndex = 3;
            aniGender.Visible = false;
            aniGender.TextChanged += aniGender_TextChanged;
            // 
            // textBos
            // 
            textBos.Location = new Point(318, 279);
            textBos.Name = "textBos";
            textBos.Size = new Size(121, 23);
            textBos.TabIndex = 4;
            textBos.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(478, 279);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(121, 23);
            textBox6.TabIndex = 6;
            textBox6.Visible = false;
            // 
            // aniNamelab
            // 
            aniNamelab.AutoSize = true;
            aniNamelab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aniNamelab.Location = new Point(284, 64);
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
            aniAgeLab.Location = new Point(297, 113);
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
            aniGenlab.Location = new Point(284, 157);
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
            hasManelab.Location = new Point(290, 207);
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
            lionNameLab.Location = new Point(297, 64);
            lionNameLab.Name = "lionNameLab";
            lionNameLab.Size = new Size(212, 21);
            lionNameLab.TabIndex = 11;
            lionNameLab.Text = "What is the name of the lion?";
            lionNameLab.Visible = false;
            // 
            // parNamelab
            // 
            parNamelab.AutoSize = true;
            parNamelab.BackColor = Color.WhiteSmoke;
            parNamelab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parNamelab.Location = new Point(281, 63);
            parNamelab.Name = "parNamelab";
            parNamelab.Size = new Size(228, 21);
            parNamelab.TabIndex = 12;
            parNamelab.Text = "What is the name of the Parrot?";
            parNamelab.Visible = false;
            // 
            // yesMane
            // 
            yesMane.AutoSize = true;
            yesMane.Location = new Point(329, 241);
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
            noMane.Location = new Point(411, 241);
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
            aniAgecount.Location = new Point(318, 137);
            aniAgecount.Name = "aniAgecount";
            aniAgecount.Size = new Size(120, 23);
            aniAgecount.TabIndex = 17;
            aniAgecount.Visible = false;
            aniAgecount.ValueChanged += aniAgecount_ValueChanged;
            // 
            // addAniBtn2
            // 
            addAniBtn2.Location = new Point(348, 372);
            addAniBtn2.Name = "addAniBtn2";
            addAniBtn2.Size = new Size(90, 34);
            addAniBtn2.TabIndex = 18;
            addAniBtn2.Text = "Submit";
            addAniBtn2.UseVisualStyleBackColor = true;
            addAniBtn2.Click += button1_Click;
            // 
            // testLab1
            // 
            testLab1.AutoSize = true;
            testLab1.Location = new Point(216, 351);
            testLab1.Name = "testLab1";
            testLab1.Size = new Size(38, 15);
            testLab1.TabIndex = 19;
            testLab1.Text = "label1";
            testLab1.Visible = false;
            // 
            // testLab2
            // 
            testLab2.AutoSize = true;
            testLab2.Location = new Point(658, 95);
            testLab2.Name = "testLab2";
            testLab2.Size = new Size(38, 15);
            testLab2.TabIndex = 20;
            testLab2.Text = "label1";
            testLab2.Visible = false;
            // 
            // addAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(testLab2);
            Controls.Add(testLab1);
            Controls.Add(addAniBtn2);
            Controls.Add(aniAgecount);
            Controls.Add(noMane);
            Controls.Add(yesMane);
            Controls.Add(parNamelab);
            Controls.Add(lionNameLab);
            Controls.Add(hasManelab);
            Controls.Add(aniGenlab);
            Controls.Add(aniAgeLab);
            Controls.Add(aniNamelab);
            Controls.Add(textBox6);
            Controls.Add(textBos);
            Controls.Add(aniGender);
            Controls.Add(aniAge);
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
        private TextBox aniAge;
        private TextBox aniGender;
        private TextBox textBos;
        private TextBox textBox6;
        private Label aniNamelab;
        private Label aniAgeLab;
        private Label aniGenlab;
        private Label hasManelab;
        private Label lionNameLab;
        private Label parNamelab;
        private RadioButton yesMane;
        private RadioButton noMane;
        private NumericUpDown aniAgecount;
        private Button addAniBtn2;
        private Label testLab1;
        private Label testLab2;
    }
}