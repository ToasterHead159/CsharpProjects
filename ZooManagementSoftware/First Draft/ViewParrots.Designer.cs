
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // eatsPar
            // 
            eatsPar.AutoSize = true;
            eatsPar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eatsPar.Location = new Point(151, 47);
            eatsPar.Name = "eatsPar";
            eatsPar.Size = new Size(66, 38);
            eatsPar.TabIndex = 0;
            eatsPar.Text = "Eats";
            // 
            // sleepPar
            // 
            sleepPar.AutoSize = true;
            sleepPar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sleepPar.Location = new Point(63, 96);
            sleepPar.Name = "sleepPar";
            sleepPar.Size = new Size(84, 28);
            sleepPar.TabIndex = 1;
            sleepPar.Text = "sleepPar";
            // 
            // selParrots
            // 
            selParrots.FormattingEnabled = true;
            selParrots.Location = new Point(459, 203);
            selParrots.Name = "selParrots";
            selParrots.Size = new Size(151, 28);
            selParrots.TabIndex = 2;
            selParrots.Text = "Choose a Parrot:";
            selParrots.SelectedIndexChanged += selParrots_SelectedIndexChanged;
            // 
            // parName
            // 
            parName.AutoSize = true;
            parName.Location = new Point(63, 265);
            parName.Name = "parName";
            parName.Size = new Size(69, 20);
            parName.TabIndex = 3;
            parName.Text = "ParName";
            parName.Visible = false;
            // 
            // parAge
            // 
            parAge.AutoSize = true;
            parAge.Location = new Point(63, 309);
            parAge.Name = "parAge";
            parAge.Size = new Size(58, 20);
            parAge.TabIndex = 4;
            parAge.Text = "parAge";
            parAge.Visible = false;
            // 
            // parGen
            // 
            parGen.AutoSize = true;
            parGen.Location = new Point(63, 349);
            parGen.Name = "parGen";
            parGen.Size = new Size(57, 20);
            parGen.TabIndex = 5;
            parGen.Text = "parGen";
            parGen.Visible = false;
            // 
            // parFcolor
            // 
            parFcolor.AutoSize = true;
            parFcolor.Location = new Point(63, 386);
            parFcolor.Name = "parFcolor";
            parFcolor.Size = new Size(72, 20);
            parFcolor.TabIndex = 6;
            parFcolor.Text = "parFcolor";
            parFcolor.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(459, 519);
            button1.Name = "button1";
            button1.Size = new Size(108, 44);
            button1.TabIndex = 7;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Parrot;
            pictureBox1.Location = new Point(739, 274);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 163);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // ViewParrots
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 600);
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
            Margin = new Padding(3, 4, 3, 4);
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
    }
}