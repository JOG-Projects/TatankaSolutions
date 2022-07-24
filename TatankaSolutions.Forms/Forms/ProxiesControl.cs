using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Keys = System.Windows.Forms.Keys;

namespace ConvertText.Forms
{
    internal record ProxySetting(string IP, string User, string Password);

    internal partial class ProxiesControl : UserControl
    {
        public ProxiesControl()
        {
            InitializeComponent();

            if (!File.Exists("proxies.json"))
            {
                SaveProxies();
            }
            Proxies = JsonConvert.DeserializeObject<List<ProxySetting>>(File.ReadAllText("proxies.json"))!;

            LoadProxies();
        }

        private List<ProxySetting> Proxies { get; } = new();

        private static void StartSelenium(ProxySetting proxy)
        {
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;

            var options = new ChromeOptions
            {
                AcceptInsecureCertificates = true,
                Proxy = new Proxy { HttpProxy = proxy.IP, SslProxy = proxy.IP, Kind = ProxyKind.Manual }
            };

            var driver = new ChromeDriver(chromeDriverService, options, TimeSpan.FromSeconds(30));

            var handler = new NetworkAuthenticationHandler()
            {
                UriMatcher = d => true,
                Credentials = new PasswordCredentials(proxy.User, proxy.Password)
            };

            var networkInterceptor = driver.Manage().Network;
            networkInterceptor.AddAuthenticationHandler(handler);
            networkInterceptor.StartMonitoring();

            driver.Navigate().GoToUrl("https://meuip.com.br/");
        }

        private void LoadProxies()
        {
            Lb_Proxies.Items.Clear();
            Lb_Proxies.Items.AddRange(Proxies.ToArray());
        }

        private void LimparCampos()
        {
            Tb_Ip.Clear();
            Tb_User.Clear();
            Tb_Password.Clear();
        }

        private void SaveProxies()
        {
            File.WriteAllText("proxies.json", JsonConvert.SerializeObject(Proxies));
            LoadProxies();
        }

        private void Btn_doProxy_Click(object sender, EventArgs e)
        {
            if (Tb_Ip.Text is "" || Tb_User.Text is "" || Tb_Password.Text is "")
            {
                return;
            }

            Proxies.Add(new ProxySetting(Tb_Ip.Text, Tb_User.Text, Tb_Password.Text));
            SaveProxies();
            LimparCampos();
        }

        private void Btn_run_Click(object sender, EventArgs e)
        {
            foreach (var proxy in Proxies)
            {
                Task.Run(() => StartSelenium(proxy));
            }
        }

        private void Lb_proxies_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.Delete && Lb_Proxies.SelectedItem is not null)
            {
                var removed = (ProxySetting)Lb_Proxies.SelectedItem;
                Proxies.Remove(removed);
                SaveProxies();
            }
        }
    }
}