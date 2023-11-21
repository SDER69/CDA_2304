using CL_CheckingInputs;
using System.Collections.Generic;

namespace WinFormsListes
{

    public partial class FormLists : Form
    {

        List<string> lst;
        public FormLists()
        {
            InitializeComponent();
            lst = new List<string>();
        }

        private void buttonAddNewElement_Click(object sender, EventArgs e)
        {
            string addElement = this.textBoxAddNewElement.Text;
            this.lst.Add(addElement);
            this.listBoxDisplayList.Items.Add(addElement);
            this.textBoxAddNewElement.Text = "";
            this.textBoxAddNewElement.Focus();

            // Items count
            int numberOfItems = this.lst.Count;
            this.textBoxItemsCount.Text = numberOfItems.ToString();
        }

        private void listBoxDisplayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Selected Index
            string curItem = this.listBoxDisplayList.SelectedIndex.ToString();
            this.textBoxSelectedIndex.Text = curItem;

            // Text
            this.textBoxText.Text = listBoxDisplayList.Text;
        }

        private void buttonSelectIndex_Click(object sender, EventArgs e)
        {
            int selectedIndex = Int32.Parse(this.textBoxIndexElement.Text);
            this.listBoxDisplayList.SelectedIndex = selectedIndex;
            if (CheckingInputs.CheckNegativeNumber(selectedIndex))
            {
                this.errorProviderNegativeNumber.SetError(this.textBoxIndexElement, "Veuillez saisir un nombre positif");
                this.textBoxIndexElement.Text = "";
                this.textBoxSelectedIndex.Text = "";
                this.textBoxIndexElement.Focus();
            }
            else
            {

            }
            
            /*else if (System.Text.RegularExpressions.Regex.IsMatch(this.textBoxIndexElement.Text, "  ^ [0-9]"))
            {
                this.textBoxIndexElement.Text = "";
                this.errorProviderCheckString.SetError(this.textBoxIndexElement, "L'index n'est pas valide");
            }*/

            


        }

        private void buttonEmptyList_Click(object sender, EventArgs e)
        {
            this.listBoxDisplayList.Items.Clear();
        }

        private void textBoxIndexElement_TextChanged(object sender, EventArgs e)
        {
            /*if (System.Text.RegularExpressions.Regex.IsMatch(this.textBoxIndexElement.Text, "  ^ [0-9]"))
            {
                this.textBoxIndexElement.Text = "";
                this.errorProviderCheckString.SetError(this.textBoxIndexElement, "L'index n'est pas valide");
            }*/

        }
    }
}