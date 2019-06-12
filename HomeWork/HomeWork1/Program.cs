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

            //NthCharRemove();

            //RemoveOddIndex();

            //RemoveOddIndexSB();

            //StringToUppAndToLow(); 

            //ReverseStringforLenghtMultFour();

            //StringToUppIf2CharToUpp();

            //RemoveNewLine();

            //FormatedStringToNCaracters();

            //TransformToPercentage();

            //ReveseString();

            //StripsSetOfCaracters();

            //FirstNToLower();

            //FirstAndLastCharToUpp();

            //FirstAndLastCharToUpp2();

            //ComputeSumOfDigits();

            //RemoveSpecialCharacters(); 
            //RemoveSpecialCharacters2();

            //IngLy();

            //ObfucateEmail();

            //ReString();

            //ReplaceOccNotTheFirst(); for a word
            //RelaceFirstOccButNotTheFirst(); //for each word in a sentence "ana avea mamaliga si susan si cascaval"

            //SwapingFirstTwoOfEachString(); 

            //AppearanceOfSubstring();

            //LongestWord();

            //LastPartBeforespecifiedChar();

            //StartWith();

            //CountOccOfSubStrInString();

            //SwapCommaWithDot();

            //Palindrome1();



        }
        //Methods

        //1.Write a method that to remove the nth index character from a nonempty string.
        public static void NthCharRemove()
        {
            Console.Write("Please enter a string : ");
            string userInput = Console.ReadLine();
            Console.Write("Insert an index to remove : ");
            int userIndex = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder(userInput);
            sb.Remove(userIndex, 1);
            userInput = sb.ToString();
            Console.WriteLine(userInput);

        }

        //2. Write a method that to remove the characters which have odd index values of a given string.

        public static void RemoveOddIndex()
        {
            Console.Write("Please enter a string: ");
            string userInput = Console.ReadLine();

            string result = "";
            for (int i = 0; i < userInput.Length; i++)
            {
                if (i % 2 == 0)
                {

                    result = result + userInput[i];

                }

            }
            Console.WriteLine(result);
        }
        public static void RemoveOddIndexSB()
        {
            Console.Write("Please enter a string: ");
            string userInput = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= userInput.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append(userInput[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }

        //3. Write a method that takes input from the user and displays that input back in upper and lower cases.

        public static void StringToUppAndToLow()
        {
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();

            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.ToUpper());
        }

        //4. Write a method that reverses a string if it's length is a multiple of 4

        public static void ReverseStringforLenghtMultFour()
        {
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();

            if (myString.Length % 4 == 0)
            {
                myString = new String(myString.Reverse().ToArray());
                Console.WriteLine(myString);
            }
            else
            {
                Console.WriteLine("The string u entered isn't multiple of 4");
            }

        }

        //5. Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.

        public static void StringToUppIf2CharToUpp()
        {
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

        }

        //6.Write a method that to remove a newline.
        public static void RemoveNewLine()
        {
            string myString = "ANA \nare \nMERE \nGigiDev \nVine si \nCere\n";
            Console.WriteLine(myString);
            myString = myString.Replace("\n", "");
            Console.WriteLine(myString);
        }

        //7.Write a method to display formatted text(width = 50) as output.For example: If I have a text that's 134 characters long, the formatted string should have maximum of 50 characters per line. In this case we will have 3 lines of text.

        public static void FormatedStringToNCaracters()
        {
            Console.WriteLine("Please enter a string between 0 and 20 char: ");
            string test = Console.ReadLine();

            Console.WriteLine("string limitation is set to 5 \n ");
            int nInterval = 5;


            if (test.Length <= nInterval)
            {
                Console.WriteLine(test + " IS TO SHORT TO BE SPLITED");
            }
            else if (test.Length > nInterval && test.Length <= nInterval * 2)
            {
                test = test.Substring(0, 5) + Environment.NewLine + test.Substring(5);
                Console.WriteLine(test);

            }
            else if (test.Length > nInterval * 2 && test.Length <= nInterval * 4)
            {
                test = test.Substring(0, 5) + Environment.NewLine + test.Substring(5, 5) + Environment.NewLine + test.Substring(10, 5) + Environment.NewLine + test.Substring(15);
                Console.WriteLine(test);
            }


            //string res = String.Concat(test.Select((c, i) => i > 0 && (i % nInterval) == 0 ? c.ToString() + Environment.NewLine : c.ToString()));
            //Console.WriteLine(res);
        }

        //8.Write a method that formats a number with a percentage

        public static void TransformToPercentage()
        {
            Console.WriteLine("Please enter a decimal number: ");
            float number = float.Parse(Console.ReadLine()); // or decimal or double
            Console.WriteLine("Number to percentage: {0} ", number.ToString("P2"));
        }

        //9. Write a method that reverses a string.

        public static void ReveseString()
        {
            Console.WriteLine("Enter a string: ");
            string myString = Console.ReadLine();

            myString = new String(myString.Reverse().ToArray());

            Console.WriteLine(myString);
        }

        //10. Write a method that strips a set of characters from a string.

        public static void StripsSetOfCaracters()
        {
            Console.WriteLine("Please enter a string: ");
            string myString = Console.ReadLine();
            Console.WriteLine("Enter the elements to strip: ");
            string[] charToRemove = new string[] { Console.ReadLine() };

            foreach (var element in charToRemove)
            {
                myString = myString.Replace(element, "");
            }

            Console.WriteLine(myString);

        }

        //11. Write a method that transforms to lowercase first n characters in a string

        public static void FirstNToLower()
        {
            Console.WriteLine("Please enter a string: ");
            string myString = Console.ReadLine().ToUpper();
            Console.WriteLine(myString);
            Console.WriteLine("how many character goes to lower: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < myString.Length; i++)
            {
                if (i == n)
                {
                    myString = myString.Substring(0, i).ToLower() + myString.Substring(i + 1);
                }
            }
            Console.WriteLine(myString);
        }

        //12. Write a method to capitalize first and last letters of each word of a given string.

        public static void FirstAndLastCharToUpp()
        {
            Console.WriteLine("Please enter a sentence: ");
            string myString = Console.ReadLine();

            string myStringTemp = "";
            if (myString.Length > 0)
            {
                myStringTemp = myString[0].ToString();
                myString = myString.Remove(0, 1).Insert(0, myStringTemp.ToUpper());

                for (int i = 1; i < myString.Length - 1; i++)
                {
                    myStringTemp = myString[i].ToString();
                    if (myString[i + 1].ToString() == " " || myString[i - 1].ToString() == " ") // keeping track of white spaces
                    {
                        myString = myString.Remove(i, 1).Insert(i, myStringTemp.ToUpper());
                    }
                }

                myStringTemp = myString[myString.Length - 1].ToString();
                myString = myString.Remove(myString.Length - 1, 1).Insert(myString.Length - 1, myStringTemp.ToUpper());
            }
            Console.WriteLine(myString);

        }

        public static void FirstAndLastCharToUpp2()
        {
            Console.WriteLine("Please enter a sentence: ");
            string myString = Console.ReadLine();

            string[] words = myString.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var result = "";

            foreach (var word in words)
            {

                result += char.ToUpper(word[0]) + word.Substring(1, word.Length - 2) + char.ToUpper(word[word.Length - 1]) + ' ';

            }
            Console.WriteLine(result);
        }

        //13. Write a method to compute sum of digits of a given string(if any).

        public static void ComputeSumOfDigits()
        {
            Console.WriteLine("Please Enter A sequence of letters and numbers: ");
            string myString = Console.ReadLine();
            int sum = 0;
            char[] numb = myString.ToCharArray();
            for (int i = 0; i < numb.Length; i++)
            {
                if (numb[i] >= '0' && numb[i] <= '9')
                {
                    sum += int.Parse(numb[i].ToString());
                }
            }
            Console.WriteLine(sum);
        }

        //14. Clean the text
        //You will get a text from where you will need to clean the text because it contains a lot of strange characters that don’t belong there(^ <, > &+ @%$)

        //Input:

        //                     Output:
        //Hi there I’m telling you, you need to do your homeworks. Hate me now and thank me later. 

        public static void RemoveSpecialCharacters()
        {
            string str = " Hi ^> there << I’m + telling %% you, you & need % to$ do &your $homeworks.@Hate ^ me ^ % now % and % thank % me & later.";
            Console.WriteLine(str);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i <= str.Length - 1; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= '0' && str[i] <= '9') || str[i] == ' ' || str[i] == '.' || str[i] == ',' || str[i] == '’')
                {
                    sb.Append(str[i]);
                }
            }

            Console.WriteLine(sb.ToString().Trim());

        }

        public static void RemoveSpecialCharacters2()
        {
            string exemplu = " Hi ^> there << I’m + telling %% you, you & need % to$ do &your $homeworks.@Hate ^ me ^ % now % and % thank % me & later.";
            Console.WriteLine(exemplu);
            string[] special = new string[] { "^", "<", ">", "&", "+", "@", "%", "$" };

            foreach (var c in special)
            {
                exemplu = exemplu.Replace(c, "");
            }
            Console.WriteLine(exemplu);

            string[] cleanExemplu = exemplu.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var cleanMultiSpaces = "";

            foreach (var word in cleanExemplu)
            {
                cleanMultiSpaces += word + ' ';
            }

            Console.WriteLine(cleanMultiSpaces);

        }



        //15. Write a method to add 'ing' at the end of a given string (length should be at least 3). If the given string already ends with 'ing' then add 'ly' instead. If the string length of the given string is less than 3, leave it unchanged.
        //Input : 'abc'
        //Output : 'abcing' 
        //Input : 'string'
        //Output: 'stringly'

        public static void IngLy()
        {
            Console.WriteLine("Enter a word: ");
            string myString = Console.ReadLine();
            char[] temp = myString.ToCharArray();

            if (temp[myString.Length - 1] == 'g' && (temp[myString.Length - 2] == 'n') && (temp[myString.Length - 3] == 'i'))
            {
                myString = myString + "ly";
                Console.WriteLine(myString);
            }
            else if (temp.Length >= 3)
            {
                myString = myString + "ing";
                Console.WriteLine(myString);
            }

        }

        //16. Obfucate Email
        //You have some text that contains your email address.And you want to hide that.You decide to censor your email: to replace all characters in it with asterisks ('*') except the domain.Assume your email address will always be in format[username]@[domain]. You need to replace the username with asterisks of equal number of letters and keep the domain unchanged.You will get as input the email address you need to obfuscate
        //Input: awesome @dotnet.com
        //Output: *******@dotnet.com

        public static void ObfucateEmail()
        {
            Console.WriteLine("Enter your email: ");
            string email = Console.ReadLine();
            var user = email.Substring(0, email.IndexOf("@"));
            var domain = email.Substring(email.LastIndexOf("@"));

            foreach (var c in user)
            {
                user = user.Replace(c, '*');
            }

            Console.WriteLine(user + domain);

        }


        //17. Re-string
        //Write a method to get a string made of the first 2 and the last 2 chars from a given a string. If the string length is less than 2,
        //return instead of the empty string.

        public static void ReString()
        {
            Console.WriteLine("Enter a word:");
            string mystring = Console.ReadLine();
            char[] reString = mystring.ToCharArray();

            if (mystring.Length >= 2)
            {
                Console.WriteLine("{0}{1}{2}{3}", reString[0], reString[1], reString[reString.Length - 2], reString[reString.Length - 1]);
            }
            else if (mystring.Length < 2)
            {
                Console.WriteLine("my string is NULL");
            }


        }

        //18. Replace Char
        //Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', except the first char itself.

        public static void ReplaceOccNotTheFirst()
        {
            Console.WriteLine("Enter a word: ");
            string myString = Console.ReadLine();

            char temp = myString[0];

            Console.WriteLine(myString[0].ToString() + myString.Substring(1).Replace(temp, '$'));


        }

        public static void RelaceFirstOccButNotTheFirst()
        {
            Console.WriteLine("Please enter a sentence: ");
            string myString = Console.ReadLine();

            string[] words = myString.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var result = "";

            foreach (var word in words)
            {
                char temp = word[0];
                result += word.Substring(0, 1) + word.Substring(1, word.Length - 1).Replace(temp, '$') + ' ';

            }
            Console.WriteLine(result);
        }

        //19. Write a method to get a single string from two given strings, separated by a space and swap the first two characters of each string.
        //Input: 'abc', 'xyz' 
        //Output: 'xyc abz'

        public static void SwapingFirstTwoOfEachString()
        {
            Console.WriteLine("Enter a word: ");
            string myString1 = Console.ReadLine();

            Console.WriteLine("Enter a word: ");
            string myString2 = Console.ReadLine();

            string mySwaped = "";

            for (int i = 0; i < myString1.Length; i++)
            {
                mySwaped = myString2.Substring(0, 2) + myString1.Substring(2) + "---" + myString1.Substring(0, 2) + myString2.Substring(2);
            }

            Console.WriteLine(mySwaped);
        }

        //20. Write a method to find the first appearance of the substring 'not' and 'poor' from a given string, if 'not' follows the 'poor', replace the whole 'not'...'poor' substring with 'good'. Return the resulting string.
        //Input: 'The lyrics is not that poor!'
        //Output : 'The lyrics is poor!'
        //Input  : 'The lyrics is good!'
        //Output : 'The lyrics is poor!'

        public static void AppearanceOfSubstring()
        {
            Console.WriteLine("Write your sentence: ");
            string input = Console.ReadLine();


            if (input.Contains("not") && input.IndexOf("not") < input.IndexOf("poor"))
            {
                Console.WriteLine(input.Substring(0, input.IndexOf("not")) + "good" + input.Substring(input.IndexOf("poor") + 4));
            }

            if (input.Contains("good"))
            {
                var text2 = input.Replace("good", "poor");
                Console.WriteLine(text2);

            }


        }

        //21. Write a method that takes a list of words and returns the length of the longest one.
        public static void LongestWord()
        {
            Console.WriteLine("Enter a word: ");
            string myString = Console.ReadLine();
            string[] words = myString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int maxLength = words[0].Length;

            for (int i = 1; i < words.Length; i++)
            {
                if (maxLength < words[i].Length)

                    maxLength = words[i].Length;

            }


            Console.WriteLine(maxLength);
        }

        //22. Write a method to get the last part of a string before a specified character.
        //Input :  https://www.siit.com/net-exercises
        //Output:  https://www.siit.com/net
        public static void LastPartBeforespecifiedChar()
        {
            string myString = "https://www.siit.com/net-exercises";
            Console.WriteLine(myString);
            Console.WriteLine("Enter char or sign: ");
            string caracter = Console.ReadLine();

            Console.WriteLine(myString.Substring(0, myString.IndexOf(caracter)));


        }

        //23. Write a method to check whether a string starts with specified characters
        //input: awesome string
        //               a
        //output : Yes, starts with a
        public static void StartWith()
        {
            string myString = "awesome string";
            Console.WriteLine(myString);
            Console.WriteLine("Enter char or sign: ");
            string caracter = Console.ReadLine();

            if (myString.IndexOf(caracter) == 0)
                Console.WriteLine($"Yes, YOUR string starts with {caracter}");
            else
                Console.WriteLine($"No, YOUR string doesn't start with {caracter}");
        }


        //24. Write a method to count occurrences of a substring in a string
        public static void CountOccOfSubStrInString()
        {
            Console.WriteLine("Please enter your string: ");
            string myString = Console.ReadLine();
            Console.WriteLine("Please enter substring to check: ");
            string mySubString = Console.ReadLine();
            int index = 0;
            int repeat = 0;
            while ((repeat = myString.IndexOf(mySubString, repeat)) != -1)
            {

                repeat += mySubString.Length;
                index++;

            }
            if (index == 0)
            {
                Console.WriteLine($"We didn't find your substring in the given string !!!");
            }
            else
            {
                Console.WriteLine($"We find your substring for {index} times!!!");
            }


        }

        //25. Write a method to swap comma and dot in a string.

        public static void SwapCommaWithDot()
        {
            Console.WriteLine("Enter a sentence that contains COMMA and DOTT: ");
            string myString = Console.ReadLine();
            char comma = ',';
            char dott = '.';

            char[] mySwapedString = myString.ToCharArray();

            char temp = mySwapedString[myString.IndexOf(comma)];
            mySwapedString[myString.IndexOf(comma)] = mySwapedString[myString.IndexOf(dott)];
            mySwapedString[myString.IndexOf(dott)] = temp;

            Console.WriteLine(mySwapedString);

        }

        //Palindrome
        //Check if a string is palindrome(same value read from left to right and right to left) Ex: alabala -> True

        public static void Palindrome1()
        {
            Console.WriteLine("Enter a word: ");
            string myString = Console.ReadLine();
            string myStringReverse = new string(myString.ToCharArray().Reverse().ToArray());
            if (myString.Equals(myStringReverse))
            {
                Console.WriteLine("String is Palindrome \n You entered first: {0} and it came up like this: \n {1}", myString, myStringReverse);
            }
            else
            {
                Console.WriteLine("String is NOT PALINDROME \n You entered first: {0} and it came up like this: \n {1}", myString, myStringReverse);
            }
        }









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
