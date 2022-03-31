namespace PartyOrganizer
{
    public partial class MainForm : Form
    {
        PartyManager partyManager;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            ClearInputControls();
            ClearOutPutControls();

            groupParty.Enabled = true;
            groupGuest.Enabled = false;
            btnDeleteGuest.Enabled = false;
        }

        private void ClearInputControls()
        {
            inputNumGuests.Text = string.Empty;
            inputCostGuests.Text = string.Empty;
            inputFeesGuests.Text = string.Empty;
            inputFirstName.Text = string.Empty;
            inputLastName.Text = string.Empty;
        }

        private void ClearOutPutControls()
        {
            resultNumGuests.Text = "0";
            resultTotalCost.Text = "0.00";
            resultTotalFees.Text = "0.00";
            resultProfit.Text = "0.00";
            listGuests.Items.Clear();
        }

        private void btnCreateParty_Click(object sender, EventArgs e)
        {
            bool maxNumOK = CreateParty();
            if (!maxNumOK)
                return;

            bool amountOK = ReadCostPerPerson() && ReadFeePerPerson();

            if (maxNumOK && amountOK)
            {
                groupGuest.Enabled = true;
                UpdateGUI();
            }

        }

        private bool ReadCostPerPerson()
        {
            double cost;
            if( double.TryParse(inputCostGuests.Text, out cost))
            {
                partyManager.CostPerPerson = cost;
                return true;
            }
            return false;
        }

        private bool ReadFeePerPerson()
        {
            double fee;
            if (double.TryParse(inputFeesGuests.Text, out fee))
            {
                partyManager.FeePerPerson = fee;
                return true;
            }
            return false;
        }

        private bool CreateParty()
        {
            int maxNumber = 0;
            bool ok = true;

            if (int.TryParse(inputNumGuests.Text, out maxNumber) && maxNumber > 0)
            {
                partyManager = new PartyManager(maxNumber);
                MessageBox.Show($"Party list with space for {maxNumber} guests created!", "Success");
            }
            else
            {
                MessageBox.Show("Invalid Total Number. Please try again!", "Error");
                ok = false;
            }
            return ok;
        }

        private void UpdateGUI()
        {
            listGuests.Items.Clear();
            string[] guestList = partyManager.GetGuestList();

            int numGuests = 0;
            double totalCost = 0.00;
            double totalFees = 0.00;
            double profit = 0.00;

            if (guestList != null)
            {
                for (int i = 0; i < guestList.Length; i++)
                {
                    string str = $"{i + 1,4} {guestList[i],-20}";
                    listGuests.Items.Add(str);
                }
                btnDeleteGuest.Enabled = true;
                numGuests = partyManager.GetGuestList().Length;
                totalCost = partyManager.CalcTotalCost();
                totalFees = partyManager.CalcTotalFees();
                profit = partyManager.CalcProfit();
            }
            else
            {
                btnDeleteGuest.Enabled = false;
            }

            resultNumGuests.Text = numGuests.ToString();
            resultTotalCost.Text = totalCost.ToString("0.00");
            resultTotalFees.Text = totalFees.ToString("0.00");
            resultProfit.Text = profit.ToString("0.00");
        }

        private bool ValidateText(string text, string errMessage)
        {
            text = text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show(errMessage, "Error");
                return false;
            }
            return true;
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            bool firstNameOK = ValidateText(inputFirstName.Text, "First name must be given!");
            bool lastNameOK = ValidateText(inputLastName.Text, "Last name must be given!");

            if( firstNameOK && lastNameOK)
            {
                string firstName = inputFirstName.Text.Trim();
                string lastName = inputLastName.Text.Trim();
                partyManager.AddNewGuest(firstName, lastName);
                UpdateGUI();
            }
        }

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            int guestIndex = listGuests.SelectedIndex;
            
            partyManager.DeleteAt(guestIndex);
            UpdateGUI();
        }
    }
}