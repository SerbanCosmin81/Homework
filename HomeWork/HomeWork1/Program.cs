using System;
using System.Linq;
using System.Text;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Strings
            //1. Write a method that to remove the nth index character from a nonempty string.

            /*Console.Write("Please enter a string : ");
            string userInput = Console.ReadLine();
            Console.Write("Insert an index to remove : ");
            int userIndex = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder(userInput);
            sb.Remove(userIndex, 1);
            userInput = sb.ToString();
            Console.WriteLine(userInput);*/

            //2. Write a method that to remove the characters which have odd index values of a given string.

            /*Console.Write("Please enter a string: ");
            string userInput = Console.ReadLine();

            string result = "";
            for (int i = 0; i < userInput.Length; i++)
            {
                if (i % 2 == 0)
                {

                    result = result + userInput[i];

                }
                
            }
            Console.WriteLine(result);*/

            //3. Write a method that takes input from the user and displays that input back in upper and lower cases.
            /*
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();
            //var1
            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.ToUpper());
            //var2
            ToUpper();
            ToLower();
            */
            //4. Write a method that reverses a string if it's length is a multiple of 4
            /*
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();

            if (myString.Length % 4 == 0)
            {
                myString = new String(myString.Reverse().ToArray());
                Console.WriteLine(myString);
            }
            else
            {
                Console.WriteLine(  "The string u entered isn't multiple of 4");
            }
            */

            //Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.

            //Write a method that to remove a newline.

            //Write a method to display formatted text(width = 50) as output.For example: If I have a text that's 134 characters long, the formatted string should have maximum of 50 characters per line. In this case we will have 3 lines of text.

            //Write a method that formats a number with a percentage

            //Write a method that reverses a string.

            //Write a method that strips a set of characters from a string.

            //Write a method that transforms to lowercase first n characters in a string

            //Write a method to capitalize first and last letters of each word of a given string.

            //Write a method to compute sum of digits of a given string(if any).

            //Clean the text
            //You will get a text from where you will need to clean the text because it contains a lot of strange characters that don’t belong there(^ <, > &+ @%$)

            //Input:
            //            Hi ^> there << I’m + telling %% you, you & need % to$ do &your $homeworks.@Hate ^ me ^ % now % and % thank % me & later.
            //                     Output:
            //Hi there I’m telling you, you need to do your homeworks. Hate me now and thank me later.  


        }
        //Methods

        public static void ToUpper()
        {
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();
            Console.WriteLine(myString.ToUpper());
        }
        public static void ToLower()
        {
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();
            Console.WriteLine(myString.ToLower());
        }


    }



}
