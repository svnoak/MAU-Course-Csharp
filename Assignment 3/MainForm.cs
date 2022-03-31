namespace Assignment_3
{
    public partial class MainForm : Form
    {

        private string name = string.Empty;
        private BMICalculator bmiCalc = new BMICalculator();
        private SavingsCalculator savingCalc = new SavingsCalculator();
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            // Empties all fields that could be populated
            this.Text = "Super Calculator by Kim Siebeneicher";
            ClearBMI();
            ClearSavings();
        }

        // Clear all BMI side fields
        private void ClearBMI()
        {
            resultBMI.Text = string.Empty;
            resultCat.Text = string.Empty;
            radioMetric.Checked = true;
            textHeight1.Text = string.Empty;
            textHeight2.Text = string.Empty;
            textWeight.Text = string.Empty;
        }


        // Clear all savings side fields
        private void ClearSavings()
        {
            inputMonthlyDeposit.Text = string.Empty;
            inputPeriod.Text = string.Empty;
            resultBalance.Text = string.Empty;
            resultAmount.Text = string.Empty;
        }

        private void UpdateForm()
        {
            // Updates all relevant fields depending on Metric or Imperial units
            // Sets precondition for CalculateBMI method in bmiCalc on unit.
            if (radioMetric.Checked) { 
                labelHeight.Text = "Height (cm)";
                labelWeight.Text = "Weight (kg)";
                textHeight2.Visible = false;
                textHeight1.PlaceholderText = "cm";
                textWeight.PlaceholderText = "kg";
                textHeight1.Text = string.Empty;
                textHeight2.Text = string.Empty;
                textWeight.Text = string.Empty;
                bmiCalc.SetUnit(UnitTypes.Metric);
            }
            else
            {
                labelHeight.Text = "Height (in)";
                labelWeight.Text = "Weight (lbs)";
                textHeight2.Visible = true;
                textHeight1.PlaceholderText = "ft";
                textWeight.PlaceholderText = "lbs";
                textHeight1.Text = string.Empty;
                textHeight2.Text = string.Empty;
                textWeight.Text = string.Empty;
                bmiCalc.SetUnit(UnitTypes.Imperial);
            }
        }

        private void radioMetric_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void radioUS_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Triggers all calculations and field contents.
            bmiCalc.SetName(textName.Text);
            resultsBox.Text = "Results for " + bmiCalc.GetName();

            bool ok = ReadInputBMI();

            if (ok)
                CalculateAndDisplayResults();

            
        }

        private bool ReadInputBMI()
        {
            // Checks that all heights and weights are legal.
            bool heightOK = ReadHeight();
            bool weightOK = ReadWeight();

            return heightOK && weightOK;
        }

        private void CalculateAndDisplayResults()
        {
            // Triggers calculation and displays results.
            double bmi = bmiCalc.CalculateBMI();
            resultBMI.Text = bmi.ToString("0.##");
            resultCat.Text = bmiCalc.BmiWeightCategory();

        }

        private bool ReadHeight()
        {
            // Contains check of height and returns message on error.
            // Sets height in bmiCalc on success
            double height = 0.0;

            bool ok = double.TryParse(textHeight1.Text, out height);

            if (!ok)
            {
                MessageBox.Show("The height value is invalid!", "Error");
            }

            double inch = 0.0;
            if( radioUS.Checked )
            {
                ok = ok && double.TryParse(textHeight2.Text, out inch);

                if( !ok)
                {
                    MessageBox.Show("The inch value is invalid!", "Error");
                }
            }

            // cm --> m, ft --> in
            if (bmiCalc.GetUnit() == UnitTypes.Imperial)
            {
                height = height * 12.0 + inch;
            }
            else
            {
                height = height / 100;
            }

            bmiCalc.SetHeight(height);

            return ok;
        }

        private bool ReadWeight()
        {
            // Contains check of weight and returns message on error.
            // Sets weight in bmiCalc on success
            double weight = 0.0;

            bool ok = double.TryParse( textWeight.Text, out weight);
            if (!ok)
            {
                MessageBox.Show("The weight value is invalid", "Error");
            }

            bmiCalc.SetWeight(weight);

            return ok;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcSavings_Click(object sender, EventArgs e)
        {
            ReadSavingInput();
            ReadPeriodInput();
            savingCalc.InterestRate = .10 / 12;

            double amountPaid = savingCalc.amountPaid();
            double balance = savingCalc.caluclateSavings();

            resultAmount.Text = amountPaid.ToString("0.00");
            resultBalance.Text = balance.ToString("0.00");
        }

        // Check that input is actually a double
        private double ReadDouble (string str, out bool success)
        {
            double value = -1.00;
            success = false;
            if (double.TryParse(str, out value))
                success = true;

            return value;
        }

        // Check that input is actually an integer.
        private int ReadInt(string str, out bool success)
        {
            int value = -1;
            success = false;
            if (int.TryParse(str, out value))
                success = true;

            return value;
        }

        // Read monthly deposit field
        private void ReadSavingInput()
        {
            bool success = true;
            double monthlyDeposit = ReadDouble(inputMonthlyDeposit.Text, out success);
            if (success)
                savingCalc.MonthlyDeposit = monthlyDeposit;
            else
            {
                MessageBox.Show("Invalid value for monthly deposit!");
                return;
            }
        }

        // Read period field
        private void ReadPeriodInput()
        {
            bool success = true;
            int period = ReadInt(inputPeriod.Text, out success);
            if (success)
                savingCalc.Period = period;
            else
            {
                MessageBox.Show("Invalid value for period in years!");
                return;
            }
        }

    }
}