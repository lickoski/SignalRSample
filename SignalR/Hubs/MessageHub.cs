
using Microsoft.AspNetCore.SignalR;

namespace SignalR.Hubs
{
    public class MessageHub : Hub
    {
        public  Task SendMessageToAll(string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
