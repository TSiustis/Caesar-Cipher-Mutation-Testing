using System;

namespace MutationTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            CaesarCipher Cipher = new CaesarCipher(3,"Romulus est invicta!");
            string EncryptedText = Cipher.Encrypt(Cipher.Text, 3);
            Console.WriteLine();
            Console.WriteLine(Cipher.Decrypt(EncryptedText));
        }
    }
}
