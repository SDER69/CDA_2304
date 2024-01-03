using ClassLibraryProduction;

namespace WinFormsAppToutEmbal
{
    public partial class FormProduction : Form
    {
        Production a;
        Production b;
        Production c;

        public FormProduction()
        {
            InitializeComponent();
            a = new Production("Production A", 2500, 'A');
            b = new Production("Production B", 2000, 'B');
            c = new Production("Production C", 2500, 'C');

            a.NewCrateProduced += A_NewCrateProduced;
            b.NewCrateProduced += B_NewCrateProduced;
            c.NewCrateProduced += C_NewCrateProduced;

            this.progressBarProductionA.Maximum = a.NumberOfCratesToProduce;
            this.progressBarProductionB.Maximum = b.NumberOfCratesToProduce;
            this.progressBarProductionC.Maximum = c.NumberOfCratesToProduce;
            

        }



        public delegate void DelegateUpdateProgressBar(int numberOfCratesProduced);
        private void A_NewCrateProduced(int numberOfCratesProduced, int target, Production p)
        {
            // mettre à jour la progress bar avec Invoke
            this.Invoke(new DelegateUpdateProgressBar(UpdtateProgessBarA), new Object[] { numberOfCratesProduced });
        }
        private void B_NewCrateProduced(int numberOfCratesProduced, int target, Production p)
        {
            this.Invoke(new DelegateUpdateProgressBar(UpdtateProgessBarB), new Object[] { numberOfCratesProduced });
        }

        private void C_NewCrateProduced(int numberOfCratesProduced, int target, Production p)
        {
            this.Invoke(new DelegateUpdateProgressBar(UpdtateProgessBarC), new Object[] { numberOfCratesProduced });
        }
        private void UpdtateProgessBarA(int numberOfCratesProduced)
        {
            this.progressBarProductionA.Value = numberOfCratesProduced;
        }

        private void UpdtateProgessBarB(int numberOfCratesProduced)
        {
            this.progressBarProductionB.Value = numberOfCratesProduced;
        }

        private void UpdtateProgessBarC(int numberOfCratesProduced)
        {
            this.progressBarProductionC.Value = numberOfCratesProduced;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aToolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            a.StartProduction();
            //a.ProducedCrates.Count.ToString();
        }

        private void bToolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            b.StartProduction();
        }

        private void cToolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            c.StartProduction();
        }

        private void aToolStripMenuItemStop_Click(object sender, EventArgs e)
        {
            a.SuspendProduction();
        }

        private void bToolStripMenuItemStop_Click(object sender, EventArgs e)
        {
            b.SuspendProduction();
        }

        private void cToolStripMenuItemStop_Click(object sender, EventArgs e)
        {
            c.SuspendProduction();
        }

        private void aToolStripMenuItemContinue_Click(object sender, EventArgs e)
        {
            a.StartProduction();
        }

        private void bToolStripMenuItemContinue_Click(object sender, EventArgs e)
        {
            b.StartProduction();
        }

        private void cToolStripMenuItemContinue_Click(object sender, EventArgs e)
        {
            c.StartProduction();
        }

      







        /*private void timer1_Tick(object sender, EventArgs e)
        {
          this.progressBarProductionA.Increment(1);
        }*/
    }
}