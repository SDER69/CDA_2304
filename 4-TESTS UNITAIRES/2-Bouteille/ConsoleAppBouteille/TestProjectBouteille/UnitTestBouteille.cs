using CL_Bouteille;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProjectBouteille
{
    [TestClass]
    public class UnitTestBouteille
    {   
        // Méthode Ouvrir()
        [TestMethod]
         // Notation Gherkin
        /// Etant donné que j'ai une bouteille de soda fermée 
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
        // Méthode Fermer()
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
        // Méthode Vider (quantité determinée)
        /// Etant donné que j'ai une bouteille de soda ouverte
        /// Etant donné que la quantité de la bouteille de soda est égale à un demi-litre
        /// Lorsque je souhaite vider un quart de litre de son contenu
        /// Alors la bouteille est vidée du quart de litre et la quantité est de 0.25cl
        [TestMethod]
        public void EtantDonne_BouteilleOuverte_Et_BouteilleAvecQuantite_Lorsque_Vider_AvecQuantiteDeterminee_Alors_BouteilleVideeQuantiteDeterminee_Et_QuantiteBouteilleDimininuee()
        //public void TestMethod_Bouteille_Vider_Avec_Quantite_Determinee_EtatOuvert_ReturnTrue()
        {
            Bouteille videQuantite = new Bouteille(true, 1.5f, 0.5f, "soda");
            bool ok = videQuantite.Vider(0.25f);
            Assert.IsTrue(ok);
            Assert.IsTrue(videQuantite.VolumeActuelEnLitres == 0.25f);
        }

        /// Etant donné que j'ai une bouteille de soda fermée
        /// Lorsque je souhaite vider un quart de litre de son contenu
        /// Alors la bouteille reste fermée et la quantitée reste inchangée
        [TestMethod]
        public void EtantDonne_BouteilleFermee_Lorsque_Vider_AvecQuantiteDeterminee_Alors_BouteilleFermee_Et_QuantiteInchangee()
        //public void TestMethod_Bouteille_Vider_Avec_Quantite_Determinee_EtatFerme_ReturnFalse()
        {
            Bouteille videQuantite = new Bouteille(false, 1.5f, 0.5f, "soda");
            bool ok = videQuantite.Vider(0.25f);
            Assert.IsFalse(ok);
            Assert.IsTrue(videQuantite.VolumeActuelEnLitres == 0.5f);
        }
        // Méthode Remplir (quantité determinée)
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
        // Méthode Vider()
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
        // Méthode Remplir()
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