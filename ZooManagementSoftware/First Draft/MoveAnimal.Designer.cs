namespace ZooManageEncycloFA2
{
    partial class MoveAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveAnimal));
            SelEnclo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            encloClean = new RadioButton();
            encloDirty = new RadioButton();
            SelAnimal = new ComboBox();
            label3 = new Label();
            quesAniReady = new Label();
            aniYes = new RadioButton();
            aniNo = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            moveStatlab = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SelEnclo
            // 
            SelEnclo.FormattingEnabled = true;
            SelEnclo.Location = new Point(144, 44);
            SelEnclo.Name = "SelEnclo";
            SelEnclo.Size = new Size(121, 23);
            SelEnclo.TabIndex = 0;
            SelEnclo.SelectedIndexChanged += SelEnclo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 1;
            label1.Text = "Select an Enclosure:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 89);
            label2.Name = "label2";
            label2.Size = new Size(256, 32);
            label2.TabIndex = 2;
            label2.Text = "Is the enclosure clean?";
            // 
            // encloClean
            // 
            encloClean.AutoSize = true;
            encloClean.Location = new Point(41, 22);
            encloClean.Name = "encloClean";
            encloClean.Size = new Size(42, 19);
            encloClean.TabIndex = 3;
            encloClean.TabStop = true;
            encloClean.Text = "Yes";
            encloClean.UseVisualStyleBackColor = true;
            encloClean.CheckedChanged += encloClean_CheckedChanged;
            // 
            // encloDirty
            // 
            encloDirty.AutoSize = true;
            encloDirty.Location = new Point(175, 22);
            encloDirty.Name = "encloDirty";
            encloDirty.Size = new Size(41, 19);
            encloDirty.TabIndex = 4;
            encloDirty.TabStop = true;
            encloDirty.Text = "No";
            encloDirty.UseVisualStyleBackColor = true;
            encloDirty.CheckedChanged += encloDirty_CheckedChanged;
            // 
            // SelAnimal
            // 
            SelAnimal.FormattingEnabled = true;
            SelAnimal.Location = new Point(144, 238);
            SelAnimal.Name = "SelAnimal";
            SelAnimal.Size = new Size(121, 23);
            SelAnimal.TabIndex = 5;
            SelAnimal.SelectedIndexChanged += SelAnimal_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 187);
            label3.Name = "label3";
            label3.Size = new Size(197, 32);
            label3.TabIndex = 6;
            label3.Text = "Select an Animal:";
            // 
            // quesAniReady
            // 
            quesAniReady.AutoSize = true;
            quesAniReady.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quesAniReady.Location = new Point(81, 283);
            quesAniReady.Name = "quesAniReady";
            quesAniReady.Size = new Size(108, 32);
            quesAniReady.TabIndex = 7;
            quesAniReady.Text = "is animal";
            quesAniReady.Visible = false;
            // 
            // aniYes
            // 
            aniYes.AutoSize = true;
            aniYes.Location = new Point(133, 343);
            aniYes.Name = "aniYes";
            aniYes.Size = new Size(42, 19);
            aniYes.TabIndex = 8;
            aniYes.TabStop = true;
            aniYes.Text = "Yes";
            aniYes.UseVisualStyleBackColor = true;
            aniYes.CheckedChanged += aniYes_CheckedChanged;
            // 
            // aniNo
            // 
            aniNo.AutoSize = true;
            aniNo.Location = new Point(267, 343);
            aniNo.Name = "aniNo";
            aniNo.Size = new Size(41, 19);
            aniNo.TabIndex = 9;
            aniNo.TabStop = true;
            aniNo.Text = "No";
            aniNo.UseVisualStyleBackColor = true;
            aniNo.CheckedChanged += aniNo_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(161, 379);
            button1.Name = "button1";
            button1.Size = new Size(104, 39);
            button1.TabIndex = 10;
            button1.Text = "Move";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(704, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(509, 89);
            label4.Name = "label4";
            label4.Size = new Size(207, 32);
            label4.TabIndex = 12;
            label4.Text = "Movement Status:";
            // 
            // moveStatlab
            // 
            moveStatlab.AutoSize = true;
            moveStatlab.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moveStatlab.Location = new Point(465, 139);
            moveStatlab.Name = "moveStatlab";
            moveStatlab.Size = new Size(114, 25);
            moveStatlab.TabIndex = 13;
            moveStatlab.Text = "Move Result";
            moveStatlab.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(encloDirty);
            groupBox1.Controls.Add(encloClean);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(106, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 50);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // MoveAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(moveStatlab);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(aniNo);
            Controls.Add(aniYes);
            Controls.Add(quesAniReady);
            Controls.Add(label3);
            Controls.Add(SelAnimal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SelEnclo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MoveAnimal";
            Text = "Move Animal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox SelEnclo;
        private Label label1;
        private Label label2;
        private RadioButton encloClean;
        private RadioButton encloDirty;
        private ComboBox SelAnimal;
        private Label label3;
        private Label quesAniReady;
        private RadioButton aniYes;
        private RadioButton aniNo;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label moveStatlab;
        private GroupBox groupBox1;
    }
}