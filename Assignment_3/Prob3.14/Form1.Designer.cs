namespace Prob3._14
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
            lblTicket = new Label();
            lblRevenue = new Label();
            lblClassA = new Label();
            lblClassB = new Label();
            lblClassC = new Label();
            lblRevenueC = new Label();
            lblRevenueB = new Label();
            lblRevenueA = new Label();
            lblTotalRevenue = new Label();
            txtTicketA = new TextBox();
            txtTicketB = new TextBox();
            txtTicketC = new TextBox();
            txtClassCRevenue = new TextBox();
            txtClassBRevenue = new TextBox();
            txtClassARevenue = new TextBox();
            txtTotalRevenue = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblTicket
            // 
            lblTicket.AutoSize = true;
            lblTicket.Location = new Point(150, 114);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(70, 15);
            lblTicket.TabIndex = 0;
            lblTicket.Text = "Tickets Sold";
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Location = new Point(355, 114);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(109, 15);
            lblRevenue.TabIndex = 1;
            lblRevenue.Text = "Revenue Generated";
            // 
            // lblClassA
            // 
            lblClassA.AutoSize = true;
            lblClassA.Location = new Point(150, 161);
            lblClassA.Name = "lblClassA";
            lblClassA.Size = new Size(48, 15);
            lblClassA.TabIndex = 2;
            lblClassA.Text = "Class A:";
            // 
            // lblClassB
            // 
            lblClassB.AutoSize = true;
            lblClassB.Location = new Point(150, 193);
            lblClassB.Name = "lblClassB";
            lblClassB.Size = new Size(47, 15);
            lblClassB.TabIndex = 3;
            lblClassB.Text = "Class B:";
            // 
            // lblClassC
            // 
            lblClassC.AutoSize = true;
            lblClassC.Location = new Point(150, 226);
            lblClassC.Name = "lblClassC";
            lblClassC.Size = new Size(48, 15);
            lblClassC.TabIndex = 4;
            lblClassC.Text = "Class C:";
            // 
            // lblRevenueC
            // 
            lblRevenueC.AutoSize = true;
            lblRevenueC.Location = new Point(355, 226);
            lblRevenueC.Name = "lblRevenueC";
            lblRevenueC.Size = new Size(48, 15);
            lblRevenueC.TabIndex = 7;
            lblRevenueC.Text = "Class C:";
            // 
            // lblRevenueB
            // 
            lblRevenueB.AutoSize = true;
            lblRevenueB.Location = new Point(355, 193);
            lblRevenueB.Name = "lblRevenueB";
            lblRevenueB.Size = new Size(47, 15);
            lblRevenueB.TabIndex = 6;
            lblRevenueB.Text = "Class B:";
            // 
            // lblRevenueA
            // 
            lblRevenueA.AutoSize = true;
            lblRevenueA.Location = new Point(355, 161);
            lblRevenueA.Name = "lblRevenueA";
            lblRevenueA.Size = new Size(48, 15);
            lblRevenueA.TabIndex = 5;
            lblRevenueA.Text = "Class A:";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Location = new Point(366, 260);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(36, 15);
            lblTotalRevenue.TabIndex = 8;
            lblTotalRevenue.Text = "Total:";
            // 
            // txtTicketA
            // 
            txtTicketA.Location = new Point(204, 153);
            txtTicketA.Name = "txtTicketA";
            txtTicketA.Size = new Size(100, 23);
            txtTicketA.TabIndex = 9;
            // 
            // txtTicketB
            // 
            txtTicketB.Location = new Point(204, 190);
            txtTicketB.Name = "txtTicketB";
            txtTicketB.Size = new Size(100, 23);
            txtTicketB.TabIndex = 10;
            // 
            // txtTicketC
            // 
            txtTicketC.Location = new Point(204, 223);
            txtTicketC.Name = "txtTicketC";
            txtTicketC.Size = new Size(100, 23);
            txtTicketC.TabIndex = 11;
            // 
            // txtClassCRevenue
            // 
            txtClassCRevenue.Location = new Point(409, 223);
            txtClassCRevenue.Name = "txtClassCRevenue";
            txtClassCRevenue.ReadOnly = true;
            txtClassCRevenue.Size = new Size(100, 23);
            txtClassCRevenue.TabIndex = 14;
            // 
            // txtClassBRevenue
            // 
            txtClassBRevenue.Location = new Point(409, 190);
            txtClassBRevenue.Name = "txtClassBRevenue";
            txtClassBRevenue.ReadOnly = true;
            txtClassBRevenue.Size = new Size(100, 23);
            txtClassBRevenue.TabIndex = 13;
            // 
            // txtClassARevenue
            // 
            txtClassARevenue.Location = new Point(409, 158);
            txtClassARevenue.Name = "txtClassARevenue";
            txtClassARevenue.ReadOnly = true;
            txtClassARevenue.Size = new Size(100, 23);
            txtClassARevenue.TabIndex = 12;
            // 
            // txtTotalRevenue
            // 
            txtTotalRevenue.Location = new Point(409, 257);
            txtTotalRevenue.Name = "txtTotalRevenue";
            txtTotalRevenue.ReadOnly = true;
            txtTotalRevenue.Size = new Size(100, 23);
            txtTotalRevenue.TabIndex = 15;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(216, 328);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(74, 65);
            btnCalculate.TabIndex = 16;
            btnCalculate.Text = "Calculate Revenue";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(307, 328);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(74, 65);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotalRevenue);
            Controls.Add(txtClassCRevenue);
            Controls.Add(txtClassBRevenue);
            Controls.Add(txtClassARevenue);
            Controls.Add(txtTicketC);
            Controls.Add(txtTicketB);
            Controls.Add(txtTicketA);
            Controls.Add(lblTotalRevenue);
            Controls.Add(lblRevenueC);
            Controls.Add(lblRevenueB);
            Controls.Add(lblRevenueA);
            Controls.Add(lblClassC);
            Controls.Add(lblClassB);
            Controls.Add(lblClassA);
            Controls.Add(lblRevenue);
            Controls.Add(lblTicket);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTicket;
        private Label lblRevenue;
        private Label lblClassA;
        private Label lblClassB;
        private Label lblClassC;
        private Label lblRevenueC;
        private Label lblRevenueB;
        private Label lblRevenueA;
        private Label lblTotalRevenue;
        private TextBox txtTicketA;
        private TextBox txtTicketB;
        private TextBox txtTicketC;
        private TextBox txtClassCRevenue;
        private TextBox txtClassBRevenue;
        private TextBox txtClassARevenue;
        private TextBox txtTotalRevenue;
        private Button btnCalculate;
        private Button btnClear;
    }
}
