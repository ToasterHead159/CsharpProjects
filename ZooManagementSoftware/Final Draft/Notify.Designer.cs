namespace ZooManageEncycloFA2
{
    partial class Notify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notify));
            button1 = new Button();
            noteBody = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 256);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(263, 31);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // noteBody
            // 
            noteBody.AutoSize = true;
            noteBody.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteBody.Location = new Point(42, 123);
            noteBody.MaximumSize = new Size(170, 28);
            noteBody.MinimumSize = new Size(170, 28);
            noteBody.Name = "noteBody";
            noteBody.Size = new Size(170, 28);
            noteBody.TabIndex = 1;
            noteBody.Text = "Coming Soon!";
            noteBody.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Notify
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(263, 287);
            Controls.Add(noteBody);
            Controls.Add(button1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Notify";
            Text = "Notification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label noteBody;
    }
}