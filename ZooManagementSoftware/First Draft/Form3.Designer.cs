namespace ZooManageEncycloFA2
{
    partial class ManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageForm));
            addAnibtn1 = new Button();
            button1 = new Button();
            button2 = new Button();
            TickManBtn = new Button();
            SuspendLayout();
            // 
            // addAnibtn1
            // 
            addAnibtn1.Location = new Point(42, 51);
            addAnibtn1.Margin = new Padding(3, 4, 3, 4);
            addAnibtn1.Name = "addAnibtn1";
            addAnibtn1.Size = new Size(139, 79);
            addAnibtn1.TabIndex = 0;
            addAnibtn1.Text = "Add an animal";
            addAnibtn1.UseVisualStyleBackColor = true;
            addAnibtn1.Click += addAnibtn1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(42, 155);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(139, 93);
            button1.TabIndex = 1;
            button1.Text = "Feed Animal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(42, 277);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(138, 87);
            button2.TabIndex = 2;
            button2.Text = "Move Animal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TickManBtn
            // 
            TickManBtn.Location = new Point(42, 399);
            TickManBtn.Margin = new Padding(3, 4, 3, 4);
            TickManBtn.Name = "TickManBtn";
            TickManBtn.Size = new Size(138, 75);
            TickManBtn.TabIndex = 3;
            TickManBtn.Text = "Ticket Price Change";
            TickManBtn.UseVisualStyleBackColor = true;
            TickManBtn.Click += TickManBtn_Click;
            // 
            // ManageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(498, 519);
            Controls.Add(TickManBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(addAnibtn1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(516, 566);
            MinimumSize = new Size(516, 566);
            Name = "ManageForm";
            Text = "Zoo Management";
            ResumeLayout(false);
        }

        #endregion

        private Button addAnibtn1;
        private Button button1;
        private Button button2;
        private Button TickManBtn;
    }
}