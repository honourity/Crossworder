using Data.Interfaces;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class WordRepository : IWordRepostory
    {
        public IEnumerable<string> GetSimilarWords(string originalWord)
        {
            var similarWords = new List<string>();

            throw new System.NotImplementedException();

            return similarWords;
        }
    }
}
