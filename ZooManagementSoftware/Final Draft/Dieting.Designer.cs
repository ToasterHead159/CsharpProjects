namespace ZooManageEncycloFA2
{
    partial class Dieting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dieting));
            lionDiet = new Button();
            parDiet = new Button();
            button1 = new Button();
            introLable = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            typeFood = new Label();
            numFeeds = new Label();
            feedTime = new Label();
            clsBtn = new Button();
            SuspendLayout();
            // 
            // lionDiet
            // 
            lionDiet.Location = new Point(68, 113);
            lionDiet.Name = "lionDiet";
            lionDiet.Size = new Size(113, 62);
            lionDiet.TabIndex = 0;
            lionDiet.Text = "Lions";
            lionDiet.UseVisualStyleBackColor = true;
            lionDiet.Click += lionDiet_Click;
            // 
            // parDiet
            // 
            parDiet.Location = new Point(68, 203);
            parDiet.Name = "parDiet";
            parDiet.Size = new Size(113, 67);
            parDiet.TabIndex = 1;
            parDiet.Text = "Parrots";
            parDiet.UseVisualStyleBackColor = true;
            parDiet.Click += parDiet_Click;
            // 
            // button1
            // 
            button1.Location = new Point(68, 298);
            button1.Name = "button1";
            button1.Size = new Size(113, 61);
            button1.TabIndex = 2;
            button1.Text = "Tortoises";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // introLable
            // 
            introLable.AutoSize = true;
            introLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            introLable.Location = new Point(48, 44);
            introLable.Name = "introLable";
            introLable.Size = new Size(653, 32);
            introLable.TabIndex = 3;
            introLable.Text = "Select an Animal to see its dietry and feeding requirements.";
            introLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 134);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 4;
            label1.Text = "Type of Food:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(247, 203);
            label2.Name = "label2";
            label2.Size = new Size(217, 30);
            label2.TabIndex = 5;
            label2.Text = "Number of Feedings:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(247, 277);
            label3.Name = "label3";
            label3.Size = new Size(159, 30);
            label3.TabIndex = 6;
            label3.Text = "Feeding Times:";
            // 
            // typeFood
            // 
            typeFood.AutoSize = true;
            typeFood.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeFood.Location = new Point(550, 134);
            typeFood.Name = "typeFood";
            typeFood.Size = new Size(141, 32);
            typeFood.TabIndex = 7;
            typeFood.Text = "typeOfFood";
            typeFood.Visible = false;
            typeFood.TextChanged += typeFood_TextChanged;
            // 
            // numFeeds
            // 
            numFeeds.AutoSize = true;
            numFeeds.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numFeeds.Location = new Point(550, 203);
            numFeeds.Name = "numFeeds";
            numFeeds.Size = new Size(141, 32);
            numFeeds.TabIndex = 8;
            numFeeds.Text = "numOfFeed";
            numFeeds.Visible = false;
            numFeeds.TextChanged += numFeeds_TextChanged;
            // 
            // feedTime
            // 
            feedTime.AutoSize = true;
            feedTime.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feedTime.Location = new Point(550, 277);
            feedTime.Name = "feedTime";
            feedTime.Size = new Size(119, 32);
            feedTime.TabIndex = 9;
            feedTime.Text = "FeedTime";
            feedTime.Visible = false;
            feedTime.TextChanged += feedTime_TextChanged;
            // 
            // clsBtn
            // 
            clsBtn.Location = new Point(712, 413);
            clsBtn.Name = "clsBtn";
            clsBtn.Size = new Size(76, 25);
            clsBtn.TabIndex = 10;
            clsBtn.Text = "Close";
            clsBtn.UseVisualStyleBackColor = true;
            clsBtn.Click += clsBtn_Click;
            // 
            // Dieting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clsBtn);
            Controls.Add(feedTime);
            Controls.Add(numFeeds);
            Controls.Add(typeFood);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(introLable);
            Controls.Add(button1);
            Controls.Add(parDiet);
            Controls.Add(lionDiet);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dieting";
            Text = "Diet and Feeding";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lionDiet;
        private Button parDiet;
        private Button button1;
        private Label introLable;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label typeFood;
        private Label numFeeds;
        private Label feedTime;
        private Button clsBtn;
    }
}