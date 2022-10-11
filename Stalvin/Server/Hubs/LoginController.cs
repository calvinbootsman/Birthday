using Microsoft.AspNetCore.SignalR;
namespace Stalvin.Server.Hubs
{
    /* A user sends their username to this controller.
     * The  
     * */
    public class LoginController : Hub
    {
        public async Task AddUser(string user)
        {
            await Clients.All.SendAsync("ReceiveMessage", user);
        }

        public async Task IsNameAdded(string user, bool isAdded)
        {
            await Clients.All.SendAsync("IsNameAddedMessage", user, isAdded);
        }
    }
}
