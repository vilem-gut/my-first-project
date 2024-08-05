using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuRecord
{
    /// <summary>
    /// Internal class representing the manager for insured people.
    /// This class maintains a list of insured people and provides methods for managing them.
    /// </summary>
    internal class InsuredPersonManager
    {
        /// <summary>
        /// The list of insured people managed by this manager.
        /// </summary>
        private List<InsuredPerson> insuredPeople;

        /// <summary>
        /// Initializes a new instance of the <see cref="InsuredPersonManager"/> class.
        /// </summary>
        public InsuredPersonManager()
        {
            insuredPeople = new List<InsuredPerson>();
        }

        /// <summary>
        /// Creates a new insured person with the given details and adds it to the list of insured people.
        /// </summary>
        /// <param name="firstName">The first name of the insured person.</param>
        /// <param name="lastName">The last name of the insured person.</param>
        /// <param name="age">The age of the insured person.</param>
        /// <param name="phoneNumber">The phone number of the insured person.</param>
        /// <returns>A string indicating the result of the operation.</returns>
        public string AddInsuredPerson(string firstName, string lastName, byte age, string phoneNumber)
        {
            InsuredPerson insuredPerson = new InsuredPerson(firstName, lastName, age, phoneNumber);
            insuredPeople.Add(insuredPerson);

            return $"Insured person {insuredPerson} has been added successfully.";
        }

        /// <summary>
        /// Displays the list of all insured people.
        /// </summary>
        /// <returns>A string containing the list of all insured people.</returns>
        public string DisplayInsuredPeople()
        {
            string result = "List of all insured people:";
            foreach (InsuredPerson insuredPerson in insuredPeople)
            {
                result += "\n" + insuredPerson;
            }
            return result;
        }

        /// <summary>
        /// Searches for an insured person with the given first and last names.
        /// </summary>
        /// <param name="firstName">The first name of the insured person to search for.</param>
        /// <param name="lastName">The last name of the insured person to search for.</param>
        /// <returns>A string indicating the result of the search.</returns>
        public string SearchInsuredPerson(string firstName, string lastName)
        {
            string? result = null;
            foreach (InsuredPerson insuredPerson in insuredPeople)
            {
                if (insuredPerson.FirstName == firstName && insuredPerson.LastName == lastName)
                {
                    result += "\n" + insuredPerson;
                }
            }

            if (result == null)
            {
                return $"Insured person named {firstName} {lastName} was not found.";
            }

            return $"Insured person found: {result}";
        }
    }
}
