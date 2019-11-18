using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace WebApplication3
{
    public class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", "Connected");
        }

        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
