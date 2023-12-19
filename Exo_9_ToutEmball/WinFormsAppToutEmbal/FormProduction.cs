using ClassLibraryProduction;

namespace WinFormsAppToutEmbal
{
    public partial class FormProduction : Form
    {
        Production a;

        public FormProduction()
        {
            InitializeComponent();
            a = new Production("Production A", 120, 'A');
            a.NewCrateProduced += A_NewCrateProduced;
        }

        private void A_NewCrateProduced(int numberOfCratesProduced, int target, Production p)
        {
            // mettre à jour la progresse bar avce invoke
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a.StartProduction();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          this.progressBarProductionA.Increment(1);
        }
    }
}