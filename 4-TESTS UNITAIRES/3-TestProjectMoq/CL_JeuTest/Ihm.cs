using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_JeuTest
{
    public class Ihm
    {
        private readonly IConsole console;
        private readonly ILanceurDeDe lanceurDeDe;

        public Ihm(IConsole _console,ILanceurDeDe _lanceurDeDe)
        {
            this.console = _console;
            this.lanceurDeDe = _lanceurDeDe;
        }
        public void Demarre()
        {
            var jeu = new Jeu();
            console.EcrireLigne($"A l'attaque : points/vie {jeu.Heros.Points}/{jeu.Heros.PointDeVies}");
            while (jeu.Heros.PointDeVies > 0)
            {
                var resultat = jeu.Tour(lanceurDeDe.Lance(), lanceurDeDe.Lance());
                switch (resultat)
                {
                    case Resultat.Gagne:
                        console.Ecrire($"Monstre battu");
                        break;
                    case Resultat.Perdu:
                        console.Ecrire($"Combat perdu");
                        break;
                }
                console.EcrireLigne($": points/vie {jeu.Heros.Points}/{jeu.Heros.PointDeVies}");
            }
        }
    }
}
