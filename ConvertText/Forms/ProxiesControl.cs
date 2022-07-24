using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Keys = System.Windows.Forms.Keys;

namespace ConvertText.Forms
{
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
            lb_proxies.Items.Clear();
            lb_proxies.Items.AddRange(Proxies.ToArray());
        }

        private void LimparCampos()
        {
            ip.Clear();
            user.Clear();
            password.Clear();
        }

        private void Btn_Baixo_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = Tb_Entrada.Text;

                var linhas = entrada.Split("\n");

                var final = linhas.Select(l => l.Split(" "));

                Tb_Saida.Text = string.Join(Environment.NewLine, final.SelectMany(x => x));
            }
            catch { }
        }
        private void SaveProxies()
        {
            File.WriteAllText("proxies.json", JsonConvert.SerializeObject(Proxies));
            LoadProxies();
        }

        private void Btn_Lado_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = Tb_Entrada.Text;

                var palavras = new Queue<string>(entrada.Split("\n"));

                var sb = new StringBuilder();
                while (palavras.Any())
                {
                    var linha = $"{palavras.Dequeue().Trim()} {palavras.Dequeue().Trim()}";
                    sb.AppendLine(linha);
                }

                Tb_Saida.Text = sb.ToString();
            }
            catch { }
        }

        private void btn_doProxy_Click(object sender, EventArgs e)
        {
            if (ip.Text is "" || user.Text is "" || password.Text is "")
            {
                return;
            }

            Proxies.Add(new ProxySetting(ip.Text, user.Text, password.Text));
            SaveProxies();
            LimparCampos();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            foreach (var proxy in Proxies)
            {
                Task.Run(() => StartSelenium(proxy));
            }
        }

        private void Lb_proxies_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.Delete && lb_proxies.SelectedItem is not null)
            {
                var removed = (ProxySetting)lb_proxies.SelectedItem;
                Proxies.Remove(removed);
                SaveProxies();
            }
        }

        private void Btn_doProxy_Click(object sender, EventArgs e)
        {
            var proxy = new ProxySetting(ip.Text, user.Text, password.Text);
            Proxies.Add(proxy);
            SaveProxies();
        }
    }
}