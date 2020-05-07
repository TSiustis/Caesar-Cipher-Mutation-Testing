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
        public void Decrypts_String()
        {
            string InitialString = "Khoor Zruog!";
            string ExpectedString = "Hello World!";
            int InitialShift = 3;
            int Shift = 26 - InitialShift;
            CaesarCipher Cipher2 = new CaesarCipher();
            Assert.AreEqual(Cipher2.Encrypt(InitialString, Shift), ExpectedString);
        }
        [TestMethod]
        public void Text_Is_Valid()
        {
            string InitialString = "This is a passable string";
            if(InitialString.Contains('>') || InitialString.Contains('<') || InitialString.Contains('@') || InitialString.Contains('#')
                || InitialString.Contains('$') || InitialString.Contains('%') || InitialString.Contains('^') || InitialString.Contains('&')
                || InitialString.Contains('*') || InitialString.Contains('+') || InitialString.Contains('/') || InitialString.Contains('(') || InitialString.Contains(')'))
            {
                Assert.Fail("Invalid String - contains invalid characters!");
            }
            if (InitialString.Length > 50)
                Assert.Fail("Invalid String - Length should be lower than or equal to 50!");
           
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
        [TestMethod]
        public void Shift_Upper_Limit()
        {
            int ExpectedShift = 13;
            if (ExpectedShift > 26)
                Assert.Fail("--Shift invalid--");
        }
             
    }
}
    

