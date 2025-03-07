
namespace ZooManageEncycloFA2
{
    partial class ViewParrots
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewParrots));
            eatsPar = new Label();
            sleepPar = new Label();
            selParrots = new ComboBox();
            parName = new Label();
            parAge = new Label();
            parGen = new Label();
            parFcolor = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            parHabi = new Label();
            flylab = new Label();
            foodLab = new Label();
            aniLab = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // eatsPar
            // 
            eatsPar.AutoSize = true;
            eatsPar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eatsPar.Location = new Point(132, 35);
            eatsPar.Name = "eatsPar";
            eatsPar.Size = new Size(51, 30);
            eatsPar.TabIndex = 0;
            eatsPar.Text = "Eats";
            eatsPar.TextChanged += eatsPar_TextChanged;
            // 
            // sleepPar
            // 
            sleepPar.AutoSize = true;
            sleepPar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sleepPar.Location = new Point(55, 72);
            sleepPar.Name = "sleepPar";
            sleepPar.Size = new Size(68, 21);
            sleepPar.TabIndex = 1;
            sleepPar.Text = "sleepPar";
            sleepPar.TextChanged += sleepPar_TextChanged;
            // 
            // selParrots
            // 
            selParrots.FormattingEnabled = true;
            selParrots.Location = new Point(402, 152);
            selParrots.Margin = new Padding(3, 2, 3, 2);
            selParrots.Name = "selParrots";
            selParrots.Size = new Size(133, 23);
            selParrots.TabIndex = 2;
            selParrots.Text = "Choose a Parrot:";
            selParrots.SelectedIndexChanged += selParrots_SelectedIndexChanged;
            // 
            // parName
            // 
            parName.AutoSize = true;
            parName.Location = new Point(55, 199);
            parName.Name = "parName";
            parName.Size = new Size(56, 15);
            parName.TabIndex = 3;
            parName.Text = "ParName";
            parName.Visible = false;
            // 
            // parAge
            // 
            parAge.AutoSize = true;
            parAge.Location = new Point(55, 227);
            parAge.Name = "parAge";
            parAge.Size = new Size(45, 15);
            parAge.TabIndex = 4;
            parAge.Text = "parAge";
            parAge.Visible = false;
            // 
            // parGen
            // 
            parGen.AutoSize = true;
            parGen.Location = new Point(55, 252);
            parGen.Name = "parGen";
            parGen.Size = new Size(45, 15);
            parGen.TabIndex = 5;
            parGen.Text = "parGen";
            parGen.Visible = false;
            // 
            // parFcolor
            // 
            parFcolor.AutoSize = true;
            parFcolor.Location = new Point(55, 281);
            parFcolor.Name = "parFcolor";
            parFcolor.Size = new Size(57, 15);
            parFcolor.TabIndex = 6;
            parFcolor.Text = "parFcolor";
            parFcolor.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(402, 389);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 7;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Parrot;
            pictureBox1.Location = new Point(714, 199);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 158);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // parHabi
            // 
            parHabi.AutoSize = true;
            parHabi.Location = new Point(55, 313);
            parHabi.Name = "parHabi";
            parHabi.Size = new Size(46, 15);
            parHabi.TabIndex = 9;
            parHabi.Text = "Habitat";
            parHabi.Visible = false;
            // 
            // flylab
            // 
            flylab.AutoSize = true;
            flylab.Location = new Point(55, 342);
            flylab.Name = "flylab";
            flylab.Size = new Size(42, 15);
            flylab.TabIndex = 10;
            flylab.Text = "flyable";
            flylab.Visible = false;
            // 
            // foodLab
            // 
            foodLab.AutoSize = true;
            foodLab.Location = new Point(402, 199);
            foodLab.Name = "foodLab";
            foodLab.Size = new Size(55, 15);
            foodLab.TabIndex = 11;
            foodLab.Text = "foodtype";
            foodLab.Visible = false;
            // 
            // aniLab
            // 
            aniLab.AutoSize = true;
            aniLab.Location = new Point(402, 227);
            aniLab.Name = "aniLab";
            aniLab.Size = new Size(66, 15);
            aniLab.TabIndex = 12;
            aniLab.Text = "animaltype";
            aniLab.Visible = false;
            // 
            // ViewParrots
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 450);
            Controls.Add(aniLab);
            Controls.Add(foodLab);
            Controls.Add(flylab);
            Controls.Add(parHabi);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(parFcolor);
            Controls.Add(parGen);
            Controls.Add(parAge);
            Controls.Add(parName);
            Controls.Add(selParrots);
            Controls.Add(sleepPar);
            Controls.Add(eatsPar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewParrots";
            Text = "Parrots at the Zoo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label eatsPar;
        private Label sleepPar;
        private ComboBox selParrots;
        private Label parName;
        private Label parAge;
        private Label parGen;
        private Label parFcolor;
        private Button button1;
        private PictureBox pictureBox1;
        private Label parHabi;
        private Label flylab;
        private Label foodLab;
        private Label aniLab;
    }
}