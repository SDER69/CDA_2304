using System.CodeDom;
using System.Runtime.CompilerServices;

namespace WinFormsCheckbox
{
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
            this.groupBoxFond.Visible = false;
            this.groupBoxCaracteres.Visible = false;
            this.groupBoxCasse.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox box = this.textBoxsaisie;

            this.labelCopieTexte.Text = box.Text;
            //this.groupBoxChoix.Enabled = false;

            if (box.Text != "")
            {
                this.groupBoxChoix.Enabled = true;

                if (this.radioButtonMajsucules.Checked)
                {
                    this.labelCopieTexte.Text = this.labelCopieTexte.Text.ToUpper();
                }
                else if (this.radioButtonMinuscules.Checked)
                {
                    this.labelCopieTexte.Text = this.labelCopieTexte.Text.ToLower();
                }
                else
                {
                    this.labelCopieTexte.Text = box.Text;
                }
            }
            else
            {
                this.groupBoxChoix.Enabled = false;
                this.checkBoxFond.Checked = false;
                this.checkBoxCar.Checked = false;
                this.checkBoxCasse.Checked = false;
            }


        }

        private void checkBoxFond_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxFond.Visible = false;
            if (this.checkBoxFond.Checked)
            {
                this.groupBoxFond.Visible = true;
            }
            else
            {
                this.radioButtonRed1.Checked = false;
                this.radioButtonGreen.Checked = false;
                this.radioButtonBlue.Checked = false;
                this.labelCopieTexte.BackColor = SystemColors.Control;
            }


        }

        private void checkBoxCar_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxCaracteres.Visible = false;
            if (this.checkBoxCar.Checked)
            {
                this.groupBoxCaracteres.Visible = true;
            }
            else
            {
                this.radioButtonRed2.Checked = false;
                this.radioButtonWhite.Checked = false;
                this.radioButtonBlack.Checked = false;
                this.labelCopieTexte.ForeColor = SystemColors.ControlText;
            }
        }

        private void checkBoxCasse_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxCasse.Visible = false;
            if (this.checkBoxCasse.Checked)
            {
                this.groupBoxCasse.Visible = true;
            }
            else
            {
                this.radioButtonMinuscules.Checked = false;
                this.radioButtonMajsucules.Checked = false;
                this.labelCopieTexte.Text = this.textBoxsaisie.Text;
            }
        }

        private void radioButtonRed1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonRed1.Checked)
            {
                this.labelCopieTexte.BackColor = Color.Red;
            }
            else
            {
                this.labelCopieTexte.BackColor = Color.Empty;
            }
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonGreen.Checked)
            {
                this.labelCopieTexte.BackColor = Color.Green;
            }
            else
            {
                this.labelCopieTexte.BackColor = Color.Empty;
            }

        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonBlue.Checked)
            {
                this.labelCopieTexte.BackColor = Color.Blue;
            }
            else
            {
                this.labelCopieTexte.BackColor = Color.Empty;
            }
        }

        private void radioButtonRed2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonRed2.Checked)
            {
                this.labelCopieTexte.ForeColor = Color.Red;
            }
            else
            {
                this.labelCopieTexte.ForeColor = Color.Empty;
            }
        }

        private void radioButtonWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonWhite.Checked)
            {
                this.labelCopieTexte.ForeColor = Color.White;
            }
            else
            {
                this.labelCopieTexte.ForeColor = Color.Empty;
            }
        }

        private void radioButtonBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonBlack.Checked)
            {
                this.labelCopieTexte.ForeColor = Color.Black;
            }
            else
            {
                this.labelCopieTexte.ForeColor = Color.Empty;
            }
        }

        private void radioButtonMinuscules_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonMinuscules.Checked)
            {
                this.labelCopieTexte.Text = this.labelCopieTexte.Text.ToLower();
            }
        }

        private void radioButtonMajsucules_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonMajsucules.Checked)
            {
                this.labelCopieTexte.Text = this.labelCopieTexte.Text.ToUpper();
            }
        }


    }
}