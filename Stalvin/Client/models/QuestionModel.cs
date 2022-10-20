namespace Stalvin.Client.models
{
    public class QuestionModel
    {
        public string QuestionId { get; set; } = string.Empty;
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public List<string> Answers = new List<string>(); 

        public static List<QuestionModel> GetRandomQuestions()
        {
            List<QuestionModel> questionList = new List<QuestionModel>();
            questionList.Add(new QuestionModel { QuestionId = "0", Question = "What is Calvin's middle name?", Answer = "quincy" });
            questionList.Add(new QuestionModel { QuestionId = "1", Question = "When did Stalvin first Appear (DD/MM/YYYY)", Answer = "18/10/2019" });
            questionList.Add(new QuestionModel { QuestionId = "2", Question = "We're breaking ❄️", Answer = "Vries" });
            questionList.Add(new QuestionModel { QuestionId = "3", Question = "Which band was Calvin's first concert?", Answer = "Sick Puppies", Answers = { "Nickelback", "Sick Puppies", "Three Days Grace" } });
            questionList.Add(new QuestionModel { QuestionId = "4", Question = "Who's the current president of Colombia", Answer = "Gustavo Petro", Answers = { "César Gaviria", "Gustavo Petro", "Ernesto Samper" } });
            questionList.Add(new QuestionModel { QuestionId = "5", Question = "Rock Paper Scissor", Answer = "Paper", Answers = { "Rock", "Paper", "Scissor" } });
            questionList.Add(new QuestionModel { QuestionId = "6", Question = "Best tricker of Team Freeze", Answer = "Calvin", Answers = { "Calvin", "Calvin", "Calvin", "Calvin" } });
            questionList.Add(new QuestionModel { QuestionId = "7", Question = "What is Calvin's next stage on the Pieterpad?", Answer = "Hellendoorn - Holten", Answers = { "Coevorden - Hardenberg","Hardenberg - Ommen", "Ommen - Hellendoorn", "Hellendoorn - Holten" } });
            questionList.Add(new QuestionModel { QuestionId = "8", Question = "5 * (2 + 8 / 2) / 4 - 2", Answer = "5,5" });
            questionList.Add(new QuestionModel { QuestionId = "9", Question = "What is the capital of Chad", Answer = "N'Djamena", Answers = { "N'Djamena", "Abuja", "Bangui c", "Yaounde" } });
            questionList.Add(new QuestionModel { QuestionId = "10", Question = "In tennis, what piece of fruit is found at the top of the men’s Wimbledon trophy?", Answer = "Pineapple", Answers = { "Apple", "Orange",  "Pear", "Pineapple" } });
            questionList.Add(new QuestionModel { QuestionId = "11", Question = "What is the average male height in the netherlands (give your answer as: ###  e.g.: 152)", Answer = "183" });
            questionList.Add(new QuestionModel { QuestionId = "12", Question = "What is Calvin's height (give your answer as: ###  e.g.: 152)", Answer = "164" });
            questionList.Add(new QuestionModel { QuestionId = "13", Question = "Which brand is Calvin's car", Answer = "Lancia", Answers = { "Dacia", "Fiat", "Lancia", "Tesla" } });
            questionList.Add(new QuestionModel { QuestionId = "14", Question = "What is Calvin's favorite sex position", Answer = "Missionary", Answers = { "Missionary", "Doggy", "Cow girl" } });
            questionList.Add(new QuestionModel { QuestionId = "15", Question = "What is the capiptal of Australia", Answer = "Canberry", Answers = { "Perth", "Sydney", "Canbery", "Melbourne" } });
            questionList.Add(new QuestionModel { QuestionId = "16", Question = "I have a mouth, but I can't speak. I have a bed, but I won't sleep. I can run, but don't have legs. What am I? (single word answer)", Answer = "river" });
            questionList.Add(new QuestionModel { QuestionId = "17", Question = "What year did the first Star Wars film come out in theaters? ", Answer = "1977",  Answers = {"1973", "1975", "1977", "1979" } });
            questionList.Add(new QuestionModel { QuestionId = "18", Question = "Which chess piece can move the most spaces in any direction? ", Answer = "The queen", Answers = {"The rook", "The knight", "The king", "The queen" } });
            questionList.Add(new QuestionModel { QuestionId = "19", Question = "What is the most populated city in Europe", Answer = "Istanbul", Answers = { "Istanbul", "London", "Moscow", "Paris" } });
            return questionList;
        }
    }
}
