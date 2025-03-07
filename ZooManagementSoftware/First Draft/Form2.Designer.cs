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
            SuspendLayout();
            // 
            // getLioninfo
            // 
            getLioninfo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            getLioninfo.Location = new Point(34, 400);
            getLioninfo.Margin = new Padding(3, 4, 3, 4);
            getLioninfo.Name = "getLioninfo";
            getLioninfo.Size = new Size(128, 60);
            getLioninfo.TabIndex = 0;
            getLioninfo.Text = "Lions";
            getLioninfo.UseVisualStyleBackColor = true;
            getLioninfo.Click += button1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(11, 173);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(163, 67);
            button1.TabIndex = 1;
            button1.Text = "Parrots";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(223, 13);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.MaximumSize = new Size(197, 69);
            button2.MinimumSize = new Size(197, 69);
            button2.Name = "button2";
            button2.Size = new Size(197, 69);
            button2.TabIndex = 2;
            button2.Text = "Tortoises ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(434, 173);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(187, 67);
            button3.TabIndex = 3;
            button3.Text = "Monkeys";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(457, 363);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(130, 59);
            button4.TabIndex = 4;
            button4.Text = "Deer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // visitorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hand_drawn_zoo_map_illustration_23_2149400546;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(619, 523);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(getLioninfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
    }
}