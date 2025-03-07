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
            dietFeed = new Button();
            clsBtn = new Button();
            SuspendLayout();
            // 
            // addAnibtn1
            // 
            addAnibtn1.Location = new Point(37, 38);
            addAnibtn1.Name = "addAnibtn1";
            addAnibtn1.Size = new Size(122, 59);
            addAnibtn1.TabIndex = 0;
            addAnibtn1.Text = "Add an animal";
            addAnibtn1.UseVisualStyleBackColor = true;
            addAnibtn1.Click += addAnibtn1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 116);
            button1.Name = "button1";
            button1.Size = new Size(122, 70);
            button1.TabIndex = 1;
            button1.Text = "Feed Animal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(37, 208);
            button2.Name = "button2";
            button2.Size = new Size(121, 65);
            button2.TabIndex = 2;
            button2.Text = "Move Animal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TickManBtn
            // 
            TickManBtn.Location = new Point(37, 299);
            TickManBtn.Name = "TickManBtn";
            TickManBtn.Size = new Size(121, 56);
            TickManBtn.TabIndex = 3;
            TickManBtn.Text = "Ticket Price Change";
            TickManBtn.UseVisualStyleBackColor = true;
            TickManBtn.Click += TickManBtn_Click;
            // 
            // dietFeed
            // 
            dietFeed.Location = new Point(262, 38);
            dietFeed.Name = "dietFeed";
            dietFeed.Size = new Size(108, 59);
            dietFeed.TabIndex = 4;
            dietFeed.Text = "Diets and Feeding";
            dietFeed.UseVisualStyleBackColor = true;
            dietFeed.Click += dietFeed_Click;
            // 
            // clsBtn
            // 
            clsBtn.Location = new Point(351, 358);
            clsBtn.Name = "clsBtn";
            clsBtn.Size = new Size(75, 23);
            clsBtn.TabIndex = 5;
            clsBtn.Text = "Close";
            clsBtn.UseVisualStyleBackColor = true;
            clsBtn.Click += clsBtn_Click;
            // 
            // ManageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(438, 393);
            Controls.Add(clsBtn);
            Controls.Add(dietFeed);
            Controls.Add(TickManBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(addAnibtn1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(454, 432);
            MinimumSize = new Size(454, 432);
            Name = "ManageForm";
            Text = "Zoo Management";
            ResumeLayout(false);
        }

        #endregion

        private Button addAnibtn1;
        private Button button1;
        private Button button2;
        private Button TickManBtn;
        private Button dietFeed;
        private Button clsBtn;
    }
}