using System.Diagnostics;

namespace TatankaSolutions.Forms.Forms.Proxies
{
    internal class WindowsProxy
    {
        static WindowsProxy()
        {
            var installScript = @"npm install -g proxy-login-automator";

            Process.Start("CMD.exe", installScript);
        }

        public static void ChangeProxy(ProxySetting proxy)
        {
            var proxyAdress = proxy.IP.Split(":");
            var ip = proxyAdress[0];
            var port = proxyAdress[1];

            var login_automator_script = @$"node proxy-login-automator.js ^
                                            - local_port {8081} ^
                                            -remote_host {ip} ^
                                            -remote_port {port} ^
                                            -usr {proxy.User} - pwd {proxy.Password}";

            Process.Start("CMD.exe", login_automator_script);
        }
    }
}