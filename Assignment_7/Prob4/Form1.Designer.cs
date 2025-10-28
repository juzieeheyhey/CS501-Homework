namespace Prob4
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
            cbLanguageSelect = new ComboBox();
            tbUserInput = new TextBox();
            lbInput = new Label();
            lbOutput = new Label();
            lbUserOutput = new Label();
            btnTranslate = new Button();
            SuspendLayout();
            // 
            // cbLanguageSelect
            // 
            cbLanguageSelect.FormattingEnabled = true;
            cbLanguageSelect.Items.AddRange(new object[] { "Spanish", "French", "Portuguese" });
            cbLanguageSelect.Location = new Point(101, 66);
            cbLanguageSelect.Name = "cbLanguageSelect";
            cbLanguageSelect.Size = new Size(182, 33);
            cbLanguageSelect.TabIndex = 0;
            cbLanguageSelect.Text = "Select Language";
            // 
            // tbUserInput
            // 
            tbUserInput.Location = new Point(101, 155);
            tbUserInput.Name = "tbUserInput";
            tbUserInput.PlaceholderText = "Input text here.";
            tbUserInput.Size = new Size(289, 31);
            tbUserInput.TabIndex = 1;
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.Location = new Point(101, 127);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(89, 25);
            lbInput.TabIndex = 2;
            lbInput.Text = "Text Input";
            // 
            // lbOutput
            // 
            lbOutput.AutoSize = true;
            lbOutput.Location = new Point(488, 127);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(69, 25);
            lbOutput.TabIndex = 3;
            lbOutput.Text = "Output";
            // 
            // lbUserOutput
            // 
            lbUserOutput.AutoSize = true;
            lbUserOutput.Location = new Point(488, 158);
            lbUserOutput.Name = "lbUserOutput";
            lbUserOutput.Size = new Size(0, 25);
            lbUserOutput.TabIndex = 4;
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(389, 230);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(112, 34);
            btnTranslate.TabIndex = 5;
            btnTranslate.Text = "Translate";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTranslate);
            Controls.Add(lbUserOutput);
            Controls.Add(lbOutput);
            Controls.Add(lbInput);
            Controls.Add(tbUserInput);
            Controls.Add(cbLanguageSelect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbLanguageSelect;
        private TextBox tbUserInput;
        private Label lbInput;
        private Label lbOutput;
        private Label lbUserOutput;
        private Button btnTranslate;
    }
}
