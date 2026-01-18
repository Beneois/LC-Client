namespace LC.Client.Models
{
    public class QuizQuestion
    {
        public int WordId { get; set; }
        public string QuestionText { get; set; } = "";
        public string CorrectAnswer { get; set; } = "";
        public List<string> Choices { get; set; } = new();

        // Track the user's interaction
        public string? SelectedChoice { get; set; }
        public bool IsAnswered => !string.IsNullOrEmpty(SelectedChoice);
        public bool IsCorrect => SelectedChoice == CorrectAnswer;
    }
}
