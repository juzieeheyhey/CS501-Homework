﻿namespace Prob5._11
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
            txtInput = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(216, 156);
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "Enter a number";
            txtInput.Size = new Size(221, 23);
            txtInput.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(469, 145);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 43);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate Factorial";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(337, 243);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCalculate;
        private Label lblResult;
    }
}
