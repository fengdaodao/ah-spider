using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using HtmlAgilityPack;
using System.Text;

namespace AH.Spider.Console
{
    class Program
    {
        //private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            //var services = new ServiceCollection();
            //services.AddHttpClient("athome",d =>
            //{
            //    d.DefaultRequestHeaders.Add("host", "car.autohome.com.cn");
            //    d.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
            //});

            //services
            //    .AddScoped<IInvoker, Invoker>()
            //    .AddScoped<IScratcher, Scratcher>()
            //    .AddScoped<IHtmlResolver, HtmlResolver>()
            //    ;

            //await services.BuildServiceProvider().GetService<IInvoker>().InvokeAsync();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //var b = Encoding.GetEncoding(936);
            //var a = Encoding.GetEncoding("GB2312");


            await ProcessRepositories();
        }

        private static async Task ProcessRepositories()
        {
            //var html = @"http://html-agility-pack.net/";
            var html = "https://car.autohome.com.cn";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
            System.Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

            var text = htmlDoc.Text;
            var gb2312 = Encoding.GetEncoding("gb2312");
            var utf8Bytes = Encoding.Convert(gb2312, Encoding.UTF8, gb2312.GetBytes(text));
            var newText = Encoding.UTF8.GetString(utf8Bytes);
            System.Console.Write(newText);
        }
    }
}
