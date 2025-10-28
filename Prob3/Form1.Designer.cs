namespace Prob3
{
    partial class Form1
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
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btnURL = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wbURL = new System.Windows.Forms.WebBrowser();
            this.pbQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(378, 68);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(100, 20);
            this.tbURL.TabIndex = 0;
            // 
            // btnURL
            // 
            this.btnURL.Location = new System.Drawing.Point(225, 379);
            this.btnURL.Name = "btnURL";
            this.btnURL.Size = new System.Drawing.Size(95, 23);
            this.btnURL.TabIndex = 1;
            this.btnURL.Text = "Load URL";
            this.btnURL.UseVisualStyleBackColor = true;
            this.btnURL.Click += new System.EventHandler(this.btnURL_Click);
            // 
            // btnQR
            // 
            this.btnQR.Location = new System.Drawing.Point(514, 379);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(95, 23);
            this.btnQR.TabIndex = 2;
            this.btnQR.Text = "Generate QR";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL:";
            // 
            // wbURL
            // 
            this.wbURL.Location = new System.Drawing.Point(148, 107);
            this.wbURL.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbURL.Name = "wbURL";
            this.wbURL.Size = new System.Drawing.Size(250, 250);
            this.wbURL.TabIndex = 4;
            // 
            // pbQR
            // 
            this.pbQR.Location = new System.Drawing.Point(431, 107);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(250, 250);
            this.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQR.TabIndex = 5;
            this.pbQR.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.wbURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.btnURL);
            this.Controls.Add(this.tbURL);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnURL;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser wbURL;
        private System.Windows.Forms.PictureBox pbQR;
    }
}

