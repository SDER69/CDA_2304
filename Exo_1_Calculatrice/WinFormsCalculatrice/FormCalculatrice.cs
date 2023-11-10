using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalculatrice
{
    public partial class FormCalculatrice : Form
    {
        int sum = 0;
        public FormCalculatrice()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int value = int.Parse((string)btn.Tag);
            string sign = "+";
            this.affichage.Text += value.ToString() + sign;
            this.sum += value;
        }

        private void button_Click_calculer(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string sign = "+";
            this.affichage.Text += " = " + this.sum.ToString() + sign;
        }

        private void button_Click_vider(object sender, EventArgs e)
        {
            this.affichage.Text = " ";
            this.sum = 0;
        }
    }
}
