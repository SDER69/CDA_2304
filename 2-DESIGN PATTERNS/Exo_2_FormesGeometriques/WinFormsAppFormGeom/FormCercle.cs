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
using WinFormsAppFormGeom;

namespace WinFormsAppFormGeom
{
    public partial class FormCercle : Form
    {
        Cercle cercle;

        public Cercle Cercle { get => cercle; set => cercle = value; }
        public FormCercle()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.textBoxX.Text);
            int y = int.Parse(this.textBoxY.Text);
            int rayon = int.Parse(this.textBoxRayon.Text);
            cercle = new Cercle(x, y, rayon);
            this.Close();
        }
    }
}




