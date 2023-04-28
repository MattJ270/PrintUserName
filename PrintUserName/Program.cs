using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintUserName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sample program to demostrate how to display user name
            //Part of tutorial series

            //Possible upgrades to this program is to handle user input. User can currently enter numbers
            //Could check if input is numbers, length of the input

            string userName; //declaring the string variable userName so we can assign it later

            //Writing to the console to tell the user what to enter
            Console.WriteLine("Hello, what is your name?: ");

            //Whatever the user types will be assigned to the variable userName
            userName = Console.ReadLine();

            //We now have the input from the user so we need to display it back

            Console.WriteLine("Nice to meet you, " +  userName);
            //The output displays the string we hard coded 'Nice to meet you, ' AND our variable right after

            //This is so the console window doesnt close
            Console.ReadLine();
        }
    }
}
