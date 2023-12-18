using Microsoft.AspNetCore.SignalR;

namespace WebApplication1
{
    public class ChatApp : Hub
    {
        public async Task Send(string message, string userName)
        {
            await Clients.All.SendAsync("Receive", message, userName);
        }
    }
}

