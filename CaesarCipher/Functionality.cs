using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    internal class Functionality
    {
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e',
                'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
                'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


        char[] encryptedMessage;
        char char_secretMsg;
        int char_inx;
        int new_char_inx;
        char encrypted_char;
        string encryptMsg_str;

        //Method that takes user's input
        public char[] RecordMessage()
        {
            Console.WriteLine("Please type in your secret message");
            string secret_mes = Console.ReadLine().ToLower();
            char[] secretMessage = secret_mes.ToCharArray();
            return secretMessage;

        }



        //Method that encrypts the message
        public string EncryptMessage(char[] message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                char_secretMsg = message[i];
                char_inx = Array.IndexOf(alphabet, char_secretMsg);
                new_char_inx = (char_inx + 3) % alphabet.Length;
                encrypted_char = alphabet[new_char_inx];
                encryptedMessage = new char[message.Length];
                encryptedMessage[i] = encrypted_char;
                encryptMsg_str += encryptedMessage[i];

            }
            

            return encryptMsg_str;
        }

        //Build a method that decrypts the message
    }
}
