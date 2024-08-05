using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuRecord
{
    /// <summary>
    /// Internal class representing an insured person.
    /// This class encapsulates the details of an insured person, including their first name, last name, age, and phone number.
    /// </summary>
    internal class InsuredPerson
    {
        /// <summary>
        /// The first name of the insured person.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// The last name of the insured person.
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// The age of the insured person.
        /// </summary>
        public byte Age { get; }

        /// <summary>
        /// The phone number of the insured person.
        /// </summary>
        public string PhoneNumber { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsuredPerson"/> class.
        /// </summary>
        /// <param name="firstName">The first name of the insured person.</param>
        /// <param name="lastName">The last name of the insured person.</param>
        /// <param name="age">The age of the insured person.</param>
        /// <param name="phoneNumber">The phone number of the insured person.</param>
        public InsuredPerson(string firstName, string lastName, byte age, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Returns a string representation of the insured person.
        /// </summary>
        /// <returns>A string containing the insured person's first name, last name, age, and phone number.</returns>
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age} years old, phone: {PhoneNumber}";
        }
    }
}