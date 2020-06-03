using System;

namespace Chapter_3_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Console.WriteLine("Enter a sentence:");
            string myString = Console.ReadLine().ToLower();

            //char[] charactersInString = myString.ToCharArray();

            while (myString.Length > 0)
            {
                Console.Write(myString[0] + " : ");
                int count = 0;
                for (int i = 0; i < myString.Length; i++)
                {
                    if (myString[0] == myString[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                myString = myString.Replace(myString[0].ToString(), string.Empty);
            }
        }
    }
}
