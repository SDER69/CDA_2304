using CL_FormesGeometriques;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppFormGeom
{
    public partial class MonOutilDeDessinForm : Form
    {
        FormRectangle fr = new FormRectangle();
        FormCarre fca = new FormCarre();
        FormCercle fc = new FormCercle();

        GroupeFormesGeometriques monGroupe;
        public MonOutilDeDessinForm()
        {
            InitializeComponent();
            this.monGroupe = new GroupeFormesGeometriques(5, 5);
            CL_FormesGeometriques.Rectangle r = new CL_FormesGeometriques.Rectangle(10, 10, 10, 20);
            CL_FormesGeometriques.Cercle c = new CL_FormesGeometriques.Cercle(100, 150, 5);
            //monGroupe.AjouterFormeGeometrique(r);
            //monGroupe.AjouterFormeGeometrique(c);
        }

        private void MonOutilDeDessinForm_Paint(object sender, PaintEventArgs e)
        {
            monGroupe.Accept(new VisiteurDeFormeGeometriquePourWinforms(e.Graphics));
        }

        private void buttonAddRectangle_Click(object sender, EventArgs e)
        {
            //FormRectangle fr = new FormRectangle();
            fr.ShowDialog();
            CL_FormesGeometriques.Rectangle tmp = fr.Rectangle;
            monGroupe.AjouterFormeGeometrique(tmp);
            this.Refresh();
        }

        private void buttonAddSquare_Click(object sender, EventArgs e)
        {
            //FormCarre fca = new FormCarre();
            fca.ShowDialog();
            Carre tmp = fca.Carre;
            monGroupe.AjouterFormeGeometrique(tmp);
            this.Refresh();
        }

        private void buttonAddACircle_Click(object sender, EventArgs e)
        {
            //FormCercle c = new FormCercle();
            fc.ShowDialog();
            Cercle tmp = fc.Cercle;
            monGroupe.AjouterFormeGeometrique(tmp);
            this.Refresh();
        }

        private void buttonRemoveARectangle_Click(object sender, EventArgs e)
        {
            //FormRectangle fr = new FormRectangle();
            //fr.ShowDialog();
            CL_FormesGeometriques.Rectangle tmp = fr.Rectangle;
            monGroupe.RetirerFormeGeometrique(tmp);
            this.Refresh();
        }

        private void buttonRemoveASquare_Click(object sender, EventArgs e)
        {
            //FormCarre fca = new FormCarre();
            //fca.ShowDialog();
            Carre tmp = fca.Carre;
            monGroupe.RetirerFormeGeometrique(tmp);
            this.Refresh();
        }

        private void buttonRemoveACircle_Click(object sender, EventArgs e)
        {
            //FormCercle fc = new FormCercle();
            //fc.ShowDialog();
            Cercle tmp = fc.Cercle;
            monGroupe.AjouterFormeGeometrique(tmp);
            this.Refresh();
        }
    }
}
