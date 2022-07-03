using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultMsg;
            Functionality functionality = new Functionality();
            Console.WriteLine("Please type \"1\" if you want to encrypt the message " +
                "or \"2\" if you want to decrypt the message?");
            string user_answer = Console.ReadLine().ToLower();
            string[] secretMessage = functionality.RecordMessage();
            if (user_answer == "1")
            {
                resultMsg = functionality.EncryptMessage(secretMessage);
            }
            else 
            {
                resultMsg = functionality.DencryptMessage(secretMessage);
            }
            
            

            //Console.WriteLine(secretMessage);
            Console.WriteLine(resultMsg);
        }
    }
}
