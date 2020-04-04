using Microsoft.VisualStudio.TestTools.UnitTesting;
using MutationTesting;
namespace UnitTests
{
    [TestClass]
    public class CaesarTests
    {
        public CaesarCipher Cipher = new CaesarCipher(4, "My name is Romulus!");
        [TestMethod]
        public void Encrypts_String()
        {
            string InitialString = "Hello World!";
            string ExpectedString = "Khoor Zruog!";
            int Shift = 3;
            CaesarCipher Cipher2 = new CaesarCipher();
            Assert.AreEqual(Cipher2.Encrypt(InitialString, Shift), ExpectedString);
        }
        [TestMethod]
        public void Text_Is_String()
        {
            Assert.IsInstanceOfType(Cipher.Text, typeof(string));
        }
        [TestMethod]
        public void Shift_Is_InRange() {
            Assert.IsTrue(Cipher.Shift >= 1 && Cipher.Shift <= 26);
        }
             
    }
}
    

