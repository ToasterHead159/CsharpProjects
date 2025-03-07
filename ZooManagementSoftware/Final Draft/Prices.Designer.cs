namespace ZooManageEncycloFA2
{
    partial class Prices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prices));
            tickExplainlab = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            standardMesslab = new Label();
            seniorLab = new Label();
            childLab = new Label();
            seniorAgeSet = new NumericUpDown();
            childTop = new NumericUpDown();
            childBot = new NumericUpDown();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)seniorAgeSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)childTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)childBot).BeginInit();
            SuspendLayout();
            // 
            // tickExplainlab
            // 
            tickExplainlab.AutoSize = true;
            tickExplainlab.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tickExplainlab.Location = new Point(56, 37);
            tickExplainlab.Name = "tickExplainlab";
            tickExplainlab.Size = new Size(68, 37);
            tickExplainlab.TabIndex = 0;
            tickExplainlab.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 120);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 117);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 2;
            label1.Text = "Standard Price";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 193);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 193);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 4;
            label2.Text = "Seniors Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 293);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 5;
            label3.Text = "Childs Price";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(232, 300);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(395, 117);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 7;
            button1.Text = "Set Price";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(395, 199);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 8;
            button2.Text = "Set Price";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(395, 300);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 9;
            button3.Text = "Set Price";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 236);
            label4.Name = "label4";
            label4.Size = new Size(142, 28);
            label4.TabIndex = 11;
            label4.Text = "Qualifying Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 351);
            label5.Name = "label5";
            label5.Size = new Size(171, 28);
            label5.TabIndex = 12;
            label5.Text = "Bottom Age Limit ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(86, 389);
            label6.Name = "label6";
            label6.Size = new Size(132, 28);
            label6.TabIndex = 13;
            label6.Text = "Top Age Limit";
            // 
            // standardMesslab
            // 
            standardMesslab.AutoSize = true;
            standardMesslab.Location = new Point(544, 117);
            standardMesslab.Name = "standardMesslab";
            standardMesslab.Size = new Size(67, 20);
            standardMesslab.TabIndex = 16;
            standardMesslab.Text = "message";
            // 
            // seniorLab
            // 
            seniorLab.AutoSize = true;
            seniorLab.Location = new Point(544, 193);
            seniorLab.Name = "seniorLab";
            seniorLab.Size = new Size(67, 20);
            seniorLab.TabIndex = 17;
            seniorLab.Text = "message";
            // 
            // childLab
            // 
            childLab.AutoSize = true;
            childLab.Location = new Point(544, 305);
            childLab.Name = "childLab";
            childLab.Size = new Size(67, 20);
            childLab.TabIndex = 18;
            childLab.Text = "message";
            // 
            // seniorAgeSet
            // 
            seniorAgeSet.Location = new Point(232, 232);
            seniorAgeSet.Margin = new Padding(3, 4, 3, 4);
            seniorAgeSet.Name = "seniorAgeSet";
            seniorAgeSet.Size = new Size(137, 27);
            seniorAgeSet.TabIndex = 19;
            seniorAgeSet.Value = new decimal(new int[] { 45, 0, 0, 0 });
            seniorAgeSet.ValueChanged += seniorAgeSet_ValueChanged;
            // 
            // childTop
            // 
            childTop.Location = new Point(232, 393);
            childTop.Margin = new Padding(3, 4, 3, 4);
            childTop.Name = "childTop";
            childTop.Size = new Size(137, 27);
            childTop.TabIndex = 21;
            childTop.Value = new decimal(new int[] { 6, 0, 0, 0 });
            childTop.ValueChanged += childTop_ValueChanged;
            // 
            // childBot
            // 
            childBot.Location = new Point(232, 355);
            childBot.Margin = new Padding(3, 4, 3, 4);
            childBot.Name = "childBot";
            childBot.Size = new Size(137, 27);
            childBot.TabIndex = 22;
            childBot.Value = new decimal(new int[] { 3, 0, 0, 0 });
            childBot.ValueChanged += childBot_ValueChanged;
            // 
            // button4
            // 
            button4.Location = new Point(685, 436);
            button4.Name = "button4";
            button4.Size = new Size(121, 29);
            button4.TabIndex = 23;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Prices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 477);
            Controls.Add(button4);
            Controls.Add(childBot);
            Controls.Add(childTop);
            Controls.Add(seniorAgeSet);
            Controls.Add(childLab);
            Controls.Add(seniorLab);
            Controls.Add(standardMesslab);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(tickExplainlab);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Prices";
            Text = "Prices Management";
            ((System.ComponentModel.ISupportInitialize)seniorAgeSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)childTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)childBot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tickExplainlab;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label standardMesslab;
        private Label seniorLab;
        private Label childLab;
        private NumericUpDown seniorAgeSet;
        private NumericUpDown childTop;
        private NumericUpDown childBot;
        private Button button4;
    }
}