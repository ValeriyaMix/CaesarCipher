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
        char spec_char;
        int inx_spec_char;

        //Method that takes user's input
        public string[] RecordMessage()
        {
            Console.WriteLine("Please type in your secret message");
            string secret_mes = Console.ReadLine().ToLower();
            string[] secret_mes_word = secret_mes.Split(' ');
            return secret_mes_word;
            

        }



        //Method that encrypts the message
        public string EncryptMessage(string[] message)
        {
            foreach (string word in message)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (Char.IsLetter(word[i]) == false  || word[i] == ' ')
                    {
                        spec_char = word[i];
                        inx_spec_char = i;
                        encryptMsg_str += spec_char;
                    }
                    else
                    {
                        char_secretMsg = word[i];
                        char_inx = Array.IndexOf(alphabet, char_secretMsg);
                        new_char_inx = (char_inx + 3) % alphabet.Length;
                        encrypted_char = alphabet[new_char_inx];
                        encryptedMessage = new char[word.Length];
                        encryptedMessage[i] = encrypted_char;
                        encryptMsg_str += encryptedMessage[i];
                    }
                    
                    
                }
                encryptMsg_str = encryptMsg_str + ' ';
            }
            
            

            return encryptMsg_str;
        }

        //Build a method that decrypts the message
    }
}
