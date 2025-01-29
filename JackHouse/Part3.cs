using System.Collections.Immutable;

namespace JackHouse
{
    internal class Part3
    {
        public ImmutableList<string> Poem = 
        [
            "А это веселая птица-синица,",
            "Которая часто ворует пшеницу,",
            "Которая в темном чулане хранится",
            "В доме,",
            "Который построил Джек.\r\n"
        ];
        public void AddPart(ImmutableList<string> strings) => Poem.AddRange(strings);
    }
}
