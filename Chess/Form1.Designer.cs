﻿namespace Chess
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
            pbTurnIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbTurnIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(944, 59);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 1;
            label1.Text = "turn now";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(859, 59);
            label2.Name = "label2";
            label2.Size = new Size(40, 28);
            label2.TabIndex = 2;
            label2.Text = "It's";
            // 
            // pbTurnIcon
            // 
            pbTurnIcon.Image = Properties.Resources.Empty_White;
            pbTurnIcon.Location = new Point(903, 47);
            pbTurnIcon.Margin = new Padding(3, 4, 3, 4);
            pbTurnIcon.Name = "pbTurnIcon";
            pbTurnIcon.Size = new Size(34, 40);
            pbTurnIcon.TabIndex = 3;
            pbTurnIcon.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 920);
            Controls.Add(pbTurnIcon);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbTurnIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private PictureBox pbTurnIcon;
    }
}
