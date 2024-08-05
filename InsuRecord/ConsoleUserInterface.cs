using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuRecord
{
    /// <summary>
    /// Internal class representing the console user interface for the InsuRecord application.
    /// This class provides a simple console-based user interface for managing insured people.
    /// </summary>
    internal class ConsoleUserInterface
    {
        private InsuredPersonManager insuredPersonManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleUserInterface"/> class.
        /// </summary>
        public ConsoleUserInterface()
        {
            insuredPersonManager = new InsuredPersonManager();
        }

        /// <summary>
        /// Menu for controlling the console user interface.
        /// </summary>
        public void StartControlMenu()
        {
            byte option = 0;
            while (option != 4)
            {
                Console.Clear();
                WriteLine("───────────────────────────────────────────────────\n" +
                          "              InsuRecord - console app             \n" +
                          "───────────────────────────────────────────────────\n" +
                          "Choose an option:\n" +
                          "1. Create a new insured person\n" +
                          "2. Display a list of all insured people\n" +
                          "3. Search for an insured person by name and surname\n" +
                          "4. Exit");

                option = GetByteInput("option");
                SelectAction(option);
                
                if (option != 4)
                {
                    WriteLine("\n> > Press any key to continue. < <");
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Selects the appropriate action based on the user's choice selected from the menu.
        /// </summary>
        /// <param name="option">The user's selection.</param>
        private void SelectAction(byte option)
        {
            switch (option)
            {
                case 1:
                    CreateInsuredPerson();
                    break;
                case 2:
                    WriteLine("\n" + insuredPersonManager.DisplayInsuredPeople());
                    break;
                case 3:
                    SearchInsuredPerson();
                    break;
                case 4:
                    WriteLine("\nThank you for using console app of InsuRecord!" +
                              "\n> > Press any key to exit. < <");
                    break;
                default:
                    WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }

        /// <summary>
        /// Prompts the user to enter the details of a new insured person and create one.
        /// </summary>
        private void CreateInsuredPerson()
        {
            string firstName = GetStringInput("first name");
            string lastName = GetStringInput("last name");
            byte age = GetByteInput("age");
            string phoneNumber = GetStringInput("phone number");

            WriteLine("\n" + insuredPersonManager.AddInsuredPerson(firstName, lastName, age, phoneNumber));
        }

        /// <summary>
        /// Prompts the user to enter the first and last name of an insured person to search for and displays result to console.
        /// </summary>
        private void SearchInsuredPerson()
        {
            string firstName = GetStringInput("first name");
            string lastName = GetStringInput("last name");

            WriteLine("\n" + insuredPersonManager.SearchInsuredPerson(firstName, lastName));
        }

        /// <summary>
        /// Writes the specified message to the console.
        /// </summary>
        /// <param name="message">The message to write.</param>
        private void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Prompts the user to enter an byte and read it.
        /// </summary>
        /// <param name="prompt">The prompt to display to the user.</param>
        /// <returns>The validated byte entered by the user.</returns>
        private byte GetByteInput(string prompt)
        {
            while (true)
            {
                WriteLine($"\nEnter {prompt}:");

                if (byte.TryParse(Console.ReadLine().Replace(" ", ""), out byte number))
                {
                    return number;
                }
                else
                {
                    WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        /// <summary>
        /// Prompts the user to enter a string and read it.
        /// </summary>
        /// <param name="prompt">The prompt to display to the user.</param>
        /// <returns>The validated string entered by the user.</returns>
        private string GetStringInput(string prompt)
        {
            string name;
            do
            {
                WriteLine($"\nEnter {prompt}:");
                name = Console.ReadLine().Replace(" ", "").ToLower();

                if (string.IsNullOrEmpty(name))
                {
                    WriteLine($"Input cannot be empty. Please enter a {prompt}.");
                }
            } while (string.IsNullOrEmpty(name));
            return name;
        }
    }
}
