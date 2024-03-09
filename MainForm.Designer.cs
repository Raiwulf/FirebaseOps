namespace FirebaseOps
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            connectButton = new Button();
            scrollPanel = new Panel();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(287, 301);
            button3.Name = "button3";
            button3.Size = new Size(75, 34);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(206, 301);
            button2.Name = "button2";
            button2.Size = new Size(75, 34);
            button2.TabIndex = 2;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(93, 301);
            button1.Name = "button1";
            button1.Size = new Size(38, 34);
            button1.TabIndex = 3;
            button1.Text = "🔄";
            button1.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(12, 301);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(75, 34);
            connectButton.TabIndex = 3;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // scrollPanel
            // 
            scrollPanel.AutoScroll = true;
            scrollPanel.Location = new Point(12, 12);
            scrollPanel.Name = "scrollPanel";
            scrollPanel.Size = new Size(350, 283);
            scrollPanel.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(374, 335);
            Controls.Add(scrollPanel);
            Controls.Add(button3);
            Controls.Add(connectButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "FirebaseOps";
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Button button2;
        private Button button1;
        private Button connectButton;
        private Panel scrollPanel;
    }
}
