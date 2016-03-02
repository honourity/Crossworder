using Data.Interfaces;
using Data.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Data.Repositories
{
    public class PuzzleRepository : IPuzzleRepository
    {
        public Puzzle GetPuzzle()
        {
            //temp sample puzzle
            var puzzle = ReadPuzzleFromFile("SampleData\\puzzle1.json");

            return puzzle;
        }

        /// <summary>
        /// The format for the puzzle file is:
        /// 2D Json array
        /// "key" is integer value of word key number
        /// "enabled" is whether the cell is usable or blacked out
        /// e.g. 1x1 puzzle with a single 1 letter word: [[{"key":1,"enabled":1}]]
        /// </summary>
        /// <returns>Data.Models.Puzzle</returns>
        private Puzzle ReadPuzzleFromFile(string filename)
        {
            dynamic jsonPuzzle = JsonConvert.DeserializeObject(File.ReadAllText(filename));
            int puzzleSize = jsonPuzzle.board.Count;

            var puzzle = new Puzzle();
            puzzle.Board = new Cell[puzzleSize, puzzleSize];

            int i = 0;
            int j = 0;

            while (i < puzzleSize)
            {
                while (j < puzzleSize)
                {
                    puzzle.Board[i, j] = new Cell();
                    puzzle.Board[i, j].Enabled = ((jsonPuzzle.board[i][j].enabled != null) && (jsonPuzzle.board[i][j].enabled == 1));
                    puzzle.Board[i, j].WordID = ((jsonPuzzle.board[i][j].key != null)) ? jsonPuzzle.board[i][j].key : null;
                    j++;
                }

                j = 0;
                i++;
            }

            puzzle.Words = new List<Word>();

            foreach(dynamic jsonWord in jsonPuzzle.words.across)
            {
                Word word = new Word();
                word.Direction = WordDirection.Across;
                word.Hint = jsonWord.word;
                word.Key = jsonWord.key;
                word.Length = jsonWord.length;
                puzzle.Words.Add(word);
            }

            foreach (dynamic jsonWord in jsonPuzzle.words.down)
            {
                Word word = new Word();
                word.Direction = WordDirection.Down;
                word.Hint = jsonWord.word;
                word.Key = jsonWord.key;
                word.Length = jsonWord.length;
                puzzle.Words.Add(word);
            }

            return puzzle;
        }
    }
}