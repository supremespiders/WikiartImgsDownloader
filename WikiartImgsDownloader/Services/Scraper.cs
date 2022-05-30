using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WikiartImgsDownloader.Models;

namespace WikiartImgsDownloader.Services
{
    public class Scraper
    {
        private HttpClient _client;
        public Scraper()
        {
            _client = new HttpClient(new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            });
        }

        public async Task MainWork(CancellationToken ct)
        {
            Notifier.Display("Started working");


            Notifier.Display("Completed working");
        }
    }
}