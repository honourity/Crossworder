using Data.Models;
using System.IO;

namespace Data.Interfaces
{
    public class PuzzleRepository : IPuzzleRepository
    {
        public Puzzle GetNewPuzzle()
        {
            var puzzle = new Puzzle();

            //init sample puzzle
            //puzzle.Board[0, 0] = new Cell { Enabled = true, WordID = 1 };


            //...puzzle.Board[13,13]

            return puzzle;
        }

        private Puzzle ReadPuzzleFromFile()
        {
            //assuming 13x13 puzzle
            int width = 13;
            int height = 13;

            var path = "puzzle1.txt";
            var puzzle = new Puzzle();
            puzzle.Board = new Cell[width, height];

            using (StreamReader reader = new StreamReader(path))
            {
                int location = 0;

                while (reader.Peek() >= 0)
                {
                    switch ((char)reader.Read())
                    {
                        case ' ':
                            //its enabled, empty block
                            break;
                        case '.':
                            //its disabled block
                            break;
                        case '\n':
                            //new row in puzzle
                            break;
                        default:
                            //its enabled, with word key
                            break;
                    }
                }
            }

            return puzzle;
        }
    }
}