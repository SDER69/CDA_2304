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
        }

        private void listBoxDisplayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = this.listBoxDisplayList.SelectedIndex.ToString();
            this.textBoxSelectedIndex.Text = curItem;  
        }
    }
}