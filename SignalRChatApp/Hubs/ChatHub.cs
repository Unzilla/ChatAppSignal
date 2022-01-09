using Microsoft.AspNetCore.SignalR;

namespace SignalRChatApp.Hubs
{
    public class ChatHub : Hub                                              // inherit this
    {
        public Task SendMessage1(string user, string message)               // Two parameters accepted
        {
            return Clients.All.SendAsync("ReceiveOne", user, message);    // Note this 'ReceiveOne' 
        }
    }
}
