namespace Web.Model
{
    public class QuestionOption
    {
        public QuestionOption(int index, string text, string img)
        {
            Index = index;
            Text = text;

            if (!string.IsNullOrWhiteSpace(img))
            {
                Img = $"Exams/{img}";
            }
        }

        public int Index { get; set; }
        public string Text { get; set; }
        public string Img { get; set; }
        public bool IsSelected { get; set; }
        public bool IsCorrect { get; set; }
        public string Explanation { get; set; }
        public string ShuffleGuid { get; set; }
    }
}
