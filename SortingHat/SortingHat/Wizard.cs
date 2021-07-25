using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHat
{
    class Wizard
    {
        private string name;
        private string house;

        public Wizard(string aname, string ahouse)
        {
            name = aname;
            house = ahouse;
        }

        public void Welcome()
        {
            if (house == "Gryffindor")
            {
                Console.WriteLine("\n" + name + "!" + " Welcome to " + house + "!");
            }
            else if (house == "Slytherin")
            {
                Console.WriteLine("\n" + name + "!" + " Welcome to " + house + "!");
            }
            else if (house == "Ravenclaw")
            {
                Console.WriteLine("\n" + name + "!" + " Welcome to " + house + "!");
            }
            else if (house == "Hufflepuff")
            {
                Console.WriteLine("\n" + name + "!" + " Welcome to " + house + "!");
            }
        }
    }

    
}
