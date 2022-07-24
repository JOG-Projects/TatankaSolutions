using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace TatankaSolutions.Forms.Forms.Proxies
{
    internal class WindowsProxy
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;

        public static void ChangeProxy(ProxySetting proxy)
        {
            var registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true)!;
            registry.SetValue("ProxyEnable", 1);
            registry.SetValue("ProxyServer", proxy.IP);
            registry.SetValue("ProxyUser", proxy.User);
            registry.SetValue("ProxyPass", proxy.Password);

            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }
    }
}