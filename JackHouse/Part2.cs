using System.Collections.Immutable;

namespace JackHouse
{
    internal class Part2
    {
        public ImmutableList<string> Poem = [];
        public ImmutableList<string> AddPart(ImmutableList<string> strings)
        {
            var poem = new List<string>()
            {
                "А это пшеница,",
                "Которая в темном чулане хранится",
                "В доме,",
                "Который построил Джек.\r\n"
            };
            Poem = strings.AddRange(poem);
            return Poem;
        }
    }
}
