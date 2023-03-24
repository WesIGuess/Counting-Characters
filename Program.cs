using System;
namespace CHaracterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type anything you want. I'll count each letter for some reason: ");
            string message = Console.ReadLine();
        
            message = message.Replace(" ", string.Empty);
            message = message.Replace(".", string.Empty);
            message = message.Replace("?", string.Empty);
            message = message.Replace("!", string.Empty);
            message = message.Replace(",", string.Empty);
            message = message.Replace("'", string.Empty);
            message = message.Replace("/", string.Empty);
            
            
            while (message.Length > 0)
            {
                Console.Write(message[0] + " : ");
                int count = 0;
                for (int charCount = 0; charCount < message.Length; 
                charCount++)
                {
                    if (message[0] == message[charCount])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                message = message.Replace(message[0].ToString(), string.Empty);
            }
            Console.ReadKey();
        }
    }
}