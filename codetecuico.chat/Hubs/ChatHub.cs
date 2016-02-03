using Microsoft.AspNet.SignalR;

namespace codetecuico.chat.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.newMessage(Context.User.Identity.Name.ToString() + " : " + message);
        }
    }
}