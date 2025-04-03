using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_hunt_Shayla
{
    internal class Greetings
    {
        /// <summary>
        /// This method prints a welcome message to the console
        /// </summary>
        public void Welcome()
        {
            Console.WriteLine("Hi there! Welcome!");
        }

        /// <summary>
        /// This method takes a string parameter 'name' and prints a personalized greeting
        /// </summary>
        /// <param name="name">Adds nsme that the user inputs/param>
        public void Hello(string name)
        {
            Console.WriteLine($"Happy you're here {name}!");
        }

    }
}
