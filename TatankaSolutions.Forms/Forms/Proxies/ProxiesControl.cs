using TatankaSolutions.Forms.Forms.Proxies;
using Keys = System.Windows.Forms.Keys;

namespace TatankaSolutions.Forms
{
    internal partial class ProxiesControl : UserControl
    {
        private readonly ProxyServices _proxyServices = new();

        public ProxiesControl()
        {
            InitializeComponent();
            LoadProxies();
        }

        private void LoadProxies()
        {
            Lb_Proxies.Items.Clear();
            Lb_Proxies.Items.AddRange(_proxyServices.Proxies.ToArray());
        }

        private void LimparCampos()
        {
            Tb_Ip.Clear();
            Tb_User.Clear();
            Tb_Password.Clear();
        }

        private void Btn_AddProxy_Click(object sender, EventArgs e)
        {
            if (Tb_Ip.Text is "" || Tb_User.Text is "" || Tb_Password.Text is "")
            {
                MessageBox.Show("Invalid field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _proxyServices.Add(new ProxySetting(Tb_Ip.Text, Tb_User.Text, Tb_Password.Text));
            LoadProxies();
            LimparCampos();
        }

        private void Btn_Run_Click(object sender, EventArgs e)
        {
            _proxyServices.StartSeleniumProxy();
        }

        private void Lb_proxies_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.Delete && Lb_Proxies.SelectedItem is ProxySetting proxy)
            {
                _proxyServices.Remove(proxy);
            }
        }

        private void Btn_SetGlobalProxy_Click(object sender, EventArgs e)
        {
            if (Lb_Proxies.SelectedItem is not ProxySetting proxy)
            {
                MessageBox.Show("Select one proxy setting", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ProxyServices.SetGlobalProxy(proxy);
        }
    }
}