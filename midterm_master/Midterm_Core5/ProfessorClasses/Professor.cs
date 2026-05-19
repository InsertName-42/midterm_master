using System;

namespace ProfessorClasses
{
    public class Professor
    {
        public string Lnumber { get; }

        private string _firstName;
        private string _lastName;
        private string _department;

        //Validation rules
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name cannot be null or empty.", nameof(value));
                _firstName = value.Trim();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name cannot be null or empty.", nameof(value));
                _lastName = value.Trim();
            }
        }

        public string Department
        {
            get => _department;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Department cannot be null or empty.", nameof(value));
                _department = value.Trim();
            }
        }

        //Constructor
        public Professor(string lNumber, string firstName, string lastName, string department)
        {
            if (string.IsNullOrWhiteSpace(lNumber))
            {
                throw new ArgumentException("Lnumber cannot be null or empty.", nameof(lNumber));
            }

            Lnumber = lNumber.Trim();

            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        //Overide ToString
        public override string ToString()
        {
            return $"Lnumber: {Lnumber}, Name: {FirstName} {LastName}, Department: {Department}";
        }
    }
}