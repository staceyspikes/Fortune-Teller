using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        { //Ask the user for the user’s first name
          //Ask the user for the user’s last name
          //Ask the user for the user’s age
          //Ask the user for the user’s birth month(as an 'int')
          //Ask the user for the user’s favorite ROYGBIV color
          //If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors
          //Ask the user for the number of siblings the user has

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            

            Console.WriteLine("How old are you?");
            int age =int.Parse(Console.ReadLine());
           

            Console.WriteLine("What is your birth month? Please type integer");
            int birthMonth = int.Parse(Console.ReadLine());
          

             Console.WriteLine("What is your favorite color? Refer to ROYGBIV only. If confused type help.");
             string favoriteColor = Console.ReadLine().ToLower();
             if (favoriteColor == "help")
            {
                Console.WriteLine("Red Orange Yellow Green Blue Indigo Violet. Please select one.");
                Console.ReadLine();
            }
             
             
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());

            // age-odd-retire
            // siblings 0,1,2,3,more than 3, less than 0
            // break up so there are no console.writelines
            //set a variable to each input
            //

            int retireTime; 
            if (age % 2 ==0)
            {
               retireTime = 10  ;
            }
            else
            {
                retireTime = 88 ;
            }
            string vacaySpot ="";
            if (siblings == 0)
            {
               vacaySpot = " in Spain";
            }
            else if (siblings == 1)
            {
                vacaySpot = "in Miami";
            }
            else if (siblings == 2)
            {
                vacaySpot = "in Hawaii";
            }
            else if (siblings == 3)
            {
                vacaySpot = "in San Diego";
            }
            else if (siblings > 3)
            {
                vacaySpot = "in Costa Rica";
            }
            else if (siblings < 0)
            {
                vacaySpot = " next to the dirtiest dumpster in New York City";
            }
            string modeTransport = "";
            if (favoriteColor == "red")
            {
                modeTransport = " a school bus";
            }
            else if (favoriteColor == "orange")
            {
                modeTransport = " a 30 year old junk car";
            }
            else if (favoriteColor == "yellow")
            {
                modeTransport = " the newest sports car";
            }
           else if (favoriteColor =="green")
            {
                modeTransport = " a bicycle";
            }
           else if (favoriteColor == "blue")
            {
                modeTransport = " an unsinkable boat";
            }
            else if (favoriteColor == "indigo")
            {
                modeTransport = " a motorcycle";
            }
            else if (favoriteColor == "violet")
            {
                modeTransport = " your own private jet! You lucky duck";
            }

            string moneyInBank ="";
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                moneyInBank = "$1000";
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                moneyInBank = "$21 billion";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                moneyInBank = "$3 dollars";
            }
            else if  (birthMonth < 1 && birthMonth > 12)
            {
                moneyInBank = "$0 dollars";
            }

            
            Console.WriteLine(" If you are not scared, press enter!:");
            Console.ReadLine();

            Console.WriteLine(firstName + " " + lastName + " " +  "you will retire in" + " " +retireTime + " " + "years, with" +" " +moneyInBank + " " + "in the bank." + " \n " +"On the bright side you will have a vacation home" + " " +vacaySpot + " " + " and be driving" + " " +modeTransport + "\n " + "Hope you enjoyed your fortune!");
            
            












        }
    }
}
