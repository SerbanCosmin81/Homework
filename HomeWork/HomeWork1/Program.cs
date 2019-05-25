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

            //5. Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
            /*
            Console.WriteLine("Please enter a string that contains at least 2 uppercase letters: ");
            string myString = Console.ReadLine();
            int k = 0;
            int count = 0;
            char b = myString[k];
            for (int i = 0; i < 4; i++)
            {
                if (char.IsUpper(myString[k]))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                Console.WriteLine(myString.ToUpper());
            }
            else
            {
                Console.WriteLine("The sting entered doesn't contain 2 UPPERs in the first 4 indexes:" + myString);
            }
            */

            //6.Write a method that to remove a newline.
            /*
            string myString = "ANA \nare \nMERE \nGigiDev \nVine si \nCere\n";
            Console.WriteLine(myString);
            myString = myString.Replace("\n","");
            Console.WriteLine(myString);
            */
            //7.Write a method to display formatted text(width = 50) as output.For example: If I have a text that's 134 characters long, the formatted string should have maximum of 50 characters per line. In this case we will have 3 lines of text.

            //FormatedStringToNCaracters();//????????

            //8.Write a method that formats a number with a percentage

            //TransformToPercentage();

            //9. Write a method that reverses a string.

            //ReveseString();

            //10. Write a method that strips a set of characters from a string.

            //StripsSetOfCaracters();

            //11. Write a method that transforms to lowercase first n characters in a string

            //FirstNToLower();

            //12. Write a method to capitalize first and last letters of each word of a given string.

            FirstAndLastCharToUpp();

            //13. Write a method to compute sum of digits of a given string(if any).

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
        public static void TransformToPercentage()
        {
            Console.WriteLine("Please enter a decimal number: ");
            float number = float.Parse(Console.ReadLine()); // or decimal or double
            float numToPerc = number / 100;
            Console.WriteLine("Number to percentage: {0} ", numToPerc.ToString("P"), System.Globalization.CultureInfo.InvariantCulture);
        }
        public static void FormatedStringToNCaracters()
        {
            Console.WriteLine("Please enter a string: ");
            string test = Console.ReadLine();

            Console.WriteLine("Please enter strig limitation: ");
            int nInterval = int.Parse(Console.ReadLine());

            string res = String.Concat(test.Select((c, i) => i > 0 && (i % nInterval) == 0 ? c.ToString() + Environment.NewLine : c.ToString()));
            Console.WriteLine(res);
        }
        public static void ReveseString()
        {
            Console.WriteLine("Enter a string: ");
            string myString = Console.ReadLine();
            
            myString = new String(myString.Reverse().ToArray());

            Console.WriteLine(myString);
        }
        public static void StripsSetOfCaracters()
        {
            Console.WriteLine("Please enter a string: ");
            string myString = Console.ReadLine();
            Console.WriteLine("Enter the elements to strip: ");
            string [] charToRemove =new string[] {Console.ReadLine()};

            foreach (var element in charToRemove)
            {
                myString = myString.Replace(element, "");
            }

            Console.WriteLine(myString);

        }
        public static void FirstNToLower()
        {
            Console.WriteLine("Please enter a string: ");
            string myString = Console.ReadLine().ToUpper();
            Console.WriteLine(myString);
            Console.WriteLine("how many character goes to lower: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i< myString.Length; i++)
            {
                if (i == n)
                {
                    myString = myString.Substring(0, i).ToLower() + myString.Substring(i + 1);
                }                  
            }
            Console.WriteLine(myString);
        }
        public static void FirstAndLastCharToUpp()
        {
            Console.WriteLine("Please enter a sentence: ");
            string myString = Console.ReadLine();
            for (int i = 0; i < myString.Length; i++)
            {
                if (i == ' ')
                {
                                       
                }
                 
            }
            
            Console.WriteLine(myString);
        }

    }



}
