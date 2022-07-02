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
            Functionality functionality = new Functionality();
            string[] secretMessage = functionality.RecordMessage();

            string encryptMsg = functionality.EncryptMessage(secretMessage);
            

            Console.WriteLine(secretMessage);
            Console.WriteLine(encryptMsg);
        }
    }
}
