using System;
using System.Linq;
using System.Security.Principal;

namespace ExamRetake
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();
            while (input!="Decode")
            {
                var tokenss = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                var command = tokenss[0];

                if (command=="Move")
                {
                    var lettersToMove = int.Parse(tokenss[1]);
                    var newStr = message.Substring(0, lettersToMove);
                    string temp = message.Remove(0, lettersToMove);
                    message = temp;
                    var final = message + newStr;
                    message = final;
                   
                }

                else if (command=="Insert")
                {
                    var index = int.Parse(tokenss[1]);
                    var insert = tokenss[2];

                   message = message.Insert(index, insert);
                    
                }

                else if (command=="ChangeAll")
                {
                    var substringToChange = tokenss[1];
                    var replacement = tokenss[2];
                    message = message.Replace(substringToChange, replacement);
                    
                }

                input = Console.ReadLine();
            }

              Console.WriteLine($"The decrypted message is: {message}");

        }
    }
}
