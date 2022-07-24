using TatankaSolutions.Forms;

namespace TatankaSolutions
{
    internal partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            tabPage1.Controls.Add(new TextConvertControl());
            tabPage2.Controls.Add(new ProxiesControl());
        }
    }
}