using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class BMICalculator
    {
        // Sets all default values.
        private string name = "Unknown";
        private double height = 0.0;
        private double weight = 0.0;
        private UnitTypes unit;

        public string BmiWeightCategory()
        {
            // Returns BMI Class depending on set BMI.
            double bmi = CalculateBMI();
            if (bmi < 18.5)
                return "Underweight (Below 18.5)";
            else if (bmi <= 24.9)
                return "Normal weight (18.5 - 24.9)";
            else if (bmi <= 29.9)
                return "Overweight Pre-obesity (25-29.9)";
            else if ( bmi <= 34.9)
                return "Overweight Class 1 (30.0-34.9)";
            else if (bmi <= 39.9)
                return "Overweight Class 2 (35.0-39.9)";
            else
                return "Overweight Class 3 (Above 40)";
        }

        public double CalculateBMI()
        {
            // Calculates BMI depending on UnitType.
            double bmiValue = 0.0;
            double factor = 1.0;

            if (unit == UnitTypes.Imperial)
            {
                factor = 703.0;
            }   

            bmiValue = factor * this.weight / (this.height * this.height);
            return bmiValue;

        }

        public double GetHeight()
        {
            // Returns set height.
            return this.height;
        }

        public void SetHeight(double height)
        {
            // Sets height, with simple validation.
            // Thourough validation needs to be done before calling method.
            if (height >= 0.0)
                this.height = height;
        }

        public double GetWeight()
        {
            // Gets Weight;
            return this.weight;
        }
        public void SetWeight(double weight)
        {
            // Sets weight, with simple validation.
            // Thourough validation needs to be done before calling method.
            if (height >= 0.0)
                this.weight = weight;
        }

        public string GetName()
        {
            // Gets name.
            return this.name;
        }

        public void SetName(string name)
        {
            // Sets name, with simple validation.
            // Thourough validation needs to be done before calling method.
            name.Trim();
            if (!string.IsNullOrEmpty(name))
                this.name = name;
        }

        public UnitTypes GetUnit()
        {
            // Gets unit.
            return this.unit;
        }

        public void SetUnit(UnitTypes unit)
        {
            // Sets unit.
            // Thourough validation needs to be done before calling method.
            this.unit = unit;
        }
        

    }

}
