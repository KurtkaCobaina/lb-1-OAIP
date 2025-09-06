namespace Лаба_оаип_7
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 49);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 1;
            label1.Text = "Введите имя:";
            // 
            // button1
            // 
            button1.Location = new Point(562, 44);
            button1.Name = "button1";
            button1.Size = new Size(172, 51);
            button1.TabIndex = 2;
            button1.Text = "OK Computer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 106);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(12, 250);
            button2.Name = "button2";
            button2.Size = new Size(200, 46);
            button2.TabIndex = 4;
            button2.Text = "Лаба 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(218, 250);
            button3.Name = "button3";
            button3.Size = new Size(200, 46);
            button3.TabIndex = 5;
            button3.Text = "Лаба 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(424, 250);
            button4.Name = "button4";
            button4.Size = new Size(200, 46);
            button4.TabIndex = 6;
            button4.Text = "Лаба 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(630, 250);
            button5.Name = "button5";
            button5.Size = new Size(200, 46);
            button5.TabIndex = 7;
            button5.Text = "Лаба 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(836, 250);
            button6.Name = "button6";
            button6.Size = new Size(200, 46);
            button6.TabIndex = 8;
            button6.Text = "Лаба 6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 637);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}