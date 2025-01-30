using System.Collections.Immutable;

namespace JackHouse
{
    internal class Part1
    {
        public ImmutableList<string> Poem = [];
        public ImmutableList<string> AddPart(ImmutableList<string> strings)
        {
            var poem = new List<string>()
            {
                "Вот дом,",
                "Который построил Джек.\r\n"
            };
            Poem = strings.AddRange(poem);
            return Poem;
        }
    }
}
