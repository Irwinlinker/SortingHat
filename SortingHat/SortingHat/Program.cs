//Robert Marsh
//Program takes user input and generates a "Harry Potter" world and sorts you into a house

using System;

namespace SortingHat
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";//string to compare against for valid entries


            Console.WriteLine("Welcome to the Wizarding World sorting hat program");
            Console.WriteLine("You'll enter your name and favorite animal and you'll get your Wizarding name and House");
            Console.WriteLine("\n");

            Console.Write("Are you male or female? ");
            string gender = Console.ReadLine();
            //while loop to catch invalid entry
            while(!GenderCheck(gender))
            {
                Console.WriteLine("Thats not a valid gender");
                Console.Write("Are you male or female? ");
                gender = Console.ReadLine();
            }

            Console.Write("\nWhat is your favorite animal? ");
            string animal = Console.ReadLine();
            //while loop to catch invalid entry
            while (!AnimalCheck(animal, alphabet))
            {

                Console.Write("Whats your favorite animal? ");
                animal = Console.ReadLine();

            }

            Console.Write("\nWhat is your first name? ");
            string firstName = Console.ReadLine();

            //while loop to catch invalid entry
            while (!NameCheck(firstName, alphabet))
            {
                
                Console.Write("Whats your first name? ");
                firstName = Console.ReadLine();

            }

            Console.Write("\nWhat is your last name? ");
            string lastName = Console.ReadLine();
            //while loop to catch invalid entry
            while (!NameCheck(lastName, alphabet))
            {

                Console.Write("Whats your last name? ");
                lastName = Console.ReadLine();

            }

            //create Wizard and welcome them with object method
            Wizard wizard1 = new Wizard(NameGen(firstName, lastName, alphabet, gender), HouseGen(HouseCheck(animal, alphabet)));
            wizard1.Welcome();
        }

            static bool NameCheck(string name, string alphabet)
            {
                

                foreach (char c in name)
                {
                    if (!alphabet.Contains(c))
                    {
                        Console.WriteLine("Cmon Elon, thats not a real name");
                        return false;
                    }
                }
                return true;
            }

            static bool AnimalCheck(string animal, string alphabet)
            {


                foreach (char c in animal)
                {
                    if (!alphabet.Contains(c))
                    {
                        Console.WriteLine("Cmon, thats not an animal");
                        return false;
                    }
                }
                return true;
            }

            static bool GenderCheck(string gender)
                {
                    if (gender.ToLower() != "male" && gender.ToLower() != "female")
                    {
                        return false;
                    }
                    return true;
                }

            static string NameGen(string firstName, string lastName, string alphabet, string gender)
            {
                string newFirstName = "";
                string newLastName = "";

                string[] maleFirstNames = {"Draco", "Albus", "Cedric",
                  "Remus", "Arthur", "George",
                  "Fred", "Oliver", "Neville",
                  "Kingsley", "Percival", "Harry",
                  "Rubeus", "James", "Seamus",
                  "Peter", "Severus", "Draco",
                  "Alastor", "Ron", "Percy",
                  "Sirius", "Tom", "Gellert",
                  "Gilderoy", "Dudley"};

                string[] femaleFirstNames = {"Alecto", "Bellatrix", "Cho",
                  "Dolores", "Fleur", "Ginny",
                  "Griselda", "Helena", "Irma",
                  "Lily", "Mafalda", "Millicent",
                  "Molly", "Nymphadora","Myrtle",
                  "Orla", "Pandora", "Parvati",
                  "Rowena", "Wilhelmina", "Hermoine",
                  "Helga", "Doris", "Celestina",
                  "Bathilda", "Augusta"};

                string[] lastNames = {"Carrow", "Longbottom", "Tonks",
                  "Figg", "Dumbledore", "Greengrass",
                  "Sinistra", "Bagshot", "Lestrange",
                  "Trewlawny", "Burbage", "Umbridge",
                  "Delacour", "Weasley", "Ravenclaw",
                  "Granger", "Potter", "Lovegood",
                  "Dursley", "Bagnold", "McGonagall",
                  "Malfoy", "Patil", "Hooch",
                  "Hufflepuff", "Gudgeon"};

                for (int i = 0; i < alphabet.Length; i++)
                {

                    if (gender.ToLower() == "male" && firstName[0] == alphabet[i])
                    {

                        newFirstName += maleFirstNames[i];
                    }

                    if (gender.ToLower() == "female" && firstName[0] == alphabet[i])
                    {

                        newFirstName += femaleFirstNames[i];
                    }

                    if (lastName[0] == alphabet[i])
                    {

                        newLastName += lastNames[i];
                    }

                }

                return newFirstName + " " + newLastName;

            }

            static int HouseCheck(string animal, string alphabet)
            {
                int num = 0;
                
                for(int i = 0; i < alphabet.Length; i++)
                {
                    if(animal[0] == alphabet[i])
                    {
                        num = i;
                    }
                }
                
                return num;
            }

            static string HouseGen(int HouseCheck)
            {
                string house = "";

                switch (HouseCheck)
                {
                    case 0:
                        house = "Gryffindor";
                        break;
                    case 1:
                        house = "Gryffindor";
                        break;
                    case 2:
                        house = "Gryffindor";
                        break;
                    case 3:
                        house = "Gryffindor";
                        break;
                    case 4:
                        house = "Gryffindor";
                        break;
                    case 5:
                        house = "Gryffindor";
                        break;
                    case 6:
                        house = "Gryffindor";
                        break;
                    case 7:
                        house = "Slytherin";
                        break;
                    case 8:
                        house = "Slytherin";
                        break;
                    case 9:
                        house = "Slytherin";
                        break;
                    case 10:
                        house = "Slytherin";
                        break;
                    case 11:
                        house = "Slytherin";
                        break;
                    case 12:
                        house = "Slytherin";
                        break;
                    case 13:
                        house = "Ravenclaw";
                        break;
                    case 14:
                        house = "Ravenclaw";
                        break;
                    case 15:
                        house = "Ravenclaw";
                        break;
                    case 16:
                        house = "Ravenclaw";
                        break;
                    case 17:
                        house = "Ravenclaw";
                        break;
                    case 18:
                        house = "Ravenclaw";
                        break;
                    case 19:
                        house = "Hufflepuff";
                        break;
                    case 20:
                        house = "Hufflepuff";
                        break;
                    case 21:
                        house = "Hufflepuff";
                        break;
                    case 22:
                        house = "Hufflepuff";
                        break;
                    case 23:
                        house = "Hufflepuff";
                        break;
                    case 24:
                        house = "Hufflepuff";
                        break;
                    case 25:
                        house = "Hufflepuff";
                        break;

                }
                return house;
            }

            
    }

}
