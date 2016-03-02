using System.Collections.Generic;

namespace Data.Models
{
    public class Puzzle
    {
        public Cell[,] Board { get; set; }

        public IList<Word> Words { get; set; }
    }
}
