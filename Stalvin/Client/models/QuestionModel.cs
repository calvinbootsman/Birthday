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
            questionList.Add(new QuestionModel { QuestionId = "0", Question = "question1", Answer = "A" });
            questionList.Add(new QuestionModel { QuestionId = "1", Question = "question2", Answer = "B", Answers = {"answer a", "answer b", "answer c" } });
            questionList.Add(new QuestionModel { QuestionId = "2", Question = "question3", Answer = "C" });
            questionList.Add(new QuestionModel { QuestionId = "3", Question = "question4", Answer = "D", Answers = { "answer a", "answer b", "answer c", "answer d" } });
            questionList.Add(new QuestionModel { QuestionId = "4", Question = "question5", Answer = "E", Answers = { "answer a", "answer b" } });
            questionList.Add(new QuestionModel { QuestionId = "5", Question = "question6", Answer = "F" });
            questionList.Add(new QuestionModel { QuestionId = "6", Question = "question7", Answer = "G" });
            questionList.Add(new QuestionModel { QuestionId = "7", Question = "question8", Answer = "H", Answers = { "answer a", "answer b", "answer c" } });
            questionList.Add(new QuestionModel { QuestionId = "8", Question = "question9", Answer = "I" });
            questionList.Add(new QuestionModel { QuestionId = "9", Question = "question10", Answer = "J", Answers = { "answer a", "answer b", "answer c", "answer d" } });
            questionList.Add(new QuestionModel { QuestionId = "10", Question = "question11", Answer = "K", Answers = { "answer a", "answer b" } });
            questionList.Add(new QuestionModel { QuestionId = "11", Question = "question12", Answer = "L" });
            questionList.Add(new QuestionModel { QuestionId = "12", Question = "question13", Answer = "M" });
            questionList.Add(new QuestionModel { QuestionId = "13", Question = "question14", Answer = "N", Answers = { "answer a", "answer b", "answer c" } });
            questionList.Add(new QuestionModel { QuestionId = "14", Question = "question15", Answer = "O" });
            questionList.Add(new QuestionModel { QuestionId = "15", Question = "question16", Answer = "P", Answers = { "answer a", "answer b", "answer c", "answer d" } });
            questionList.Add(new QuestionModel { QuestionId = "16", Question = "question17", Answer = "Q", Answers = { "answer a", "answer b" } });
            questionList.Add(new QuestionModel { QuestionId = "17", Question = "question18", Answer = "R" });
            questionList.Add(new QuestionModel { QuestionId = "18", Question = "question19", Answer = "S" });
            questionList.Add(new QuestionModel { QuestionId = "19", Question = "question20", Answer = "T", Answers = { "answer a", "answer b", "answer c" } });
            questionList.Add(new QuestionModel { QuestionId = "20", Question = "question21", Answer = "U" });
            questionList.Add(new QuestionModel { QuestionId = "21", Question = "question22", Answer = "V", Answers = { "answer a", "answer b", "answer c", "answer d" } });
            questionList.Add(new QuestionModel { QuestionId = "22", Question = "question23", Answer = "W", Answers = { "answer a", "answer b" } });
            questionList.Add(new QuestionModel { QuestionId = "23", Question = "question24", Answer = "X" });
            return questionList;
        }
    }


}
