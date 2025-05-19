using System;

namespace ProfessorClasses
{
    public class Professor
    {
        //Fields
        private readonly string _lnumber;
        private string _firstName;
        private string _lastName;
        private string _department;

        //Constructor
        public Professor(string lNumber, string firstName, string lastName, string department)
        {
            if (string.IsNullOrWhiteSpace(lNumber))
            {
                throw new ArgumentException("Lnumber cannot be null or empty.", nameof(lNumber));
            }
            _lnumber = lNumber;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }
        //Getters and Setters:
        //For L Number
        public string Lnumber
        {
            get { return _lnumber; }

        }
        //For FirstName
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _firstName = value;
                }
                else
                {
                    _firstName = "";
                }
            }
        }

        //For LastName
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _lastName = value;
                }
                else
                {
                    _lastName = "";
                }
            }
        }

        //For Department
        public string Department
        {
            get { return _department; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _department = value;
                }
                else
                {
                    _department = "";
                }
            }
        }
        //Method to convert data to a string
        public override string ToString()
        {
            return $"Lnumber: {Lnumber}, First Name: {FirstName}, Last Name: {LastName}, Department: {Department}";
        }

    }
}
