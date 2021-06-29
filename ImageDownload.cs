using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class ImageDownload
    {
        public static void DownloadImageGitHub()
        {
            Directory.CreateDirectory("icon");
            WebClient client = new WebClient();
            if (Path.GetFullPath(@"icon\exchange.ico") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/CurrencyConverter/main/icon/exchange.ico"), Path.GetFullPath(@"icon\exchange.ico"));
            }
            if (Path.GetFullPath(@"icon\darkmode.png") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/CurrencyConverter/main/icon/darkmode.png"), Path.GetFullPath(@"icon\darkmode.png"));
            }
            if (Path.GetFullPath(@"icon\lightmode.png") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/CurrencyConverter/main/icon/lightmode.png"), Path.GetFullPath(@"icon\lightmode.png"));
            }
            if (Path.GetFullPath(@"icon\swap.png") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/CurrencyConverter/main/icon/swap.png"), Path.GetFullPath(@"icon\swap.png"));
            }
            if (Path.GetFullPath(@"icon\up.png") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/CurrencyConverter/main/icon/up.png"), Path.GetFullPath(@"icon\up.png"));
            }
            if (Path.GetFullPath(@"icon\down.png") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/CurrencyConverter/main/icon/down.png"), Path.GetFullPath(@"icon\down.png"));
            }
            if (Path.GetFullPath(@"icon\github.png") != null)
            {
                client.DownloadFile(new Uri("https://raw.githubusercontent.com/umanets-alexander/CurrencyConverter/main/icon/github.png"), Path.GetFullPath(@"icon\github.png"));
            }
        }
    }
}
