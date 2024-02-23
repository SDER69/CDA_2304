using CL_JeuTest;
using IhmTests.UnitTests;

namespace IhmTests
{
    [TestClass]
    public class IhmTests
    {
        [TestMethod]
        public void Ihm_AvecUnJeuDeDonnees_LeJoueurGagne()
        {
            // Arrange
            var fausseConsole = new FausseConsole();
            var ihm = new Ihm(fausseConsole, new FauxDe());

            // Act
            ihm.Demarre();

            //Assert
            var resultat = fausseConsole.StringBuilder.ToString();

            Assert.AreEqual("A l'attaque : points/vie 0/15Combat perdu: points/vie 0/14Monstre battu: points/vie 1/14Monstre battu: points/vie 2/14Combat perdu: points/vie 2/13Monstre battu: points/vie 3/13Combat perdu: points/vie 3/12Monstre battu: points/vie 4/12Monstre battu: points/vie 5/12Monstre battu: points/vie 6/12Monstre battu: points/vie 7/12Combat perdu: points/vie 7/9Combat perdu: points/vie 7/7Monstre battu: points/vie 8/7Monstre battu: points/vie 9/7Combat perdu: points/vie 9/5Combat perdu: points/vie 9/4Combat perdu: points/vie 9/0", resultat);
         

        }
    }
}