namespace Prob6._9
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
            picRock = new PictureBox();
            picPaper = new PictureBox();
            picScissors = new PictureBox();
            btnPlayAgain = new Button();
            btnExit = new Button();
            lblMessage = new Label();
            lblResult = new Label();
            lblStartMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)picRock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPaper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picScissors).BeginInit();
            SuspendLayout();
            // 
            // picRock
            // 
            picRock.BackgroundImageLayout = ImageLayout.Stretch;
            picRock.Image = (Image)resources.GetObject("picRock.Image");
            picRock.Location = new Point(210, 154);
            picRock.Name = "picRock";
            picRock.Size = new Size(101, 102);
            picRock.SizeMode = PictureBoxSizeMode.Zoom;
            picRock.TabIndex = 0;
            picRock.TabStop = false;
            picRock.Click += picRock_Click;
            // 
            // picPaper
            // 
            picPaper.BackgroundImage = (Image)resources.GetObject("picPaper.BackgroundImage");
            picPaper.BackgroundImageLayout = ImageLayout.Stretch;
            picPaper.Image = (Image)resources.GetObject("picPaper.Image");
            picPaper.Location = new Point(354, 154);
            picPaper.Name = "picPaper";
            picPaper.Size = new Size(101, 102);
            picPaper.SizeMode = PictureBoxSizeMode.Zoom;
            picPaper.TabIndex = 1;
            picPaper.TabStop = false;
            picPaper.Click += picPaper_Click;
            // 
            // picScissors
            // 
            picScissors.BackgroundImage = (Image)resources.GetObject("picScissors.BackgroundImage");
            picScissors.BackgroundImageLayout = ImageLayout.Stretch;
            picScissors.Image = (Image)resources.GetObject("picScissors.Image");
            picScissors.Location = new Point(493, 154);
            picScissors.Name = "picScissors";
            picScissors.Size = new Size(101, 102);
            picScissors.SizeMode = PictureBoxSizeMode.Zoom;
            picScissors.TabIndex = 2;
            picScissors.TabStop = false;
            picScissors.Click += picScissors_Click;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Location = new Point(279, 375);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(74, 30);
            btnPlayAgain.TabIndex = 3;
            btnPlayAgain.Text = "Play Again";
            btnPlayAgain.UseVisualStyleBackColor = true;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(436, 375);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(74, 30);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Blue;
            lblMessage.Location = new Point(170, 81);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(456, 32);
            lblMessage.TabIndex = 5;
            lblMessage.Text = "Your turn - Choose Rock, Paper, Scissors!";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(354, 301);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 32);
            lblResult.TabIndex = 6;
            // 
            // lblStartMessage
            // 
            lblStartMessage.AutoSize = true;
            lblStartMessage.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartMessage.ForeColor = Color.Blue;
            lblStartMessage.Location = new Point(240, 32);
            lblStartMessage.Name = "lblStartMessage";
            lblStartMessage.Size = new Size(343, 32);
            lblStartMessage.TabIndex = 7;
            lblStartMessage.Text = "Computer has made its choice";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStartMessage);
            Controls.Add(lblResult);
            Controls.Add(lblMessage);
            Controls.Add(btnExit);
            Controls.Add(btnPlayAgain);
            Controls.Add(picScissors);
            Controls.Add(picPaper);
            Controls.Add(picRock);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picRock).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPaper).EndInit();
            ((System.ComponentModel.ISupportInitialize)picScissors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picRock;
        private PictureBox picPaper;
        private PictureBox picScissors;
        private Button btnPlayAgain;
        private Button btnExit;
        private Label lblMessage;
        private Label lblResult;
        private Label lblStartMessage;
    }
}
