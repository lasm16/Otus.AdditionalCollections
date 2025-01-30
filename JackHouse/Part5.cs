using System.Collections.Immutable;

namespace JackHouse
{
    internal class Part5
    {
        public ImmutableList<string> Poem = [];
        public ImmutableList<string> AddPart(ImmutableList<string> strings)
        {
            var poem = new List<string>()
            {
                "Вот пес без хвоста,",
                "Который за шиворот треплет кота,",
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
