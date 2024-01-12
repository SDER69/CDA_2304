using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppFormesGeometriques
{
    public partial class MonOutilDeDessinForm : Form
    {
        public MonOutilDeDessinForm()
        {
            InitializeComponent();
        }

        private void MonOutilDeDessinForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Red), new Rectangle(10, 10, 200,100));
        }
    }
}
