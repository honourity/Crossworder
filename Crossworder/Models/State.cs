using Data.Models;

namespace Crossworder.Models
{
    public class State
    {
        public Puzzle Puzzle { get; set; }

        //todo - also contain some storage of heuristics for this state (how close to solved? etc)
    }
}
