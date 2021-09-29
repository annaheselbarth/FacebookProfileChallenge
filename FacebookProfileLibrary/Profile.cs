using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookProfileLibrary
{
    public class Profile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public DateTime DateOfBirth { get; set; }

        public int AgeInYears
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYears));
            }
        
            
        }

        public string Workplace { get; set; }

        public string Bio { get; set; }

        public Profile(string firstName, string lastName, DateTime dateOfBirth, string Workplace, string Bio)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Workplace = Workplace;
            Bio = Bio;

        }
    }
}
