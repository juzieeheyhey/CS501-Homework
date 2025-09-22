namespace FlashCard
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
            lblQACounter = new Label();
            lblAttemptCounter = new Label();
            lblOperator = new Label();
            lblOperandA = new Label();
            lblOperandB = new Label();
            lblMessage = new Label();
            txtAnswer = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblQACounter
            // 
            lblQACounter.AutoSize = true;
            lblQACounter.BackColor = Color.FromArgb(192, 192, 255);
            lblQACounter.Location = new Point(52, 48);
            lblQACounter.Name = "lblQACounter";
            lblQACounter.Size = new Size(59, 25);
            lblQACounter.TabIndex = 0;
            lblQACounter.Text = "label1";
            // 
            // lblAttemptCounter
            // 
            lblAttemptCounter.AutoSize = true;
            lblAttemptCounter.BackColor = Color.FromArgb(255, 192, 192);
            lblAttemptCounter.Location = new Point(52, 91);
            lblAttemptCounter.Name = "lblAttemptCounter";
            lblAttemptCounter.Size = new Size(59, 25);
            lblAttemptCounter.TabIndex = 1;
            lblAttemptCounter.Text = "label2";
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Font = new Font("Segoe UI", 16F);
            lblOperator.Location = new Point(321, 176);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(42, 45);
            lblOperator.TabIndex = 2;
            lblOperator.Text = "+";
            // 
            // lblOperandA
            // 
            lblOperandA.AutoSize = true;
            lblOperandA.BackColor = Color.FromArgb(192, 255, 255);
            lblOperandA.Font = new Font("Segoe UI", 16F);
            lblOperandA.Location = new Point(384, 71);
            lblOperandA.Name = "lblOperandA";
            lblOperandA.Size = new Size(37, 45);
            lblOperandA.TabIndex = 3;
            lblOperandA.Text = "0";
            // 
            // lblOperandB
            // 
            lblOperandB.AutoSize = true;
            lblOperandB.BackColor = Color.FromArgb(192, 255, 255);
            lblOperandB.Font = new Font("Segoe UI", 16F);
            lblOperandB.Location = new Point(384, 176);
            lblOperandB.Name = "lblOperandB";
            lblOperandB.Size = new Size(37, 45);
            lblOperandB.TabIndex = 4;
            lblOperandB.Text = "0";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(355, 333);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(87, 25);
            lblMessage.TabIndex = 5;
            lblMessage.Text = "Feedback";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(321, 235);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(150, 31);
            txtAnswer.TabIndex = 6;
            txtAnswer.TextChanged += txtAnswer_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.LightGreen;
            btnSubmit.Font = new Font("Segoe UI", 12F);
            btnSubmit.Location = new Point(336, 272);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(120, 46);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(txtAnswer);
            Controls.Add(lblMessage);
            Controls.Add(lblOperandB);
            Controls.Add(lblOperandA);
            Controls.Add(lblOperator);
            Controls.Add(lblAttemptCounter);
            Controls.Add(lblQACounter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQACounter;
        private Label lblAttemptCounter;
        private Label lblOperator;
        private Label lblOperandA;
        private Label lblOperandB;
        private Label lblMessage;
        private TextBox txtAnswer;
        private Button btnSubmit;
    }
}
