using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TatankaSolutions.Forms.Forms.Proxies
{
    internal class ProxyServices
    {
        public List<ProxySetting> Proxies { get; } = new();

        public ProxyServices()
        {
            if (!File.Exists("proxies.json"))
            {
                SaveChanges();
            }
            Proxies = JsonConvert.DeserializeObject<List<ProxySetting>>(File.ReadAllText("proxies.json"))!;
        }

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

        public void Add(ProxySetting proxy)
        {
            Proxies.Add(proxy);
            SaveChanges();
        }

        public void Remove(ProxySetting proxy)
        {
            Proxies.Remove(proxy);
            SaveChanges();
        }

        public void StartSeleniumProxy()
        {
            foreach (var proxy in Proxies)
            {
                Task.Run(() => StartSelenium(proxy));
            }
        }

        public void SaveChanges()
        {
            File.WriteAllText("proxies.json", JsonConvert.SerializeObject(Proxies));
        }

        public static void SetGlobalProxy(ProxySetting proxy)
        {
            WindowsProxy.ChangeProxy(proxy);
        }
    }
}
