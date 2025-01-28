using System.Collections.Immutable;

namespace JackHouse
{
    internal class Part1
    {
        public ImmutableList<string> Poem =
        [
            "Вот дом,",
            "Который построил Джек.\r\n"
        ];
        public void AddPart(ImmutableList<string> strings) => Poem.AddRange(strings);
    }
}
