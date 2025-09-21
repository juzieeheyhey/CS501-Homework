using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    internal class BMI
    {
        private string gender;
        private double height; // in meters
        private double weight; // in kilograms
        private int age;

        // Constructor
        public BMI(string gender, double height, double weight, int age)
        {
            Gender = gender;
            Height = height;
            Weight = weight;
            Age = age;
        }
        // Properties
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be greater than zero.");
                }
                height = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Weight must be greater than zero.");
                }
                weight = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be greater than zero.");
                }
                age = value;
            }
        }
        // Method to calculate BMI
        public double CalculateBMI()
        {
            return Weight / (Height * Height);
        }
    }
}
