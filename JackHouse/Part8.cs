﻿using System.Collections.Immutable;

namespace JackHouse
{
    internal class Part8
    {
        public ImmutableList<string> Poem = 
        [
            "А это ленивый и толстый пастух,",
            "Который бранится с коровницей строгою,",
            "Которая доит корову безрогую,",
            "Лягнувшую старого пса без хвоста,",
            "Который за шиворот треплет кота,",
            "Который пугает и ловит синицу,",
            "Которая часто ворует пшеницу,",
            "Которая в темном чулане хранится",
            "В доме,",
            "Который построил Джек."
        ];
        public void AddPart(ImmutableList<string> strings) => Poem.AddRange(strings);
    }
}
