using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ShadowApp.Hubs
{
    public class ChatHub : Hub
    {
        public void send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}