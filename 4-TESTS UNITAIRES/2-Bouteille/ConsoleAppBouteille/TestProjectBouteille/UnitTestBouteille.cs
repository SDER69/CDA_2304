using CL_Bouteille;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProjectBouteille
{
    [TestClass]
    public class UnitTestBouteille
    {   
        // M�thode Ouvrir()
        [TestMethod]
         // Notation Gherkin
        /// Etant donn� que j'ai une bouteille de soda ferm�e 
        /// Lorsque je souhaite l'ouvrir
        /// Alors la bouteille est ouverte
        public void EtantDonne_BouteilleFermee_Lorsque_Ouvrir_Alors_Bouteille_Etat_Ouverte()
        //public void TestMethod_Bouteille_Ouvrir_EtatFerme_ReturnTrue()
        {
            Bouteille bFerme = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = bFerme.Ouvrir();
            Assert.IsTrue(ok);
            Assert.IsTrue(bFerme.Ouverte);
        }

        [TestMethod]
        public void TestMethod_Bouteille_Ouvrir_EtatOuvert_ReturnFalse()
        {
            Bouteille bFerme = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = bFerme.Ouvrir();// true
            ok = bFerme.Ouvrir();// false
            Assert.IsFalse(ok);
            Assert.IsTrue(bFerme.Ouverte);
        }
        // M�thode Fermer()
        [TestMethod]
        public void TestMethod_Bouteille_Fermer_EtatFerme_ReturnFalse()
        {
            Bouteille bFerme = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = bFerme.Fermer();
            Assert.IsFalse(ok);
            Assert.IsFalse(bFerme.Ouverte);
        }

        [TestMethod]
        public void TestMethod_Bouteille_Fermer_EtatOuvert_ReturnTrue()
        {
            Bouteille bFerme = new Bouteille(true, 1.5f, 0.5f, "soda");
            bool ok = bFerme.Fermer();
            Assert.IsTrue(ok);
            Assert.IsFalse(bFerme.Ouverte);
        }
        // M�thode Vider (quantit� determin�e)
        /// Etant donn� que j'ai une bouteille de soda ouverte
        /// Etant donn� que la quantit� de la bouteille de soda est �gale � un demi-litre
        /// Lorsque je souhaite vider un quart de litre de son contenu
        /// Alors la bouteille est vid�e du quart de litre et la quantit� est de 0.25cl
        [TestMethod]
        public void EtantDonne_BouteilleOuverte_Et_BouteilleAvecQuantite_Lorsque_Vider_AvecQuantiteDeterminee_Alors_BouteilleVideeQuantiteDeterminee_Et_QuantiteBouteilleDimininuee()
        //public void TestMethod_Bouteille_Vider_Avec_Quantite_Determinee_EtatOuvert_ReturnTrue()
        {
            Bouteille videQuantite = new Bouteille(true, 1.5f, 0.5f, "soda");
            bool ok = videQuantite.Vider(0.25f);
            Assert.IsTrue(ok);
            Assert.IsTrue(videQuantite.VolumeActuelEnLitres == 0.25f);
        }

        /// Etant donn� que j'ai une bouteille de soda ferm�e
        /// Lorsque je souhaite vider un quart de litre de son contenu
        /// Alors la bouteille reste ferm�e et la quantit�e reste inchang�e
        [TestMethod]
        public void EtantDonne_BouteilleFermee_Lorsque_Vider_AvecQuantiteDeterminee_Alors_BouteilleFermee_Et_QuantiteInchangee()
        //public void TestMethod_Bouteille_Vider_Avec_Quantite_Determinee_EtatFerme_ReturnFalse()
        {
            Bouteille videQuantite = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = videQuantite.Vider(0.25f);
            Assert.IsFalse(ok);
            Assert.IsTrue(videQuantite.VolumeActuelEnLitres == 0.5f);
        }
        // M�thode Remplir (quantit� determin�e)
        [TestMethod]
        public void TestMethod_Bouteille_Remplir_Avec_Quantite_Determinee_EtatOuvert_ReturnTrue()
        {
            Bouteille rempliQuantite = new Bouteille(true, 1.5f, 0.5f, "soda");
            bool ok = rempliQuantite.Remplir(0.25f);
            Assert.IsTrue(ok);
            Assert.IsTrue(rempliQuantite.VolumeActuelEnLitres == 0.75f);
        }

        [TestMethod]
        public void TestMethod_Bouteille_Remplir_Avec_Quantite_Determinee_EtatFerme_ReturnFalse()
        {
            Bouteille rempliQuantite = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = rempliQuantite.Remplir(0.25f);
            Assert.IsFalse(ok);
            Assert.IsTrue(rempliQuantite.VolumeActuelEnLitres == 0.5f);
        }
        // M�thode Vider()
        [TestMethod]
        public void TestMethod_Bouteille_ViderTout_EtatOuvert_ReturnTrue()
        {
            Bouteille videTout = new Bouteille(true, 1.5f, 0.5f, "soda");
            bool ok = videTout.Vider();
            Assert.IsTrue(ok);
            Assert.IsTrue(videTout.VolumeActuelEnLitres == 0f);
        }

        [TestMethod]
        public void TestMethod_Bouteille_ViderTout_EtatFerme_ReturnFalse()
        {
            Bouteille videTout = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = videTout.Vider();
            Assert.IsFalse(ok);
            Assert.IsTrue(videTout.VolumeActuelEnLitres == 0.5f);
        }
        // M�thode Remplir()
        [TestMethod]
        public void TestMethod_Bouteille_RemplirTout_EtatOuvert_ReturnTrue()
        {
            Bouteille rempliTout = new Bouteille(true, 1.5f, 0.5f, "soda");
            bool ok = rempliTout.Remplir();
            Assert.IsTrue(ok);
            Assert.IsTrue(rempliTout.VolumeActuelEnLitres == 1.5f);
        }

        [TestMethod]
        public void TestMethod_Bouteille_RemplirTout_EtatFerme_ReturnFalse()
        {
            Bouteille rempliTout = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = rempliTout.Remplir();
            Assert.IsFalse(ok);
            Assert.IsTrue(rempliTout.VolumeActuelEnLitres == 0.5f);
        }
    }
}