namespace ZooManageEncycloFA2
{
    partial class infoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoForm));
            infoLionLab = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // infoLionLab
            // 
            infoLionLab.AutoSize = true;
            infoLionLab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infoLionLab.Location = new Point(12, 26);
            infoLionLab.Name = "infoLionLab";
            infoLionLab.Size = new Size(52, 21);
            infoLionLab.TabIndex = 0;
            infoLionLab.Text = "label1";
            infoLionLab.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Location = new Point(520, 445);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // infoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 480);
            Controls.Add(button1);
            Controls.Add(infoLionLab);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1188, 519);
            MinimumSize = new Size(1188, 519);
            Name = "infoForm";
            Text = "About Lions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoLionLab;
        private Button button1;
    }
}