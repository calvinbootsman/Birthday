namespace Stalvin.Client.models
{
    public class ChallengeModel
    {
        public string Challenge { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public static List<ChallengeModel> GetChallenges()
        {
            List<ChallengeModel> challenges = new List<ChallengeModel>();
            challenges.Add(new ChallengeModel { Challenge = "Guess the line", Description = "My accomplish will give put something on the table. It's up to all of you to figure it out what it is." });
            challenges.Add(new ChallengeModel { Challenge = "Trick shot", Description = "Throw a table tennis ball across the room, into a cup, a person has to drink for every missed ball" });
            challenges.Add(new ChallengeModel { Challenge = "Solve a rubiks cube", Description = "" });
            challenges.Add(new ChallengeModel { Challenge = "play the ball 10 times", Description = "Pass the ball 10 times to each other using the beach tennis rackets" });
            challenges.Add(new ChallengeModel { Challenge = "Build a card house", Description = "It has to be 2 high, so with a base of 2 pairs. Multiple people can join." });
            challenges.Add(new ChallengeModel { Challenge = "Weighing game", Description = "Play the weighing game until the time is up. lol." });
            return challenges;
        }

    }
}
