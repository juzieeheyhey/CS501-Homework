namespace Prob6._4
{
    partial class JoeAutomotiveForm
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
            components = new System.ComponentModel.Container();
            chkOilChange = new CheckBox();
            chkLubeJob = new CheckBox();
            grpOilAndLube = new GroupBox();
            grpFlushes = new GroupBox();
            chkRadiator = new CheckBox();
            chkTransmission = new CheckBox();
            grpMisc = new GroupBox();
            chkTire = new CheckBox();
            chkInspection = new CheckBox();
            chkReplace = new CheckBox();
            grpPartsLabor = new GroupBox();
            lblHours = new Label();
            lblParts = new Label();
            txtHourInput = new TextBox();
            txtPartsInput = new TextBox();
            grpSummary = new GroupBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            txtTax = new TextBox();
            label1 = new Label();
            txtLaborSummary = new TextBox();
            lblServiceandLabor = new Label();
            txtPartsSummary = new TextBox();
            lblPartSum = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            grpOilAndLube.SuspendLayout();
            grpFlushes.SuspendLayout();
            grpMisc.SuspendLayout();
            grpPartsLabor.SuspendLayout();
            grpSummary.SuspendLayout();
            SuspendLayout();
            // 
            // chkOilChange
            // 
            chkOilChange.AutoSize = true;
            chkOilChange.Location = new Point(15, 25);
            chkOilChange.Name = "chkOilChange";
            chkOilChange.Size = new Size(114, 19);
            chkOilChange.TabIndex = 0;
            chkOilChange.Text = "Oil Change ($50)";
            chkOilChange.UseVisualStyleBackColor = true;
            // 
            // chkLubeJob
            // 
            chkLubeJob.AutoSize = true;
            chkLubeJob.Location = new Point(15, 50);
            chkLubeJob.Name = "chkLubeJob";
            chkLubeJob.Size = new Size(102, 19);
            chkLubeJob.TabIndex = 1;
            chkLubeJob.Text = "Lube Job ($40)";
            chkLubeJob.UseVisualStyleBackColor = true;
            // 
            // grpOilAndLube
            // 
            grpOilAndLube.Controls.Add(chkOilChange);
            grpOilAndLube.Controls.Add(chkLubeJob);
            grpOilAndLube.Location = new Point(74, 42);
            grpOilAndLube.Name = "grpOilAndLube";
            grpOilAndLube.Size = new Size(213, 100);
            grpOilAndLube.TabIndex = 2;
            grpOilAndLube.TabStop = false;
            grpOilAndLube.Text = "Oil and Lube";
            // 
            // grpFlushes
            // 
            grpFlushes.Controls.Add(chkRadiator);
            grpFlushes.Controls.Add(chkTransmission);
            grpFlushes.Location = new Point(301, 42);
            grpFlushes.Name = "grpFlushes";
            grpFlushes.Size = new Size(210, 100);
            grpFlushes.TabIndex = 3;
            grpFlushes.TabStop = false;
            grpFlushes.Text = "Flushes";
            // 
            // chkRadiator
            // 
            chkRadiator.AutoSize = true;
            chkRadiator.Location = new Point(15, 25);
            chkRadiator.Name = "chkRadiator";
            chkRadiator.Size = new Size(136, 19);
            chkRadiator.TabIndex = 0;
            chkRadiator.Text = "Radiator Flush ($100)";
            chkRadiator.UseVisualStyleBackColor = true;
            // 
            // chkTransmission
            // 
            chkTransmission.AutoSize = true;
            chkTransmission.Location = new Point(15, 50);
            chkTransmission.Name = "chkTransmission";
            chkTransmission.Size = new Size(161, 19);
            chkTransmission.TabIndex = 1;
            chkTransmission.Text = "Transmission Flush ($120)";
            chkTransmission.UseVisualStyleBackColor = true;
            // 
            // grpMisc
            // 
            grpMisc.Controls.Add(chkTire);
            grpMisc.Controls.Add(chkInspection);
            grpMisc.Controls.Add(chkReplace);
            grpMisc.Location = new Point(74, 148);
            grpMisc.Name = "grpMisc";
            grpMisc.Size = new Size(213, 100);
            grpMisc.TabIndex = 3;
            grpMisc.TabStop = false;
            grpMisc.Text = "Misc";
            // 
            // chkTire
            // 
            chkTire.AutoSize = true;
            chkTire.Location = new Point(15, 75);
            chkTire.Name = "chkTire";
            chkTire.Size = new Size(123, 19);
            chkTire.TabIndex = 2;
            chkTire.Text = "Tire Rotation ($25)";
            chkTire.UseVisualStyleBackColor = true;
            // 
            // chkInspection
            // 
            chkInspection.AutoSize = true;
            chkInspection.Location = new Point(15, 25);
            chkInspection.Name = "chkInspection";
            chkInspection.Size = new Size(110, 19);
            chkInspection.TabIndex = 0;
            chkInspection.Text = "Inspection ($35)";
            chkInspection.UseVisualStyleBackColor = true;
            // 
            // chkReplace
            // 
            chkReplace.AutoSize = true;
            chkReplace.Location = new Point(15, 50);
            chkReplace.Name = "chkReplace";
            chkReplace.Size = new Size(144, 19);
            chkReplace.TabIndex = 1;
            chkReplace.Text = "Replace Muffler ($150)";
            chkReplace.UseVisualStyleBackColor = true;
            // 
            // grpPartsLabor
            // 
            grpPartsLabor.Controls.Add(lblHours);
            grpPartsLabor.Controls.Add(lblParts);
            grpPartsLabor.Controls.Add(txtHourInput);
            grpPartsLabor.Controls.Add(txtPartsInput);
            grpPartsLabor.Location = new Point(301, 148);
            grpPartsLabor.Name = "grpPartsLabor";
            grpPartsLabor.Size = new Size(210, 100);
            grpPartsLabor.TabIndex = 4;
            grpPartsLabor.TabStop = false;
            grpPartsLabor.Text = "Parts and Labor";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(8, 68);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(83, 15);
            lblHours.TabIndex = 6;
            lblHours.Text = "Labor (Hours):";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Location = new Point(52, 39);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(36, 15);
            lblParts.TabIndex = 5;
            lblParts.Text = "Parts:";
            // 
            // txtHourInput
            // 
            txtHourInput.Location = new Point(94, 65);
            txtHourInput.Name = "txtHourInput";
            txtHourInput.Size = new Size(100, 23);
            txtHourInput.TabIndex = 1;
            // 
            // txtPartsInput
            // 
            txtPartsInput.Location = new Point(94, 31);
            txtPartsInput.Name = "txtPartsInput";
            txtPartsInput.Size = new Size(100, 23);
            txtPartsInput.TabIndex = 0;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(lblTotal);
            grpSummary.Controls.Add(txtTotal);
            grpSummary.Controls.Add(txtTax);
            grpSummary.Controls.Add(label1);
            grpSummary.Controls.Add(txtLaborSummary);
            grpSummary.Controls.Add(lblServiceandLabor);
            grpSummary.Controls.Add(txtPartsSummary);
            grpSummary.Controls.Add(lblPartSum);
            grpSummary.Location = new Point(152, 254);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(285, 144);
            grpSummary.TabIndex = 5;
            grpSummary.TabStop = false;
            grpSummary.Text = "Summary";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(76, 117);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 15);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total Fees";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(149, 109);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 12;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(149, 80);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 88);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 10;
            label1.Text = "Tax (on parts):";
            // 
            // txtLaborSummary
            // 
            txtLaborSummary.Location = new Point(149, 22);
            txtLaborSummary.Name = "txtLaborSummary";
            txtLaborSummary.ReadOnly = true;
            txtLaborSummary.Size = new Size(100, 23);
            txtLaborSummary.TabIndex = 9;
            // 
            // lblServiceandLabor
            // 
            lblServiceandLabor.AutoSize = true;
            lblServiceandLabor.Location = new Point(32, 30);
            lblServiceandLabor.Name = "lblServiceandLabor";
            lblServiceandLabor.Size = new Size(103, 15);
            lblServiceandLabor.TabIndex = 8;
            lblServiceandLabor.Text = "Service and Labor:";
            // 
            // txtPartsSummary
            // 
            txtPartsSummary.Location = new Point(149, 51);
            txtPartsSummary.Name = "txtPartsSummary";
            txtPartsSummary.ReadOnly = true;
            txtPartsSummary.Size = new Size(100, 23);
            txtPartsSummary.TabIndex = 7;
            // 
            // lblPartSum
            // 
            lblPartSum.AutoSize = true;
            lblPartSum.Location = new Point(99, 59);
            lblPartSum.Name = "lblPartSum";
            lblPartSum.Size = new Size(36, 15);
            lblPartSum.TabIndex = 7;
            lblPartSum.Text = "Parts:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(152, 415);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(261, 415);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(362, 415);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // JoeAutomotiveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(591, 493);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(grpSummary);
            Controls.Add(grpPartsLabor);
            Controls.Add(grpMisc);
            Controls.Add(grpFlushes);
            Controls.Add(grpOilAndLube);
            Name = "JoeAutomotiveForm";
            Text = "Joe's Automotive";
            grpOilAndLube.ResumeLayout(false);
            grpOilAndLube.PerformLayout();
            grpFlushes.ResumeLayout(false);
            grpFlushes.PerformLayout();
            grpMisc.ResumeLayout(false);
            grpMisc.PerformLayout();
            grpPartsLabor.ResumeLayout(false);
            grpPartsLabor.PerformLayout();
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox chkOilChange;
        private CheckBox chkLubeJob;
        private GroupBox grpOilAndLube;
        private GroupBox grpFlushes;
        private CheckBox chkRadiator;
        private CheckBox chkTransmission;
        private GroupBox grpMisc;
        private CheckBox chkTire;
        private CheckBox chkInspection;
        private CheckBox chkReplace;
        private GroupBox grpPartsLabor;
        private Label lblParts;
        private TextBox txtHourInput;
        private TextBox txtPartsInput;
        private Label lblHours;
        private GroupBox grpSummary;
        private TextBox txtPartsSummary;
        private Label lblPartSum;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtTax;
        private Label label1;
        private TextBox txtLaborSummary;
        private Label lblServiceandLabor;
        private TextBox txtTotal;
        private Label lblTotal;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
