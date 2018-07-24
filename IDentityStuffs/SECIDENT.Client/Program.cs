using System.Threading.Tasks;
using IdentityModel.Client;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System;

namespace TeamX.Security.Client {
	public class Program {
		public static void Main(string[] args) =>
		MainAsync().GetAwaiter().GetResult();

		private static async Task MainAsync() {
			// discover endpoints from the metadata by calling Auth server hosted on 5000 port
			var discoveryClient = await DiscoveryClient.GetAsync("http://localhost:5000");
			if (discoveryClient.IsError) {
				Console.WriteLine(discoveryClient.Error);
				return;
			}

			// request the token from the Auth server
			var tokenClient = new TokenClient(discoveryClient.TokenEndpoint, "client", "secret");
			var tokenResponse = await tokenClient.RequestClientCredentialsAsync("api1");


			if (tokenResponse.IsError) {
				Console.WriteLine(tokenResponse.Error);
				return;
			}

			Console.WriteLine(tokenResponse.Json);
			Console.WriteLine("\n\n");

			// call the api
			var client = new HttpClient();
			client.SetBearerToken(tokenResponse.AccessToken);

			var response = await client.GetAsync("http://localhost:5003/identity");
			if (!response.IsSuccessStatusCode)
			{
				Console.WriteLine(response.StatusCode);
			}

			else 
			{
				var content = await response.Content.ReadAsStringAsync();
				Console.WriteLine(JArray.Parse(content));
			}

		}

	}

}