using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Chat
{
    public class ChatHub : Hub
    {
        public void Broadcast(string message)
        {
            Clients.All.receive(Context.ConnectionId, message);
        }
    }
}