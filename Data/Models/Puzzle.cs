using System.Collections.Generic;

namespace Data.Models
{
    public class Puzzle
    {
        public Cell[,] Board { get; set; }

        public Dictionary<int, Word> Words { get; set; }
    }
}
