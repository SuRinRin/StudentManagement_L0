using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Ultility
{
    public static class Validate
    {
        public static void CheckName(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length > Constants.NameMaxLength) 
            { 
                throw new ArgumentNullException($"Person name must be between 1 and {Constants.NameMaxLength} characters."); 
            }
        }

        public static void CheckDOB(DateTime DOB)
        {
            if (DOB.Year < Constants.YearMin)
            {
                throw new ArgumentNullException($"Minimum Date of birth from year {Constants.YearMin}.");
            }
        }

        public static void CheckAddress(string address)
        {
            if (string.IsNullOrEmpty(address) || address.Length > Constants.AddressMaxLength)
            {
                throw new ArgumentNullException($"Person name must be between 1 and {Constants.AddressMaxLength} characters.");
            }
        }

        public static void CheckHeight(float height)
        {
            if (height < Constants.HeightMin || height > Constants.HegtMax)
            {
                throw new ArgumentNullException($"Minimum height must be between {Constants.HeightMin} and {Constants.HegtMax}.");
            }
        }

        public static void CheckWeight(float weight)
        {
            if (weight < Constants.WeightMin || weight > Constants.WeightMax)
            {
                throw new ArgumentNullException($"Minimum weight must be between {Constants.WeightMin} and {Constants.WeightMax}.");
            }
        }

        public static void CheckStudentId(string id)
        {
            if (string.IsNullOrWhiteSpace(id) || id.Length != Constants.StudentIdLength)
                throw new ArgumentException($"Student ID must be {Constants.StudentIdLength} characters.");
        }

        public static void CheckSchoolName(string schoolName)
        {
            if (string.IsNullOrEmpty(schoolName) || schoolName.Length >= Constants.SchoolNameLengthMax)
                throw new ArgumentException($"Current school must be less than {Constants.SchoolNameLengthMax} characters.");
        }

        public static void CheckYearStarted(int year)
        {
            if (year <= Constants.YearSchoolStarted) throw new ArgumentException($"Year of university started must be after {Constants.YearSchoolStarted}.");
        }

        public static void CheckGpa(double gpa)
        {
            if (gpa < Constants.GpaMin || gpa > Constants.GpaMax)
                throw new ArgumentException($"GPA must be between {Constants.GpaMin} and {Constants.GpaMax}.");
        }
    }
}
