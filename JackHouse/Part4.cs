using System.Collections.Immutable;

namespace JackHouse
{
    internal class Part4
    {
        public ImmutableList<string> Poem = 
        [
            "Вот кот,",
            "Который пугает и ловит синицу,",
            "Которая часто ворует пшеницу,",
            "Которая в темном чулане хранится",
            "В доме,",
            "Который построил Джек."
        ];
        public void AddPart(ImmutableList<string> strings) => Poem.AddRange(strings);
    }
}
