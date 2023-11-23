namespace CL_CheckButtons
{
     static public class CheckButtons
    {
        public static Boolean ButtonValidateAddAnItem(ComboBox box,ListBox lst)
        {
            bool btnValidate = box.Text != "" || lst.Text != "";
            return btnValidate;
            
        }

        public static Boolean ComboboxIsEmpty(ComboBox box)
        {
            bool boxIsEmpty = box.Items.Count == 0;
            return boxIsEmpty; 
        }

    }
}