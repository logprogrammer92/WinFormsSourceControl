namespace WinFormsSourceControl
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            lengthTextBox = new TextBox();
            widthTextBox = new TextBox();
            calcAreaAndPerimeterButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 69);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Length";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 131);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Width";
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(117, 60);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(128, 23);
            lengthTextBox.TabIndex = 2;
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(117, 122);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(128, 23);
            widthTextBox.TabIndex = 3;
            // 
            // calcAreaAndPerimeterButton
            // 
            calcAreaAndPerimeterButton.Location = new Point(88, 180);
            calcAreaAndPerimeterButton.Name = "calcAreaAndPerimeterButton";
            calcAreaAndPerimeterButton.Size = new Size(127, 64);
            calcAreaAndPerimeterButton.TabIndex = 4;
            calcAreaAndPerimeterButton.Text = "Calculate Area and Perimeter";
            calcAreaAndPerimeterButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calcAreaAndPerimeterButton);
            Controls.Add(widthTextBox);
            Controls.Add(lengthTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Area and Perimeter Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox lengthTextBox;
        private TextBox widthTextBox;
        private Button calcAreaAndPerimeterButton;
    }
}
