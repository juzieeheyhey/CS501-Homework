using System.IO;

namespace Prob6._4
{
    public partial class JoeAutomotiveForm : Form
    {
        public JoeAutomotiveForm()
        {
            InitializeComponent();
        }

        // Declare constants
        const decimal OIL_CHANGE = 50.00m;
        const decimal LUBE_JOB = 40.00m;
        const decimal RADIATOR_FLUSH = 100.00m;
        const decimal TRANSMISSION_FLUSH = 120.00m;
        const decimal INSPECTION = 35.00m;
        const decimal MUFFLER_REPLACEMENT = 150.00m;
        const decimal TIRE_ROTATION = 25.00m;
        const decimal LABOR_RATE = 75.00m; // per hour
        const decimal TAX_RATE = 0.0625m; // 6.25% MA tax rate

        private decimal OilChangeCharge()
        {
            if (chkOilChange.Checked)
            {
                return OIL_CHANGE;
            }
            else
            {
                return 0.00m;
            }

        }

        private decimal LubeJobCharge()
        {
            if (chkLubeJob.Checked)
            {
                return LUBE_JOB;
            }
            else
            {
                return 0.00m;
            }
        }

        private decimal RadiatorFlushCharge()
        {
            if (chkRadiator.Checked)
            {
                return RADIATOR_FLUSH;
            }
            else
            {
                return 0.00m;
            }

        }

        private decimal TransmissionFlushCharge()
        {
            if (chkTransmission.Checked)
            {
                return TRANSMISSION_FLUSH;
            }
            else
            {
                return 0.00m;
            }
        }

        private decimal InspectionCharge()
        {
            if (chkInspection.Checked)
            {
                return INSPECTION;
            }
            else
            {
                return 0.00m;
            }
        }

        private decimal MufflerReplacementCharge()
        {
            if (chkReplace.Checked)
            {
                return MUFFLER_REPLACEMENT;
            }
            else
            {
                return 0.00m;
            }
        }

        private decimal TireRotationCharge()
        {
            if (chkTire.Checked)
            {
                return TIRE_ROTATION;
            }
            else
            {
                return 0.00m;
            }
        }

        private decimal PartsCharge()
        {
            var parts = txtPartsInput.Text.Trim();
            if (string.IsNullOrEmpty(parts)) // if user leaves it blank
            {
                return 0.00m;
            }
            else if (decimal.TryParse(parts, out decimal partsCharge) && partsCharge >= 0)
            {
                return partsCharge; // valid input --> return the charge
            }
            else
            {
                // invalid input --> show error message and return 0
                MessageBox.Show("Please enter a valid non-negative number for parts charge.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartsInput.Focus();
                return 0.00m;
            }
        }

        private decimal LaborCharge()
        {
            var hours = txtHourInput.Text.Trim();
            if (string.IsNullOrEmpty(hours)) // if user leaves it blank
            {
                return 0.00m;
            }
            else if (decimal.TryParse(hours, out decimal laborHours) && laborHours >= 0)
            {
                return laborHours * LABOR_RATE; // valid input --> return the charge
            }
            else
            {
                // invalid input --> show error message and return 0
                MessageBox.Show("Please enter a valid non-negative number for labor hours.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHourInput.Focus();
                return 0.00m;
            }
        }

        private decimal TaxCharge(decimal partsCharge)
        {
            return partsCharge * TAX_RATE;
        }

        private decimal ServicesCharge(decimal oilChange, decimal lubeJob, decimal radiatorFlush, decimal transmissionFlush, decimal inspection, decimal mufflerReplacement, decimal tireRotation)
        {
            return oilChange + lubeJob + radiatorFlush + transmissionFlush + inspection + mufflerReplacement + tireRotation;
        }

        private decimal TotalCharge(decimal servicesCharge, decimal partsCharge, decimal laborCharge, decimal taxCharge)
        {
            return servicesCharge + partsCharge + laborCharge + taxCharge;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal oilChange = OilChangeCharge();
            decimal lubeJob = LubeJobCharge();
            decimal radiatorFlush = RadiatorFlushCharge();
            decimal transmissionFlush = TransmissionFlushCharge();
            decimal inspection = InspectionCharge();
            decimal mufflerReplacement = MufflerReplacementCharge();
            decimal tireRotation = TireRotationCharge();
            decimal partsCharge = PartsCharge();
            decimal laborCharge = LaborCharge();
            decimal taxCharge = TaxCharge(partsCharge);
            decimal servicesCharge = ServicesCharge(oilChange, lubeJob, radiatorFlush, transmissionFlush, inspection, mufflerReplacement, tireRotation);
            decimal totalCharge = TotalCharge(servicesCharge, partsCharge, laborCharge, taxCharge);
            // Display the results formatted as currency
            txtLaborSummary.Text = servicesCharge.ToString("c");
            txtPartsSummary.Text = partsCharge.ToString("c");
            txtTax.Text = taxCharge.ToString("c");
            txtTotal.Text = totalCharge.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLaborSummary.Clear();
            txtPartsSummary.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            txtPartsInput.Clear();
            txtHourInput.Clear();
            chkOilChange.Checked = false;
            chkLubeJob.Checked = false;
            chkRadiator.Checked = false;
            chkTransmission.Checked = false;
            chkInspection.Checked = false;
            chkReplace.Checked = false;
            chkTire.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
