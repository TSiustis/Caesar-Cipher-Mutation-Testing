using Microsoft.VisualStudio.TestTools.UnitTesting;
using MutationTesting;
namespace CaesarCipherTests
{
    [TestClass]
    public class CaesarTests
    {
        [TestMethod]
        public void Text_Is_String()
        {
            CaesarCipher Cipher = new CaesarCipher("My name is Romulus", 4);
            if(!typeof Cipher.Text is string)
            {

            }
        }
    }
}
