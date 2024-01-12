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
    public partial class FormCarre : Form
    {
        Carre carre;

        public Carre Carre { get => carre; set => carre = value; }
        public FormCarre()
        {
            InitializeComponent();
        }

        private void buttonValider_Click_1(object sender, EventArgs e)
        {
            int x = int.Parse(this.textBoxX.Text);
            int y = int.Parse(this.textBoxY.Text);
            int cote = int.Parse(this.textBoxCote.Text);
            
            carre = new Carre(x, y, cote);
            this.Close();
        }
    }
}

