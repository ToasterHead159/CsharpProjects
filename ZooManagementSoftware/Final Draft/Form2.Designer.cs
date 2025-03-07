namespace ZooManageEncycloFA2
{
    partial class visitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visitorForm));
            getLioninfo = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            clsBtn = new Button();
            SuspendLayout();
            // 
            // getLioninfo
            // 
            getLioninfo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            getLioninfo.Location = new Point(27, 373);
            getLioninfo.MaximumSize = new Size(112, 49);
            getLioninfo.MinimumSize = new Size(112, 49);
            getLioninfo.Name = "getLioninfo";
            getLioninfo.Size = new Size(112, 49);
            getLioninfo.TabIndex = 0;
            getLioninfo.Text = "Lions";
            getLioninfo.UseVisualStyleBackColor = true;
            getLioninfo.Click += button1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 176);
            button1.Name = "button1";
            button1.Size = new Size(143, 50);
            button1.TabIndex = 1;
            button1.Text = "Parrots";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(247, 24);
            button2.MaximumSize = new Size(172, 52);
            button2.MinimumSize = new Size(172, 52);
            button2.Name = "button2";
            button2.Size = new Size(172, 52);
            button2.TabIndex = 2;
            button2.Text = "Tortoises ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(449, 172);
            button3.Name = "button3";
            button3.Size = new Size(164, 58);
            button3.TabIndex = 3;
            button3.Text = "Monkeys";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(449, 349);
            button4.Name = "button4";
            button4.Size = new Size(114, 44);
            button4.TabIndex = 4;
            button4.Text = "Deer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // clsBtn
            // 
            clsBtn.Location = new Point(539, 476);
            clsBtn.Name = "clsBtn";
            clsBtn.Size = new Size(74, 27);
            clsBtn.TabIndex = 5;
            clsBtn.Text = "Close";
            clsBtn.UseVisualStyleBackColor = true;
            clsBtn.Click += clsBtn_Click;
            // 
            // visitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hand_drawn_zoo_map_illustration_23_2149400546;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(620, 513);
            Controls.Add(clsBtn);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(getLioninfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "visitorForm";
            Text = "Visitors";
            ResumeLayout(false);
        }

        #endregion

        private Button getLioninfo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button clsBtn;
    }
}