using Microsoft.AspNetCore.SignalR;
using System.Security.Cryptography.X509Certificates;

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

        public async Task SendQuestion(string user, string question, List<string> answers)
        {
            await Clients.All.SendAsync("Question", "user 5", question, answers);
        }

        public async Task SendAnswer(string answer)
        {
            await Clients.All.SendAsync("Answer", answer);
        }
    }
}
