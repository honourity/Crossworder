namespace Data.Models
{
    public enum WordDirection {
        Across,
        Down
    }

    public class Word
    {
        public WordDirection Direction { get; set; }

        public int Key { get; set; }

        public string Hint { get; set; }

        public int Length { get; set; }
    }
}
