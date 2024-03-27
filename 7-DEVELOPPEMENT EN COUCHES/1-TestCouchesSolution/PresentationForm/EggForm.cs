using System.Runtime.CompilerServices;

namespace PresentationForm
{
    public partial class EggForm : Form
    {
        private CL_Domain.Egg sonEgg;
        public EggForm()
        {
            InitializeComponent();
        }

        public EggForm(CL_Domain.Egg _sonEgg)
        {
            this.sonEgg = _sonEgg;
        }
    }
}