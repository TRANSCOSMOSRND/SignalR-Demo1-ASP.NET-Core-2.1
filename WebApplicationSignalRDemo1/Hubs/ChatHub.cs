
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace WebApplicationSignalRDemo1.Hubs
{
    /// <summary>
    /// This is a hub class
    /// </summary>
    public class ChatHub : Hub
    {
        /// <summary>
        /// handle sending messages
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
