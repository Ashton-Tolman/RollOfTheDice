namespace RollOfTheDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random diceRoll = new Random();
            int[] rollCount = new int[13];
            string padding = " |";

            Console.WriteLine("         Two six sided dice rolled 1000 times");
            
            //create counting array and collect data
            for (int i = 0; i < 1000; i++)
            {
                int rolledDice = diceRoll.Next(2, 13);
                rollCount[rolledDice]++;

            }

            //Print header 
            for (int i = 2; i < 13; i++)
            { 
                Console.Write($"{i}".PadLeft(3) + padding);
            }
            
            Console.WriteLine();
            
            //Print line separator 
            for (int i = 0; i < 55; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();

            //Print data 
            for (int i = 2; i < 13; i++)
            {
                Console.Write($"{rollCount[i]}".PadLeft(3) + padding);
            }

            //Pause
            Console.Read();
        }
    }
}
