namespace Web.Model
{
    public class Question
    {
        public string Text { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new();
        public List<int> CorrectOptions { get; set; } = new();
        public int? SelectedOption { get; set; } = null;
        public bool? WasCorrect { get; set; } = null;
    }
}
