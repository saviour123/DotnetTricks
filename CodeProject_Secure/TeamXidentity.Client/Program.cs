using System;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
using Newtonsoft.Json.Linq;

namespace TeamXidentity.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        private static async Task MainAsync()
        {
            var discovery = await DiscoveryClient.GetAsync("http://localhost:5000");

            if (discoery.IsError)
            {
                Console.WriteLine(discovery.Error);
                return;
            }

            var tokenClient = new TokenClient(discovery.TokenEndpoint, "client", "secret");
            var tokenResponse = await tokenClient.RequestClientCredentialsAsync("openid");

            if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
                return;
            }

            Console.WriteLine(tokenResponse.Json);

            //Call The API
            var client = new HttpClient();
            client.SetBearerToken(token: tokenResponse.AccessToken);
            
            var data = await client.GetAsync("http://localhost:5003/api/values/getdata");

            if (!data.IsSuccessStatusCode)
            {
                Console.WriteLine(data.StatusCode);
            }
            else 
            {
                var content = await data.Content.ReadAsStringAsync();
                Console.WriteLine(JArray.Parse(content));
            }




        }
    }

}
