using CL_JeuTest;

namespace TestProjectMoq
{
    [TestClass]
    public class JeuTests
    {
        [TestMethod]
        [Description("Etant donné un tour de jeu, lorsque j'ai un lancer supérieur au second," +
                    " alors le résultat est gagné avec un point sans perdre de points de vie")]
        public void Tour_AvecUnDeSuperieurAuSecond_RetourneGagneAvecUnPointEtSansPerdreDePointsDeVie()
        {
            // Arrange
            Jeu jeu = new Jeu();

            // Act
            var resultat = jeu.Tour(6, 1);

            // Assert
            /*if(resultat != Resultat.Gagne)
            {
                Assert.Fail();
            }
            if (jeu.Heros.Points != 1)
            {
                Assert.Fail();
            }
            if(jeu.Heros.PointDeVies != 15)
            {
                Assert.Fail();
            }*/
            Assert.AreEqual(Resultat.Gagne, resultat,"Il faut absolument que le résultat soit gagné");
            Assert.AreEqual(1, jeu.Heros.Points);
            Assert.AreEqual(15,jeu.Heros.PointDeVies);
        }
        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            Jeu jeu = new Jeu();

            // Act
            var resultat = jeu.Tour(5, 5);

            // Assert
            if(resultat != Resultat.Gagne) 
            {
                Assert.Fail();
            }
            if(jeu.Heros.Points != 1)
            {
                Assert.Fail();
            }
            if(jeu.Heros.PointDeVies != 15)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            Jeu jeu = new Jeu();

            // Act
            var resultat = jeu.Tour(2, 4);

            // Assert
            if (resultat != Resultat.Perdu)
                Assert.Fail();
            if (jeu.Heros.Points != 0)
                Assert.Fail();
            if (jeu.Heros.PointDeVies != 13)
                Assert.Fail();
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(4 > 5 || !false && !(!true) != false);
        }
        
    }
}