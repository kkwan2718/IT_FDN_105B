//Assignment #6
//Copy this block into your Visual Studio.
// Review and Redo this code line by line at home.  
// Place comments on each line and describe what the code is doing

using System;

namespace ConsoleApplication1
{
    public struct Pet // Pet is a structure to store information
    {
        // Public variables mean they can be modified in the class
        public string Name; // A string variable to store the name of the pet
        public string TypeOfPet; // A string variable to store the type of pet

    }

    class Program
    {
        static void Main()
        {
            // var is a variable without a specific type (ie. it can be of type string, int, etc.)
            var numberOfPets = 0; // Initializes a variable to count the number of pets
            var pets = new Pet[10]; // Initializes an array of type Pet of size 10

            while (true) // The program will continue running until the user closes it
            {
                Console.Write("A)dd D)elete L)ist pets: "); // Displays the user's options on the console
                var choice = Console.ReadLine(); // Reads the user input and stores the data into a variable named "choice"

                // Switch will run the specific case that the user entered above
                switch (choice)
                {
                    // If the user enters "A" or "a", the below code will run
                    case "A":
                    case "a":
                        {
                            Console.Write("Name : "); // Displays text on console asking user to input pet's name
                            var name = Console.ReadLine(); // Reads the user input and stores the data into a variable named "name"

                            Console.Write("Type of pet : "); // Displays text on console asking user to input type of pet
                            var typeOfPet = Console.ReadLine(); // Reads the user input and stores the data into a variable named "typeOfPet"

                            // Always add the pet at the end of the array
                            pets[numberOfPets].Name = name; // Stores the name of the pet in the array at the index of numberOfPets
                            pets[numberOfPets].TypeOfPet = typeOfPet; // Stores the type of pet in the array at the index of numberOfPets

                            numberOfPets++; // Increments numberOfPets by 1 to count for more pets
                            break; // Ends this case
                        }

                    // If the user enters "D" or "d", the below code will run
                    case "D":
                    case "d":
                        {
                            if (numberOfPets == 0) // If no pets are stored (ie. numberOfPets is 0)
                            {
                                Console.WriteLine("No pets"); // The console will display "No pets"
                                break; // Ends this case
                            }

                            // This for loop will display each of the pets listed in the database.  The index value in [] determines which pet in the 
                            // array to display.
                            for (var index = 0; index < numberOfPets; index++) 
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }

                            Console.Write("Which pet to remove (1-{0})", numberOfPets); // Asks the user to input which pet to delete

                            var petNumberToDelete = Console.ReadLine(); // Stores the user input to a variable named "petNumberToDelete"
                            var indexToDelete = int.Parse(petNumberToDelete); // Reads the user input and uses parse to convert the string to an int, 
                                                                                // then stores the int into a variable named "indexToDelete"

                            // Because there is one less pet, we need to adjust the numbering on the list.  The following for loop will start from the 
                            // pet number to delete, then copy the next pet's data into its spot until it reaches the last pet
                            // Squish the array from index to the end
                            for (var index = indexToDelete - 1; index < numberOfPets; index++)
                            {
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];
                            }

                            // We have one less pet
                            numberOfPets--; // Decrements "numberOfPets" by 1 since we deleted a pet

                            break; // Ends this case
                        }

                    // If the user enters "L" or "l", the below code will run
                    case "L":
                    case "l":
                        {
                            if (numberOfPets == 0) // If no pets are stored, "No pets" will be displayed on console
                            {
                                Console.WriteLine("No pets");
                            }

                            // This for loop will display all of the pets stored line by line.  The index value in [] determines which 
                            // pet's data to display.  The array uses zero-based indexing, so the first listed value needs to be "index + 1"
                            for (int index = 0; index < numberOfPets; index++)
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }

                            break; // Ends this case
                        }

                    // If the user does not enter any of the above cases, the following case will run.
                    default:
                        {
                            Console.WriteLine("Invalid option [{0}]", choice); // Displays on console that the user input was not valid.  The console displays
                                                                               // what the user inputted.
                            break; // Ends this case
                        }
                }
            }
        }
    }
}