namespace Prob3._10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picBanana = new PictureBox();
            picApple = new PictureBox();
            picOrange = new PictureBox();
            picPear = new PictureBox();
            lblTotal = new Label();
            txtDisplayTotal = new TextBox();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)picBanana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picApple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOrange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPear).BeginInit();
            SuspendLayout();
            // 
            // picBanana
            // 
            picBanana.BackgroundImage = (Image)resources.GetObject("picBanana.BackgroundImage");
            picBanana.Location = new Point(179, 59);
            picBanana.Name = "picBanana";
            picBanana.Size = new Size(127, 152);
            picBanana.SizeMode = PictureBoxSizeMode.Zoom;
            picBanana.TabIndex = 0;
            picBanana.TabStop = false;
            picBanana.Click += picBanana_Click;
            // 
            // picApple
            // 
            picApple.BackgroundImage = (Image)resources.GetObject("picApple.BackgroundImage");
            picApple.Location = new Point(312, 59);
            picApple.Name = "picApple";
            picApple.Size = new Size(127, 152);
            picApple.SizeMode = PictureBoxSizeMode.Zoom;
            picApple.TabIndex = 1;
            picApple.TabStop = false;
            picApple.Click += picApple_Click;
            // 
            // picOrange
            // 
            picOrange.BackgroundImage = (Image)resources.GetObject("picOrange.BackgroundImage");
            picOrange.Location = new Point(179, 217);
            picOrange.Name = "picOrange";
            picOrange.Size = new Size(127, 152);
            picOrange.SizeMode = PictureBoxSizeMode.Zoom;
            picOrange.TabIndex = 2;
            picOrange.TabStop = false;
            picOrange.Click += picOrange_Click;
            // 
            // picPear
            // 
            picPear.BackgroundImage = (Image)resources.GetObject("picPear.BackgroundImage");
            picPear.Location = new Point(312, 217);
            picPear.Name = "picPear";
            picPear.Size = new Size(127, 152);
            picPear.SizeMode = PictureBoxSizeMode.Zoom;
            picPear.TabIndex = 3;
            picPear.TabStop = false;
            picPear.Click += picPear_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(510, 111);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(34, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            // 
            // txtDisplayTotal
            // 
            txtDisplayTotal.Location = new Point(477, 129);
            txtDisplayTotal.Name = "txtDisplayTotal";
            txtDisplayTotal.ReadOnly = true;
            txtDisplayTotal.Size = new Size(100, 23);
            txtDisplayTotal.TabIndex = 5;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(487, 346);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(txtDisplayTotal);
            Controls.Add(lblTotal);
            Controls.Add(picPear);
            Controls.Add(picOrange);
            Controls.Add(picApple);
            Controls.Add(picBanana);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBanana).EndInit();
            ((System.ComponentModel.ISupportInitialize)picApple).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOrange).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBanana;
        private PictureBox picApple;
        private PictureBox picOrange;
        private PictureBox picPear;
        private Label lblTotal;
        private TextBox txtDisplayTotal;
        private Button btnReset;
    }
}
