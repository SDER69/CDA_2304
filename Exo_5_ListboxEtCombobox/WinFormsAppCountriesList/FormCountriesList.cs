using System.Runtime.CompilerServices;

namespace WinFormsAppCountriesList
{
    public partial class FormCountriesList : Form
    {
        Dictionary<string, bool> countries;
        public FormCountriesList()
        {
            InitializeComponent();
            countries = new Dictionary<string, bool>();
            this.countries.Add("France", false);
            this.countries.Add("Belgique", false);
            this.countries.Add("Allemagne", false);
            this.countries.Add("Japon", false);
            this.countries.Add("Portugal", false);
            this.countries.Add("Grece", false);
        }


        private void FormCountriesList_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, bool> country in this.countries)
            {
                this.comboBoxCountriesList.Items.Add(country.Key);
            }
            /*this.buttonAddAnItem.Enabled = true;
            this.buttonAddAllItems.Enabled = true;
            this.buttonRemoveAnItem.Enabled = false;
            this.buttonRemoveAllItems.Enabled = true;
            this.buttonUpArrow.Enabled = false;
            this.buttonDownArrow.Enabled = false;*/
            ChangeStateButtons();
        }

        private void comboBoxCountriesList_DropDown(object sender, EventArgs e)
        {
            if (this.comboBoxCountriesList.Text != "" && CL_CheckButtons.CheckButtons.CheckCountryName(this.comboBoxCountriesList.Text))
            {
                foreach (string item in this.comboBoxCountriesList.Items)
                {
                    {
                        if (this.comboBoxCountriesList.Text == item)
                        {
                            this.errorProviderDuplicateCountry.SetError(this.comboBoxCountriesList, "Ce pays est déjà présent dans la liste veuillez saisir un autre pays");
                        }
                    }
                }
                foreach (string item in this.listBoxTarget.Items)
                {
                    if (this.comboBoxCountriesList.Text == item)
                    {
                        this.errorProviderDuplicateCountry.SetError(this.comboBoxCountriesList, "Ce pays est déjà présent dans la liste veuillez saisir un autre pays");
                    }
                }
            }
            else
            {
                this.errorProviderDuplicateCountry.SetError(this.comboBoxCountriesList, "");
                this.comboBoxCountriesList.Items.Add(this.comboBoxCountriesList.Text);
            }
        

        }

        private void buttonAddAnItem_Click(object sender, EventArgs e)
        {
            this.listBoxTarget.Items.Add(this.comboBoxCountriesList.Text);
            this.comboBoxCountriesList.Items.Remove(this.comboBoxCountriesList.Text);
            this.comboBoxCountriesList.Text = "";
            ChangeStateButtons();
        }

        private void buttonAddAllItems_Click(object sender, EventArgs e)
        {
            foreach (string item in this.comboBoxCountriesList.Items)
            {
                this.listBoxTarget.Items.Add(item);
            }
            this.comboBoxCountriesList.Items.Clear();
            ChangeStateButtons();

        }

        private void buttonRemoveAnItem_Click(object sender, EventArgs e)
        {
            this.comboBoxCountriesList.Items.Add(this.listBoxTarget.Text);
            this.listBoxTarget.Items.Remove(this.listBoxTarget.Text);
        }

        private void buttonRemoveAllItems_Click(object sender, EventArgs e)
        {
            foreach (string item in this.listBoxTarget.Items)
            {
                this.comboBoxCountriesList.Items.Add(item);
            }
            this.listBoxTarget.Items.Clear();
            ChangeStateButtons();
        }

        private void comboBoxCountriesList_TextChanged(object sender, EventArgs e)
        {
            if (!CL_CheckButtons.CheckButtons.CheckCountryName(this.comboBoxCountriesList.Text))
            {
                this.errorProviderCheckCountry.SetError(this.comboBoxCountriesList, "Veuillez entrer un nom de pays valide avec la première lettre en majuscule");
            }

            else
            {
                this.errorProviderCheckCountry.SetError(this.comboBoxCountriesList, "");
            }
        }

        private void ChangeStateButtons()
        {

            if (CL_CheckButtons.CheckButtons.ComboboxIsEmpty(this.comboBoxCountriesList))
            {
                this.buttonAddAnItem.Enabled = false;
                this.buttonAddAllItems.Enabled = false;

            }
            else
            {
                this.buttonAddAnItem.Enabled = true;
                this.buttonAddAllItems.Enabled = true;

            }
            if (this.comboBoxCountriesList.SelectedIndex != -1)
            {
                this.buttonAddAnItem.Enabled = true;
            }
            else
            {
                this.buttonAddAnItem.Enabled = false;
            }
            if (CL_CheckButtons.CheckButtons.ListboxIsEmpty(this.listBoxTarget))
            {
                this.buttonRemoveAnItem.Enabled = false;
                this.buttonRemoveAllItems.Enabled = false;
            }
            else
            {
                this.buttonRemoveAnItem.Enabled = true;
                this.buttonRemoveAllItems.Enabled = true;
            }
            if (this.listBoxTarget.SelectedIndex != -1)
            {
                this.buttonRemoveAnItem.Enabled = true;
            }
            else
            {
                this.buttonRemoveAnItem.Enabled = false;
            }
            if (listBoxTarget.Items.Count > 1 && listBoxTarget.SelectedIndex != -1)
            {
                this.buttonUpArrow.Enabled = true;
                this.buttonDownArrow.Enabled = true;
            }
            else
            {
                this.buttonUpArrow.Enabled = false;
                this.buttonDownArrow.Enabled = false;
            }
        }

        private void comboBoxCountriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeStateButtons();
        }

        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeStateButtons();
        }

        private void buttonUpArrow_Click(object sender, EventArgs e)
        {
            if (this.listBoxTarget.SelectedIndex != -1 && this.listBoxTarget.SelectedIndex != 0)
            {
                this.listBoxTarget.SelectedIndex -= 1;
            }
            if (this.listBoxTarget.SelectedIndex == 0)
            {
                this.buttonUpArrow.Enabled = false;
            }



        }

        private void buttonDownArrow_Click(object sender, EventArgs e)
        {
            if (this.listBoxTarget.SelectedIndex != -1 && this.listBoxTarget.SelectedIndex != this.listBoxTarget.Items.Count - 1)
            {
                this.listBoxTarget.SelectedIndex += 1;
            }
            if (this.listBoxTarget.SelectedIndex == this.listBoxTarget.Items.Count - 1)
            {
                this.buttonDownArrow.Enabled = false;
            }

        }
    }
}