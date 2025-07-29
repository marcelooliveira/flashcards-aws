namespace Web.Model
{
    public class QuestionOption
    {
        public QuestionOption(string text)
        {
            Text = text;
        }

        public int Index { get; set; }
        public string Text { get; set; }
        public bool IsSelected { get; set; }
        public bool IsCorrect { get; set; }
        public string Explanation { get; set; }
    }
}
