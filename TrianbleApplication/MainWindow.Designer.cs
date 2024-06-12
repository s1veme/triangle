namespace TrianbleApplication
{
    partial class MainWindow
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
            label3 = new Label();
            textBoxAB = new TextBox();
            textBoxBC = new TextBox();
            textBoxAC = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(68, 76);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 0;
            label1.Text = "Сторона AB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(68, 132);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 1;
            label2.Text = "Сторона BC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(68, 196);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 2;
            label3.Text = "Сторона AC";
            // 
            // textBoxAB
            // 
            textBoxAB.Location = new Point(168, 78);
            textBoxAB.Name = "textBoxAB";
            textBoxAB.Size = new Size(100, 23);
            textBoxAB.TabIndex = 3;
            // 
            // textBoxBC
            // 
            textBoxBC.Location = new Point(168, 134);
            textBoxBC.Name = "textBoxBC";
            textBoxBC.Size = new Size(100, 23);
            textBoxBC.TabIndex = 4;
            // 
            // textBoxAC
            // 
            textBoxAC.Location = new Point(169, 194);
            textBoxAC.Name = "textBoxAC";
            textBoxAC.Size = new Size(100, 23);
            textBoxAC.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(169, 269);
            button1.Name = "button1";
            button1.Size = new Size(94, 51);
            button1.TabIndex = 6;
            button1.Text = "Проверить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 335);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 81);
            textBox1.TabIndex = 7;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(textBoxAC);
            Controls.Add(textBoxBC);
            Controls.Add(textBoxAB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxAB;
        private TextBox textBoxBC;
        private TextBox textBoxAC;
        private Button button1;
        private TextBox textBox1;
    }
}
