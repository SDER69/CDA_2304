namespace WinFormsAppCountriesList
{
    public partial class FormCountriesList : Form
    {
        Dictionary <string,bool> countries;
        public FormCountriesList()
        {
            InitializeComponent();
            countries = new Dictionary<string,bool>();
            this.countries.Add("France",false);
            this.countries.Add("Belgique",false);
            this.countries.Add("Allemagne",false);
            this.countries.Add("Japon",false);
            this.countries.Add("Portugal",false);
            this.countries.Add("Grece",false);
        }
        

        private void FormCountriesList_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair <string,bool> country in this.countries)
            {
                this.comboBoxCountriesList.Items.Add(country.Key);
            }
            this.buttonAddAnItem.Enabled = false;
            this.buttonRemoveAnItem.Enabled = false;
            this.buttonRemoveAllItems.Enabled = false;
            this.buttonUpArrow.Enabled = false;
            this.buttonDownArrow.Enabled = false;
        }

        private void comboBoxCountriesList_DropDown(object sender, EventArgs e)
        {
            if(this.comboBoxCountriesList.Text != ""  )
            {
                this.comboBoxCountriesList.Items.Add(this.comboBoxCountriesList.Text);
            }
        }


        private void buttonAddAnItem_Click(object sender, EventArgs e)
        {
            this.listBoxTarget.Items.Add(this.comboBoxCountriesList.Text);
            this.comboBoxCountriesList.Items.Remove(this.comboBoxCountriesList.Text);
            this.comboBoxCountriesList.Text = "";
        }

        private void buttonAddAllItems_Click(object sender, EventArgs e)
        {
            foreach (string item in this.comboBoxCountriesList.Items)
            {
                this.listBoxTarget.Items.Add(item);
            }
            this.comboBoxCountriesList.Items.Clear();

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


        }

        private void comboBoxCountriesList_TextChanged(object sender, EventArgs e)
        {
           ChangeStateButtons();
        }

        private void ChangeStateButtons()
        {
            if (CL_CheckButtons.CheckButtons.ComboboxIsEmpty(this.comboBoxCountriesList))
            {
                this.buttonAddAnItem.Enabled = true;
            }
           


            {

            }
        }

        
    }
}