using System.Transactions;
using System.Windows.Forms;

namespace WinFormsAppCountriesList
{
    public partial class FormCountriesList : Form
    {
        // Attributes
        private Dictionary<string, bool> countries;

        // Builders
        public FormCountriesList(Dictionary<string, bool> _countries)
        {
            InitializeComponent();
            this.countries = _countries;
        }

        public FormCountriesList()
        {
            InitializeComponent();
            this.countries = new Dictionary<string, bool>();
        }
        // Getters and setters
        public Dictionary<string, bool> Countries { get => this.countries; private set => this.countries = value; }

        private void FormCountriesList_Load(object sender, EventArgs e)
        {   
            foreach (KeyValuePair<string, bool> country in this.countries)
            {
                if(country.Value)
                {
                    this.listBoxTarget.Items.Add(country.Key);
                }
                else
                {
                    this.comboBoxCountriesList.Items.Add(country.Key);  
                }        
            }
            ChangeStateButtons();
        }

        private void comboBoxCountriesList_DropDown(object sender, EventArgs e)
        {
            if (this.comboBoxCountriesList.Text != "" && CL_CheckButtons.CheckButtons.CheckCountryName(this.comboBoxCountriesList.Text)
                && this.comboBoxCountriesList.FindStringExact(this.comboBoxCountriesList.Text) == ListBox.NoMatches
                && this.listBoxTarget.FindStringExact(this.comboBoxCountriesList.Text) == ListBox.NoMatches)
            {
                this.comboBoxCountriesList.Items.Add(this.comboBoxCountriesList.Text);
                this.errorProviderDuplicateCountry.SetError(this.comboBoxCountriesList, "");
            }
            else
            {
                if (this.comboBoxCountriesList.Text == "")
                {
                    this.errorProviderDuplicateCountry.SetError(this.comboBoxCountriesList, "");
                }
                else
                {
                    this.errorProviderDuplicateCountry.SetError(this.comboBoxCountriesList, "Ce pays est déjà dans la liste,veuillez saisir un autre nom de pays");
                    //this.comboBoxCountriesList.Text = "";
                    //this.comboBoxCountriesList.Focus();
                }
            }
        }

        private void buttonAddAnItem_Click(object sender, EventArgs e)
        {
            if (this.comboBoxCountriesList.SelectedIndex != -1)
            {
                this.listBoxTarget.Items.Add(this.comboBoxCountriesList.Items[this.comboBoxCountriesList.SelectedIndex]);
                this.comboBoxCountriesList.Items.RemoveAt(this.comboBoxCountriesList.SelectedIndex);
                this.comboBoxCountriesList.Text = "";
                ChangeStateButtons();
            }
        }

        private void buttonAddAllItems_Click(object sender, EventArgs e)
        {
            foreach (string item in this.comboBoxCountriesList.Items)
            {
                this.listBoxTarget.Items.Add(item);
            }
            //this.listBoxTarget.Items.AddRange(this.comboBoxCountriesList.Items);
            this.comboBoxCountriesList.Items.Clear();
            ChangeStateButtons();
        }

        private void buttonRemoveAnItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.listBoxTarget.SelectedIndex;
            this.comboBoxCountriesList.Items.Add(this.listBoxTarget.Text);
            this.listBoxTarget.Items.Remove(this.listBoxTarget.Text);


            /*if (this.listBoxTarget.SelectedIndex != -1 && this.listBoxTarget.SelectedIndex == this.listBoxTarget.Items.Count - 1)
            {
                this.listBoxTarget.SelectedIndex = 0;
            }*/
            if (CL_CheckButtons.CheckButtons.ListboxIsEmpty(this.listBoxTarget))
            {
                this.listBoxTarget.SelectedIndex = -1;
            }
            else if (this.listBoxTarget.SelectedIndex == -1 && this.listBoxTarget.Items.Count - 1 == selectedIndex - 1)
            {
                this.listBoxTarget.SelectedIndex = selectedIndex - 1;
            }
            else //if(this.listBoxTarget.SelectedIndex == -1) // index not selected
            {
                this.listBoxTarget.SelectedIndex = selectedIndex;
            }
            ChangeStateButtons();
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
            if (!CL_CheckButtons.CheckButtons.CheckCountryName(this.comboBoxCountriesList.Text) && this.comboBoxCountriesList.Text != "")
            {
                this.errorProviderCheckCountry.SetError(this.comboBoxCountriesList, "Veuillez entrer un nom de pays valide avec la première lettre en majuscule");
            }

