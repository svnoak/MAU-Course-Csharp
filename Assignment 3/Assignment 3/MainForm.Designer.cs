namespace Assignment_3
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
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.radioMetric = new System.Windows.Forms.RadioButton();
            this.radioUS = new System.Windows.Forms.RadioButton();
            this.UnitSettings = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.GroupBox();
            this.resultCat = new System.Windows.Forms.Label();
            this.resultBMI = new System.Windows.Forms.Label();
            this.labelResultCat = new System.Windows.Forms.Label();
            this.labelResultBMI = new System.Windows.Forms.Label();
            this.textHeight1 = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textHeight2 = new System.Windows.Forms.TextBox();
            this.groupSaving = new System.Windows.Forms.GroupBox();
            this.labelMonthlyDeposit = new System.Windows.Forms.Label();
            this.inputMonthlyDeposit = new System.Windows.Forms.TextBox();
            this.inputPeriod = new System.Windows.Forms.TextBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.groupFutureValue = new System.Windows.Forms.GroupBox();
            this.btnCalcSavings = new System.Windows.Forms.Button();
            this.labelFinalBalance = new System.Windows.Forms.Label();
            this.labelAmountPaid = new System.Windows.Forms.Label();
            this.resultAmount = new System.Windows.Forms.Label();
            this.resultBalance = new System.Windows.Forms.Label();
            this.UnitSettings.SuspendLayout();
            this.resultsBox.SuspendLayout();
            this.groupSaving.SuspendLayout();
            this.groupFutureValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(94, 12);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(323, 23);
            this.textName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Your Name";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(12, 64);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(71, 15);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "Height (cm)";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(12, 93);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(69, 15);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Weight (kg)";
            // 
            // radioMetric
            // 
            this.radioMetric.AutoSize = true;
            this.radioMetric.Location = new System.Drawing.Point(15, 22);
            this.radioMetric.Name = "radioMetric";
            this.radioMetric.Size = new System.Drawing.Size(131, 19);
            this.radioMetric.TabIndex = 6;
            this.radioMetric.TabStop = true;
            this.radioMetric.Text = "Metric Unit (kg, cm)";
            this.radioMetric.UseVisualStyleBackColor = true;
            this.radioMetric.CheckedChanged += new System.EventHandler(this.radioMetric_CheckedChanged);
            // 
            // radioUS
            // 
            this.radioUS.AutoSize = true;
            this.radioUS.Location = new System.Drawing.Point(15, 47);
            this.radioUS.Name = "radioUS";
            this.radioUS.Size = new System.Drawing.Size(118, 19);
            this.radioUS.TabIndex = 7;
            this.radioUS.TabStop = true;
            this.radioUS.Text = "US Unit (foot, lbs)";
            this.radioUS.UseVisualStyleBackColor = true;
            this.radioUS.CheckedChanged += new System.EventHandler(this.radioUS_CheckedChanged);
            // 
            // UnitSettings
            // 
            this.UnitSettings.Controls.Add(this.radioUS);
            this.UnitSettings.Controls.Add(this.radioMetric);
            this.UnitSettings.Location = new System.Drawing.Point(255, 51);
            this.UnitSettings.Name = "UnitSettings";
            this.UnitSettings.Size = new System.Drawing.Size(162, 75);
            this.UnitSettings.TabIndex = 9;
            this.UnitSettings.TabStop = false;
            this.UnitSettings.Text = "Unit";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(149, 132);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(140, 32);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.Controls.Add(this.resultCat);
            this.resultsBox.Controls.Add(this.resultBMI);
            this.resultsBox.Controls.Add(this.labelResultCat);
            this.resultsBox.Controls.Add(this.labelResultBMI);
            this.resultsBox.Location = new System.Drawing.Point(12, 196);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(389, 108);
            this.resultsBox.TabIndex = 11;
            this.resultsBox.TabStop = false;
            this.resultsBox.Text = "Results for";
            // 
            // resultCat
            // 
            this.resultCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultCat.Location = new System.Drawing.Point(150, 66);
            this.resultCat.Name = "resultCat";
            this.resultCat.Size = new System.Drawing.Size(226, 23);
            this.resultCat.TabIndex = 5;
            this.resultCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultBMI
            // 
            this.resultBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultBMI.Location = new System.Drawing.Point(276, 34);
            this.resultBMI.Name = "resultBMI";
            this.resultBMI.Size = new System.Drawing.Size(100, 23);
            this.resultBMI.TabIndex = 4;
            this.resultBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResultCat
            // 
            this.labelResultCat.AutoSize = true;
            this.labelResultCat.Location = new System.Drawing.Point(6, 66);
            this.labelResultCat.Name = "labelResultCat";
            this.labelResultCat.Size = new System.Drawing.Size(96, 15);
            this.labelResultCat.TabIndex = 2;
            this.labelResultCat.Text = "Weight Category";
            // 
            // labelResultBMI
            // 
            this.labelResultBMI.AutoSize = true;
            this.labelResultBMI.Location = new System.Drawing.Point(6, 35);
            this.labelResultBMI.Name = "labelResultBMI";
            this.labelResultBMI.Size = new System.Drawing.Size(55, 15);
            this.labelResultBMI.TabIndex = 1;
            this.labelResultBMI.Text = "Your BMI";
            // 
            // textHeight1
            // 
            this.textHeight1.Location = new System.Drawing.Point(94, 61);
            this.textHeight1.Name = "textHeight1";
            this.textHeight1.Size = new System.Drawing.Size(54, 23);
            this.textHeight1.TabIndex = 12;
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(94, 90);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(54, 23);
            this.textWeight.TabIndex = 13;
            // 
            // textHeight2
            // 
            this.textHeight2.Location = new System.Drawing.Point(154, 61);
            this.textHeight2.Name = "textHeight2";
            this.textHeight2.PlaceholderText = "inch";
            this.textHeight2.Size = new System.Drawing.Size(54, 23);
            this.textHeight2.TabIndex = 14;
            // 
            // groupSaving
            // 
            this.groupSaving.Controls.Add(this.inputPeriod);
            this.groupSaving.Controls.Add(this.labelPeriod);
            this.groupSaving.Controls.Add(this.inputMonthlyDeposit);
            this.groupSaving.Controls.Add(this.labelMonthlyDeposit);
            this.groupSaving.Location = new System.Drawing.Point(462, 12);
            this.groupSaving.Name = "groupSaving";
            this.groupSaving.Size = new System.Drawing.Size(294, 114);
            this.groupSaving.TabIndex = 15;
            this.groupSaving.TabStop = false;
            this.groupSaving.Text = "Saving plan";
            // 
            // labelMonthlyDeposit
            // 
            this.labelMonthlyDeposit.AutoSize = true;
            this.labelMonthlyDeposit.Location = new System.Drawing.Point(6, 52);
            this.labelMonthlyDeposit.Name = "labelMonthlyDeposit";
            this.labelMonthlyDeposit.Size = new System.Drawing.Size(94, 15);
            this.labelMonthlyDeposit.TabIndex = 0;
            this.labelMonthlyDeposit.Text = "Monthly deposit";
            // 
            // inputMonthlyDeposit
            // 
            this.inputMonthlyDeposit.Location = new System.Drawing.Point(181, 49);
            this.inputMonthlyDeposit.Name = "inputMonthlyDeposit";
            this.inputMonthlyDeposit.Size = new System.Drawing.Size(107, 23);
            this.inputMonthlyDeposit.TabIndex = 1;
            // 
            // inputPeriod
            // 
            this.inputPeriod.Location = new System.Drawing.Point(181, 75);
            this.inputPeriod.Name = "inputPeriod";
            this.inputPeriod.Size = new System.Drawing.Size(107, 23);
            this.inputPeriod.TabIndex = 3;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(6, 78);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(79, 15);
            this.labelPeriod.TabIndex = 2;
            this.labelPeriod.Text = "Period (years)";
            // 
            // groupFutureValue
            // 
            this.groupFutureValue.Controls.Add(this.resultBalance);
            this.groupFutureValue.Controls.Add(this.resultAmount);
            this.groupFutureValue.Controls.Add(this.labelFinalBalance);
            this.groupFutureValue.Controls.Add(this.labelAmountPaid);
            this.groupFutureValue.Location = new System.Drawing.Point(462, 196);
            this.groupFutureValue.Name = "groupFutureValue";
            this.groupFutureValue.Size = new System.Drawing.Size(294, 108);
            this.groupFutureValue.TabIndex = 16;
            this.groupFutureValue.TabStop = false;
            this.groupFutureValue.Text = "Future value";
            // 
            // btnCalcSavings
            // 
            this.btnCalcSavings.Location = new System.Drawing.Point(539, 132);
            this.btnCalcSavings.Name = "btnCalcSavings";
            this.btnCalcSavings.Size = new System.Drawing.Size(140, 32);
            this.btnCalcSavings.TabIndex = 17;
            this.btnCalcSavings.Text = "Calculate savings";
            this.btnCalcSavings.UseVisualStyleBackColor = true;
            this.btnCalcSavings.Click += new System.EventHandler(this.btnCalcSavings_Click);
            // 
            // labelFinalBalance
            // 
            this.labelFinalBalance.AutoSize = true;
            this.labelFinalBalance.Location = new System.Drawing.Point(6, 61);
            this.labelFinalBalance.Name = "labelFinalBalance";
            this.labelFinalBalance.Size = new System.Drawing.Size(76, 15);
            this.labelFinalBalance.TabIndex = 6;
            this.labelFinalBalance.Text = "Final Balance";
            // 
            // labelAmountPaid
            // 
            this.labelAmountPaid.AutoSize = true;
            this.labelAmountPaid.Location = new System.Drawing.Point(6, 35);
            this.labelAmountPaid.Name = "labelAmountPaid";
            this.labelAmountPaid.Size = new System.Drawing.Size(77, 15);
            this.labelAmountPaid.TabIndex = 4;
            this.labelAmountPaid.Text = "Amount paid";
            // 
            // resultAmount
            // 
            this.resultAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultAmount.Location = new System.Drawing.Point(181, 31);
            this.resultAmount.Name = "resultAmount";
            this.resultAmount.Size = new System.Drawing.Size(107, 23);
            this.resultAmount.TabIndex = 7;
            this.resultAmount.Text = "0";
            this.resultAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resultBalance
            // 
            this.resultBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultBalance.Location = new System.Drawing.Point(181, 57);
            this.resultBalance.Name = "resultBalance";
            this.resultBalance.Size = new System.Drawing.Size(107, 23);
            this.resultBalance.TabIndex = 8;
            this.resultBalance.Text = "0";
            this.resultBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 316);
            this.Controls.Add(this.btnCalcSavings);
            this.Controls.Add(this.groupFutureValue);
            this.Controls.Add(this.groupSaving);
            this.Controls.Add(this.textHeight2);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textHeight1);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.UnitSettings);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator by Kim Siebeneicher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.UnitSettings.ResumeLayout(false);
            this.UnitSettings.PerformLayout();
            this.resultsBox.ResumeLayout(false);
            this.resultsBox.PerformLayout();
            this.groupSaving.ResumeLayout(false);
            this.groupSaving.PerformLayout();
            this.groupFutureValue.ResumeLayout(false);
            this.groupFutureValue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textName;
        private Label labelName;
        private Label labelHeight;
        private Label labelWeight;
        private RadioButton radioMetric;
        private RadioButton radioUS;
        private GroupBox UnitSettings;
        private Button calculateButton;
        private GroupBox resultsBox;
        private Label labelResultCat;
        private Label labelResultBMI;
        private Label resultCat;
        private Label resultBMI;
        private TextBox textHeight1;
        private TextBox textWeight;
        private TextBox textHeight2;
        private GroupBox groupSaving;
        private TextBox inputPeriod;
        private Label labelPeriod;
        private TextBox inputMonthlyDeposit;
        private Label labelMonthlyDeposit;
        private GroupBox groupFutureValue;
        private Label resultBalance;
        private Label resultAmount;
        private Label labelFinalBalance;
        private Label labelAmountPaid;
        private Button btnCalcSavings;
    }
}