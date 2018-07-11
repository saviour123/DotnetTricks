using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace signalIR
{
    public class ChatHub : Hub
    {
        
        public Task Send(string user, string message)
        {
            string timestamp = DateTime.Now.ToShortTimeString();
            return Clients.All.SendAsync("Send", timestamp, user, message);
        }
    }
}