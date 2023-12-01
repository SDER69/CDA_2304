namespace WinFormsAppColorsDimmer
{
    public partial class FormColorsDimmer : Form
    {
        Color color;
        public FormColorsDimmer()
        {
            InitializeComponent();
            #region configuration
            this.hScrollBarRed.Minimum = 0;
            this.hScrollBarRed.Maximum = 255;
            this.hScrollBarRed.LargeChange = 1;
            this.numericUpDownRed.Minimum = 0;
            this.numericUpDownRed.Maximum = 255;
            this.hScrollBarGreen.Minimum = 0;
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.LargeChange = 1;
            this.numericUpDownGreen.Minimum = 0;
            this.numericUpDownGreen.Maximum = 255;
            this.hScrollBarBlue.Minimum = 0;
            this.hScrollBarBlue.Maximum = 255;
            this.hScrollBarBlue.LargeChange = 1;
            this.numericUpDownBlue.Minimum = 0;
            this.numericUpDownBlue.Maximum = 255;
            #endregion
            color = Color.FromArgb(0, 0, 0);
            UpdateIHM();
        }

        private void UpdateIHM()
        {
            // Red
            this.numericUpDownRed.Value = (int)this.color.R;
            this.panelRed.BackColor = Color.FromArgb((int)this.color.R, 0, 0);
            this.hScrollBarRed.Value = (int)this.color.R;

            // Green
            this.numericUpDownGreen.Value = (int)this.color.G;
            this.panelGreen.BackColor = Color.FromArgb(0, (int)this.color.G, 0);
            this.hScrollBarGreen.Value = (int)this.color.G;

            // Blue
            this.numericUpDownBlue.Value = (int)this.color.B;
            this.panelBlue.BackColor = Color.FromArgb(0, 0, (int)this.color.B);
            this.hScrollBarBlue.Value = (int)this.color.B;

            this.panelDisplayColors.BackColor = color;
        }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {

            int newRed = (int)e.NewValue;
            color = Color.FromArgb(newRed, color.G, color.B);
            UpdateIHM();

            //this.hScrollBarRed.Value = (int)e.NewValue;
            //this.numericUpDownRed.Value = (int)e.NewValue;
            //this.panelRed.BackColor = Color.FromArgb(this.hScrollBarRed.Value, 0, 0);
            //this.panelDisplayColors.BackColor = Color.FromArgb(this.hScrollBarRed.Value, this.hScrollBarGreen.Value, this.hScrollBarBlue.Value);
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            int newGreen = (int)e.NewValue;
            color = Color.FromArgb(color.R, newGreen, color.B);
            UpdateIHM();

            //this.hScrollBarGreen.Value = (int)e.NewValue;
            //this.numericUpDownGreen.Value = (int)e.NewValue;
            //this.panelGreen.BackColor = Color.FromArgb(0, this.hScrollBarGreen.Value, 0);
            //this.panelDisplayColors.BackColor = Color.FromArgb(this.hScrollBarRed.Value, this.hScrollBarGreen.Value, this.hScrollBarBlue.Value);
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            int newBlue = (int)e.NewValue;
            color = Color.FromArgb(color.R, color.G, newBlue);
            UpdateIHM();

            //this.hScrollBarBlue.Value = (int)e.NewValue;
            //this.numericUpDownBlue.Value = (int)e.NewValue;
            //this.panelBlue.BackColor = Color.FromArgb(0, 0, this.hScrollBarBlue.Value);
            //this.panelDisplayColors.BackColor = Color.FromArgb(this.hScrollBarRed.Value, this.hScrollBarGreen.Value, this.hScrollBarBlue.Value);
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            int newRed = (int)this.numericUpDownRed.Value;
            color = Color.FromArgb(newRed, color.G, color.B);
            UpdateIHM();
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            int newGreen = (int)this.numericUpDownGreen.Value;
            color = Color.FromArgb(color.R, newGreen, color.B);
            UpdateIHM();
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            int newBlue = (int)this.numericUpDownBlue.Value;
            color = Color.FromArgb(color.R, color.G, newBlue);
            UpdateIHM();
        }
    }
}