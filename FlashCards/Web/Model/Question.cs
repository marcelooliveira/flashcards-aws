namespace Web.Model
{
    public class Question
    {
        public string Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public string Type { get; set; }
        public string Explanation { get; set; }
        public string Difficulty { get; set; }
        public int Points { get; set; }
        public List<string> Tags { get; set; }
        public List<QuestionOption> QuestionOptions { get; set; } = new();
        public List<int> CorrectOptions { get; set; } = new();
        public List<int> SelectedOptions { get; set; } = new();
        public bool? WasCorrect { get; set; } = null;
        public bool IsLocked { get; set; }
    }
}
