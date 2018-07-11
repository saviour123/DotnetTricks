using System;
using System.Net.Http;
using System.Threading.Tasks;

class DownloadPageHttpClient
{
    static void Main()
    {
        Task t = new Task(DownloadPageAsync);
        t.Start();
        Console.WriteLine("Downloading page...");
        Console.ReadLine();
    }

    static async void DownloadPageAsync()
    {
        string page = "http://www.example.com";

        using (HttpClient client = new HttpClient())
        using (HttpResponseMessage response = await client.GetAsync(page))
        using (HttpContent content = response.Content)
        {
            string result = await content.ReadAsStringAsync();

            Console.WriteLine(result);
        }
    }
}
