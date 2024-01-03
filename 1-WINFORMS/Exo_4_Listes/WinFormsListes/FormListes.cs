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
            if (this.listBoxDisplayList.FindString(this.textBoxAddNewElement.Text) != -1)
            {
                this.errorProviderDuplicateFirstName.SetError(this.textBoxAddNewElement, "Ce prénom est déjà présent dans la liste veuillez saisir un autre prénom");
            }
            else if (!CheckingInputs.CheckFirstName(this.textBoxAddNewElement.Text))
            {
                this.errorProviderCheckFirstName.SetError(this.textBoxAddNewElement, "Veuillez saisir un prénom valide avec la première lettre en majsucule");

            }
            else
            {
                this.errorProviderDuplicateFirstName.SetError(this.textBoxAddNewElement, "");
                this.errorProviderCheckFirstName.SetError(this.textBoxAddNewElement, "");
                string addElement = this.textBoxAddNewElement.Text;
                this.lst.Add(addElement);
                this.listBoxDisplayList.Items.Add(addElement);

                // Items count
                int numberOfItems = this.lst.Count;
                this.textBoxItemsCount.Text = numberOfItems.ToString();

            }
            this.textBoxAddNewElement.Text = "";
            this.textBoxAddNewElement.Focus();

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

            if (!CheckingInputs.CheckValidNumber(this.textBoxIndexElement.Text))
            {
                this.errorProviderValidNumber.SetError(this.textBoxIndexElement, "Veuillez saisir un index valide");
                this.textBoxIndexElement.Text = "";
                this.textBoxSelectedIndex.Text = "";
                this.textBoxIndexElement.Focus();
            }

            else
            {
                this.errorProviderValidNumber.SetError(this.textBoxIndexElement, "");
                int selectedIndex = Int32.Parse(this.textBoxIndexElement.Text);

                if (selectedIndex > this.listBoxDisplayList.Items.Count - 1)
                {
                    this.errorProviderCheckListLength.SetError(this.textBoxIndexElement, "Veuillez saisir un index inférieur à la longueur du tableau");
                    this.textBoxIndexElement.Text = "";
                    this.textBoxSelectedIndex.Text = "";
                    this.textBoxIndexElement.Focus();
                }
                else
                {
                    this.listBoxDisplayList.SelectedIndex = selectedIndex;
                    this.errorProviderCheckListLength.SetError(this.textBoxIndexElement, "");
                }

            }
        }

        private void buttonEmptyList_Click(object sender, EventArgs e)
        {
            this.listBoxDisplayList.Items.Clear();
            this.textBoxItemsCount.Text = string.Empty;
            this.textBoxSelectedIndex.Text = string.Empty;
            this.textBoxText.Text = string.Empty;
            this.textBoxIndexElement.Text = string.Empty;
            int numberOfItems = 0;
            this.textBoxItemsCount.Text = numberOfItems.ToString();
            this.lst.Clear();
        }


    }
}