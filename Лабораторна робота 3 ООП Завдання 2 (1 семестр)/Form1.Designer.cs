using System.Drawing;
using System.Windows.Forms;

namespace Laba_3_Task_2
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
            button1 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            listBox2 = new ListBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1100, 325);
            button1.Name = "button1";
            button1.Size = new Size(214, 36);
            button1.TabIndex = 0;
            button1.Text = "View images";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(40, 57);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(301, 304);
            listBox1.TabIndex = 1;
            listBox1.Visible = false;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Visible = false;
            pictureBox1.Location = new Point(40, 405);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 304);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.Location = new Point(584, 57);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(301, 304);
            listBox2.TabIndex = 3;
            listBox2.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Visible = false;
            pictureBox2.Location = new Point(585, 380);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(1189, 405);
            button2.Name = "button2";
            button2.Size = new Size(214, 36);
            button2.TabIndex = 5;
            button2.Text = "Flip\r\n\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(listBox2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Symmetry";
            SizeChanged += Form1_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private ListBox listBox2;
        private PictureBox pictureBox2;
        private Button button2;
    }
}