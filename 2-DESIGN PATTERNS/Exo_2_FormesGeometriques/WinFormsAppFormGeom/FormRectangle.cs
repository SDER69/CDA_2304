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
    public partial class FormRectangle : Form
    {
        CL_FormesGeometriques.Rectangle rectangle;

        public CL_FormesGeometriques.Rectangle Rectangle { get => rectangle; private set => rectangle = value; }

        public FormRectangle()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.textBoxX.Text);
            int y = int.Parse(this.textBoxLongueur.Text);
            int width = int.Parse(this.textBoxY.Text);
            int height = int.Parse(this.textBoxLargeur.Text);
            rectangle = new CL_FormesGeometriques.Rectangle(x, y, width, height);
            this.Close();
        }
    }
}
