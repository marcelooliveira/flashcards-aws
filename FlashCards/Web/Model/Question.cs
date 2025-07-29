namespace Web.Model
{
    public class Question
    {
        public string Text { get; set; } = string.Empty;
        public List<QuestionOption> QuestionOptions { get; set; } = new();
        public List<int> CorrectOptions { get; set; } = new();
        public List<int> SelectedOptions { get; set; } = new();
        public bool? WasCorrect { get; set; } = null;
        public bool IsLocked { get; set; }
    }
}