            else
            {
                this.errorProviderCheckCountry.SetError(this.comboBoxCountriesList, "");
                this.errorProviderDuplicateCountry.SetError(this.comboBoxCountriesList, "");
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
            //if (this.comboBoxCountriesList.SelectedIndex != -1)
            //{
            //    this.buttonAddAnItem.Enabled = true;
            //}
            //else
            //{
            //    this.buttonAddAnItem.Enabled = false;
            //}
            this.buttonAddAnItem.Enabled = (this.comboBoxCountriesList.SelectedIndex != -1);

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
            //if (this.listBoxTarget.SelectedIndex != -1)
            //{
            //    this.buttonRemoveAnItem.Enabled = true;
            //}
            //else
            //{
            //    this.buttonRemoveAnItem.Enabled = false;
            //}
            this.buttonRemoveAnItem.Enabled = (this.listBoxTarget.SelectedIndex != -1);

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

        private void buttonUpArrow_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void buttonDownArrow_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeStateButtons();
            if (this.listBoxTarget.SelectedIndex != -1 && this.listBoxTarget.SelectedIndex > 0 && this.listBoxTarget.SelectedIndex != this.listBoxTarget.Items.Count - 1)
            {
                this.buttonUpArrow.Enabled = true;
                this.buttonDownArrow.Enabled = true;
                //this.buttonRemoveAnItem.Enabled = true;
            }
            else if (this.listBoxTarget.SelectedIndex != -1 && this.listBoxTarget.SelectedIndex == 0)
            {
                this.buttonUpArrow.Enabled = false;

                if (this.listBoxTarget.SelectedIndex == 0 && this.listBoxTarget.Items.Count == 1)
                {
                    this.buttonDownArrow.Enabled = false;
                }
                else
                {
                    this.buttonDownArrow.Enabled = true;
                }
            }
            else if (this.listBoxTarget.SelectedIndex != -1 && this.listBoxTarget.SelectedIndex == this.listBoxTarget.Items.Count - 1)
            {
                this.buttonUpArrow.Enabled = true;
                this.buttonDownArrow.Enabled = false;
            }
        }

        private void comboBoxCountriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.errorProviderDuplicateCountry.SetError(this.comboBoxCountriesList, "");
            if (this.comboBoxCountriesList.SelectedIndex != -1)
            {
                this.buttonAddAnItem.Enabled = true;
                this.buttonAddAllItems.Enabled = true;
            }
            else
            {
                this.buttonAddAnItem.Enabled = false;
                this.buttonAddAllItems.Enabled = false;
            }
        }

        private void MoveItem(int direction)
        {
            // Checking selected item
            if (listBoxTarget.SelectedItem == null || listBoxTarget.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBoxTarget.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBoxTarget.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBoxTarget.SelectedItem;

            // Removing removable element
            listBoxTarget.Items.Remove(selected);
            // Insert it in new position
            listBoxTarget.Items.Insert(newIndex, selected);
            // Restore selection
            listBoxTarget.SetSelected(newIndex, true);
        }

        private void FormCountriesList_FormClosing(object sender, FormClosingEventArgs e)
        {
            countries.Clear();
            foreach (string country in this.listBoxTarget.Items)
            {
                countries.Add(country, true);
            }
            foreach (string country in this.comboBoxCountriesList.Items)
            {
                countries.Add(country, false);
            }
        }
    }
}
