using Data.Interfaces;
using System;

namespace Crossworder
{
    class Program
    {
        static void Main(string[] args)
        {
            IPuzzleRepository puzzleRepository = new Data.Repositories.PuzzleRepository();

            var puzzle = puzzleRepository.GetPuzzle();

            Console.ReadKey();
        }
    }
}
