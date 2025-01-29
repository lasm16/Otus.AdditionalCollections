using System.Collections.Immutable;

namespace JackHouse
{
    internal class Part2
    {
        public ImmutableList<string> Poem = 
        [
            "А это пшеница,",
            "Которая в темном чулане хранится",
            "В доме,",
            "Который построил Джек.\r\n"
        ];
        public void AddPart(ImmutableList<string> strings) => Poem.AddRange(strings);
    }
}
