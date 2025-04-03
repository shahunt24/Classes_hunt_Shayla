namespace Classes_hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates an instance of the Greetings class
            Greetings greetings = new Greetings();
            greetings.Welcome();

            // Asks user for their name, then calls the Hello method
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();

            // Calls the Hello method with the user's name
            greetings.Hello(userName);
        }
    }
}
