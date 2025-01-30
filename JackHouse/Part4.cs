using System.Collections.Immutable;

namespace JackHouse
{
    internal class Part4
    {
        public ImmutableList<string> Poem = [];
        public ImmutableList<string> AddPart(ImmutableList<string> strings)
        {
            var poem = new List<string>()
            {
                "Вот кот,",
                "Который пугает и ловит синицу,",
                "Которая часто ворует пшеницу,",
                "Которая в темном чулане хранится",
                "В доме,",
                "Который построил Джек.\r\n"
            };
            Poem = strings.AddRange(poem);
            return Poem;
        }
    }
}
