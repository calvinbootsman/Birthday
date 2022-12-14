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
            await Clients.All.SendAsync("Question", user, question, answers);
        }

        public async Task SendAnswer(string answer)
        {
            await Clients.All.SendAsync("Answer", answer);
        }

        public async Task GoToNextPage()
        {
            await Clients.All.SendAsync("NextPageMessage", "");
        }

        public async Task PictureAssignRole(string user, int index)
        {
            await Clients.All.SendAsync("PictureAssignRoleMessage", user, index);
        }

        public async Task NextPicture(string theme, int pictureIndex)
        {
            await Clients.All.SendAsync("NextPictureMessage", theme, pictureIndex);
        }

        public async Task NextCharacter(string user, char c)
        {
            await Clients.All.SendAsync("NextCharacterMessage", user, c);
        }

        public async Task SecretAssignRole(string user)
        {
            await Clients.All.SendAsync("SecretAssignRoleMessage", user);
        }

        public async Task AddTime(int time)
        {
            await Clients.All.SendAsync("AddTimeMessage", time);
        }

        public async Task IsGameRunning(bool isRunning)
        {
            await Clients.All.SendAsync("IsGameRunningEvent", isRunning);
        }

        public async Task NextChallenge()
        {
            await Clients.All.SendAsync("NextChallengeMessage", "yo");
        }
        public async Task PreviousChallenge()
        {
            await Clients.All.SendAsync("PreviousChallengeMessage", "yo");
        }
        public async Task SetLabel(int index)
        {
            await Clients.All.SendAsync("SetLabelMessage", index);
        }
    }
}
