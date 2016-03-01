using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface IWordRepostory
    {
        IEnumerable<string> GetSimilarWords(string originalWord);
    }
}