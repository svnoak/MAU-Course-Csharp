namespace PartyOrganizer
{
    partial class MainForm
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
            this.groupParty = new System.Windows.Forms.GroupBox();
            this.btnCreateParty = new System.Windows.Forms.Button();
            this.inputFeesGuests = new System.Windows.Forms.TextBox();
            this.inputCostGuests = new System.Windows.Forms.TextBox();
            this.inputNumGuests = new System.Windows.Forms.TextBox();
            this.labelFeesGuests = new System.Windows.Forms.Label();
            this.labelCostGuests = new System.Windows.Forms.Label();
            this.labelMaxNumGuests = new System.Windows.Forms.Label();
            this.groupGuest = new System.Windows.Forms.GroupBox();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.groupSummary = new System.Windows.Forms.GroupBox();
            this.resultProfit = new System.Windows.Forms.Label();
            this.resultTotalCost = new System.Windows.Forms.Label();
            this.resultNumGuests = new System.Windows.Forms.Label();
            this.resultTotalFees = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelTotFees = new System.Windows.Forms.Label();
            this.labelTotCosts = new System.Windows.Forms.Label();
            this.labelNumGuests = new System.Windows.Forms.Label();
            this.listGuests = new System.Windows.Forms.ListBox();
            this.labelGuestList = new System.Windows.Forms.Label();
            this.btnDeleteGuest = new System.Windows.Forms.Button();
            this.groupParty.SuspendLayout();
            this.groupGuest.SuspendLayout();
            this.groupSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupParty
            // 
            this.groupParty.Controls.Add(this.btnCreateParty);
            this.groupParty.Controls.Add(this.inputFeesGuests);
            this.groupParty.Controls.Add(this.inputCostGuests);
            this.groupParty.Controls.Add(this.inputNumGuests);
            this.groupParty.Controls.Add(this.labelFeesGuests);
            this.groupParty.Controls.Add(this.labelCostGuests);
            this.groupParty.Controls.Add(this.labelMaxNumGuests);
            this.groupParty.Location = new System.Drawing.Point(17, 7);
            this.groupParty.Name = "groupParty";
            this.groupParty.Size = new System.Drawing.Size(296, 160);
            this.groupParty.TabIndex = 0;
            this.groupParty.TabStop = false;
            this.groupParty.Text = "New Party";
            // 
            // btnCreateParty
            // 
            this.btnCreateParty.Location = new System.Drawing.Point(91, 121);
            this.btnCreateParty.Name = "btnCreateParty";
            this.btnCreateParty.Size = new System.Drawing.Size(109, 33);
            this.btnCreateParty.TabIndex = 6;
            this.btnCreateParty.Text = "Create";
            this.btnCreateParty.UseVisualStyleBackColor = true;
            this.btnCreateParty.Click += new System.EventHandler(this.btnCreateParty_Click);
            // 
            // inputFeesGuests
            // 
            this.inputFeesGuests.Location = new System.Drawing.Point(168, 92);
            this.inputFeesGuests.Name = "inputFeesGuests";
            this.inputFeesGuests.Size = new System.Drawing.Size(100, 23);
            this.inputFeesGuests.TabIndex = 5;
            // 
            // inputCostGuests
            // 
            this.inputCostGuests.Location = new System.Drawing.Point(168, 63);
            this.inputCostGuests.Name = "inputCostGuests";
            this.inputCostGuests.Size = new System.Drawing.Size(100, 23);
            this.inputCostGuests.TabIndex = 4;
            // 
            // inputNumGuests
            // 
            this.inputNumGuests.Location = new System.Drawing.Point(168, 34);
            this.inputNumGuests.Name = "inputNumGuests";
            this.inputNumGuests.Size = new System.Drawing.Size(100, 23);
            this.inputNumGuests.TabIndex = 3;
            // 
            // labelFeesGuests
            // 
            this.labelFeesGuests.AutoSize = true;
            this.labelFeesGuests.Location = new System.Drawing.Point(27, 95);
            this.labelFeesGuests.Name = "labelFeesGuests";
            this.labelFeesGuests.Size = new System.Drawing.Size(82, 15);
            this.labelFeesGuests.TabIndex = 2;
            this.labelFeesGuests.Text = "Fees per guest";
            // 
            // labelCostGuests
            // 
            this.labelCostGuests.AutoSize = true;
            this.labelCostGuests.Location = new System.Drawing.Point(27, 66);
            this.labelCostGuests.Name = "labelCostGuests";
            this.labelCostGuests.Size = new System.Drawing.Size(83, 15);
            this.labelCostGuests.TabIndex = 1;
            this.labelCostGuests.Text = "Cost per guest";
            // 
            // labelMaxNumGuests
            // 
            this.labelMaxNumGuests.AutoSize = true;
            this.labelMaxNumGuests.Location = new System.Drawing.Point(27, 37);
            this.labelMaxNumGuests.Name = "labelMaxNumGuests";
            this.labelMaxNumGuests.Size = new System.Drawing.Size(126, 15);
            this.labelMaxNumGuests.TabIndex = 0;
            this.labelMaxNumGuests.Text = "Max number of guests";
            // 
            // groupGuest
            // 
            this.groupGuest.Controls.Add(this.btnAddGuest);
            this.groupGuest.Controls.Add(this.inputLastName);
            this.groupGuest.Controls.Add(this.labelLastName);
            this.groupGuest.Controls.Add(this.inputFirstName);
            this.groupGuest.Controls.Add(this.labelFirstName);
            this.groupGuest.Location = new System.Drawing.Point(17, 175);
            this.groupGuest.Name = "groupGuest";
            this.groupGuest.Size = new System.Drawing.Size(296, 128);
            this.groupGuest.TabIndex = 1;
            this.groupGuest.TabStop = false;
            this.groupGuest.Text = "Add Guest";
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Location = new System.Drawing.Point(91, 89);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(109, 33);
            this.btnAddGuest.TabIndex = 7;
            this.btnAddGuest.Text = "Add";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // inputLastName
            // 
            this.inputLastName.Location = new System.Drawing.Point(97, 60);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(171, 23);
            this.inputLastName.TabIndex = 6;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(27, 63);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(63, 15);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Last Name";
            // 
            // inputFirstName
            // 
            this.inputFirstName.Location = new System.Drawing.Point(97, 31);
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(171, 23);
            this.inputFirstName.TabIndex = 5;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(27, 34);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(64, 15);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // groupSummary
            // 
            this.groupSummary.Controls.Add(this.resultProfit);
            this.groupSummary.Controls.Add(this.resultTotalCost);
            this.groupSummary.Controls.Add(this.resultNumGuests);
            this.groupSummary.Controls.Add(this.resultTotalFees);
            this.groupSummary.Controls.Add(this.labelResults);
            this.groupSummary.Controls.Add(this.labelTotFees);
            this.groupSummary.Controls.Add(this.labelTotCosts);
            this.groupSummary.Controls.Add(this.labelNumGuests);
            this.groupSummary.Location = new System.Drawing.Point(17, 311);
            this.groupSummary.Name = "groupSummary";
            this.groupSummary.Size = new System.Drawing.Size(296, 152);
            this.groupSummary.TabIndex = 2;
            this.groupSummary.TabStop = false;
            this.groupSummary.Text = "Party Summary";
            // 
            // resultProfit
            // 
            this.resultProfit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultProfit.Location = new System.Drawing.Point(168, 101);
            this.resultProfit.Name = "resultProfit";
            this.resultProfit.Size = new System.Drawing.Size(100, 23);
            this.resultProfit.TabIndex = 10;
            this.resultProfit.Text = "0";
            this.resultProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resultTotalCost
            // 
            this.resultTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultTotalCost.Location = new System.Drawing.Point(168, 55);
            this.resultTotalCost.Name = "resultTotalCost";
            this.resultTotalCost.Size = new System.Drawing.Size(100, 23);
            this.resultTotalCost.TabIndex = 8;
            this.resultTotalCost.Text = "0";
            this.resultTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resultNumGuests
            // 
            this.resultNumGuests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultNumGuests.Location = new System.Drawing.Point(168, 32);
            this.resultNumGuests.Name = "resultNumGuests";
            this.resultNumGuests.Size = new System.Drawing.Size(100, 23);
            this.resultNumGuests.TabIndex = 7;
            this.resultNumGuests.Text = "0";
            this.resultNumGuests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resultTotalFees
            // 
            this.resultTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultTotalFees.Location = new System.Drawing.Point(168, 78);
            this.resultTotalFees.Name = "resultTotalFees";
            this.resultTotalFees.Size = new System.Drawing.Size(100, 23);
            this.resultTotalFees.TabIndex = 9;
            this.resultTotalFees.Text = "0";
            this.resultTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(27, 105);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(39, 15);
            this.labelResults.TabIndex = 6;
            this.labelResults.Text = "Result";
            // 
            // labelTotFees
            // 
            this.labelTotFees.AutoSize = true;
            this.labelTotFees.Location = new System.Drawing.Point(27, 82);
            this.labelTotFees.Name = "labelTotFees";
            this.labelTotFees.Size = new System.Drawing.Size(56, 15);
            this.labelTotFees.TabIndex = 5;
            this.labelTotFees.Text = "Total fees";
            // 
            // labelTotCosts
            // 
            this.labelTotCosts.AutoSize = true;
            this.labelTotCosts.Location = new System.Drawing.Point(27, 59);
            this.labelTotCosts.Name = "labelTotCosts";
            this.labelTotCosts.Size = new System.Drawing.Size(62, 15);
            this.labelTotCosts.TabIndex = 4;
            this.labelTotCosts.Text = "Total costs";
            // 
            // labelNumGuests
            // 
            this.labelNumGuests.AutoSize = true;
            this.labelNumGuests.Location = new System.Drawing.Point(27, 36);
            this.labelNumGuests.Name = "labelNumGuests";
            this.labelNumGuests.Size = new System.Drawing.Size(103, 15);
            this.labelNumGuests.TabIndex = 3;
            this.labelNumGuests.Text = "Number of Guests";
            // 
            // listGuests
            // 
            this.listGuests.FormattingEnabled = true;
            this.listGuests.ItemHeight = 15;
            this.listGuests.Location = new System.Drawing.Point(319, 25);
            this.listGuests.Name = "listGuests";
            this.listGuests.Size = new System.Drawing.Size(232, 364);
            this.listGuests.TabIndex = 4;
            // 
            // labelGuestList
            // 
            this.labelGuestList.AutoSize = true;
            this.labelGuestList.Location = new System.Drawing.Point(407, 9);
            this.labelGuestList.Name = "labelGuestList";
            this.labelGuestList.Size = new System.Drawing.Size(58, 15);
            this.labelGuestList.TabIndex = 5;
            this.labelGuestList.Text = "Guest List";
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.Location = new System.Drawing.Point(383, 409);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(112, 32);
            this.btnDeleteGuest.TabIndex = 8;
            this.btnDeleteGuest.Text = "Delete";
            this.btnDeleteGuest.UseVisualStyleBackColor = true;
            this.btnDeleteGuest.Click += new System.EventHandler(this.btnDeleteGuest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 473);
            this.Controls.Add(this.btnDeleteGuest);
            this.Controls.Add(this.labelGuestList);
            this.Controls.Add(this.listGuests);
            this.Controls.Add(this.groupSummary);
            this.Controls.Add(this.groupGuest);
            this.Controls.Add(this.groupParty);
            this.Name = "MainForm";
            this.Text = "Party Organizer by Kim Siebeneicher";
            this.groupParty.ResumeLayout(false);
            this.groupParty.PerformLayout();
            this.groupGuest.ResumeLayout(false);
            this.groupGuest.PerformLayout();
            this.groupSummary.ResumeLayout(false);
            this.groupSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupParty;
        private Button btnCreateParty;
        private TextBox inputFeesGuests;
        private TextBox inputCostGuests;
        private TextBox inputNumGuests;
        private Label labelFeesGuests;
        private Label labelCostGuests;
        private Label labelMaxNumGuests;
        private GroupBox groupGuest;
        private Button btnAddGuest;
        private TextBox inputLastName;
        private Label labelLastName;
        private TextBox inputFirstName;
        private Label labelFirstName;
        private GroupBox groupSummary;
        private Label resultProfit;
        private Label resultTotalFees;
        private Label resultTotalCost;
        private Label resultNumGuests;
        private Label labelResults;
        private Label labelTotFees;
        private Label labelTotCosts;
        private Label labelNumGuests;
        private ListBox listGuests;
        private Label labelGuestList;
        private Button btnDeleteGuest;
    }
}