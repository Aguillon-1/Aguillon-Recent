﻿namespace Classroom_Management_System
{
    partial class Profile1
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 224);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(383, 148);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 2;
            button1.Text = "Change Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(482, 216);
            button2.Name = "button2";
            button2.Size = new Size(154, 37);
            button2.TabIndex = 3;
            button2.Text = "Change Username";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(383, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 129);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(421, 339);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = true;
            // 
            // Profile1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 487);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Profile1";
            Text = "Profile";
            Load += Profile1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
    }
}