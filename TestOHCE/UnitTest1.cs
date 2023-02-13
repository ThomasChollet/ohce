using OHCE;

namespace TestOHCE
{
    public class UnitTest1
    {
        [Fact]
        public void TestMiroir()
        {
            String vTest = MethodsUtility.PalyndromeLang("test", "fran�ais");
            String assert = "\nBonjour !\ntset\nAu revoir !\n";
            Assert.Equal(assert, vTest);
        }

        [Fact]
        public void TestMiroirAnglais()
        {
            String vTest = MethodsUtility.PalyndromeLang("test", "english");
            String assert = "\nHello !\ntset\nGoodbye !\n";
            Assert.Equal(assert, vTest);
        }

        [Fact]
        public void TestPalyndrome()
        {
            String vTest = MethodsUtility.PalyndromeLang("kayak", "fran�ais");
            String assert = "\nBonjour !\nkayak\nBien jou� !\nAu revoir !\n";

            Assert.Contains(assert, vTest);
        }

        [Fact]
        public void TestPalyndromeAnglais()
        {
            String vTest = MethodsUtility.PalyndromeLang("kayak", "anglais");
            String assert = "\nHello !\nkayak\nWell done !\nGoodbye !\n";

            Assert.Contains(assert, vTest);
        }
    }
}