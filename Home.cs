using PoorEgybest.project;
using System.Linq;
using System.Windows.Forms;

namespace PoorEgybest
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public IEnumerable<object> Libraries { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            HF hF = new HF();
            hF.Show();
            this.Hide();
        }
    }
}
