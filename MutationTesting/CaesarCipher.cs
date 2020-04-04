using System;
using System.Collections.Generic;
using System.Text;

namespace MutationTesting
{
    public class CaesarCipher
    {
        public int Shift { get; set; }
        public string Text  { get;set; }

        public CaesarCipher()
        {

        }
        public CaesarCipher(int shift,string text)
        {
            Shift = shift;
            Text = text;
        }
        public string  Encrypt(string Text,int? shift)
        {
            StringBuilder result = new StringBuilder();
            for(int i = 0; i < Text.Length; i++)
            {
                if (char.IsLetter(Text[i]))
                {
                    char d = char.IsUpper(Text[i]) ? 'A' : 'a';
                    result.Append((char)((((Text[i] + shift) - d) % 26) + d));
                }
                else
                {
                    result.Append(Text[i]);
                }
            }
            return result.ToString();
        }
        public string Decrypt(string Text)
        {
            int DecryptShift = 26 - Shift;
            return Encrypt(Text,DecryptShift);
        }
    }

}
