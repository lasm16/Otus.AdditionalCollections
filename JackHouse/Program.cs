using System.Collections.Immutable;

namespace JackHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var poem = ImmutableList<string>.Empty;
            var part1 = new Part1();
            var part2 = new Part2();
            var part3 = new Part3();
            var part4 = new Part4();
            var part5 = new Part5();
            var part6 = new Part6();
            var part7 = new Part7();
            var part8 = new Part8();
            var part9 = new Part9();

            poem = part1.AddPart(poem);
            poem = part2.AddPart(poem);
            poem = part3.AddPart(poem);
            poem = part4.AddPart(poem);
            poem = part5.AddPart(poem);
            poem = part6.AddPart(poem);
            poem = part7.AddPart(poem);
            poem = part8.AddPart(poem);
            poem = part9.AddPart(poem);

            ShowLines(part1.Poem);
            ShowLines(part2.Poem);
            ShowLines(part3.Poem);
            ShowLines(part4.Poem);
            ShowLines(part5.Poem);
            ShowLines(part6.Poem);
            ShowLines(part7.Poem);
            ShowLines(part8.Poem);
            ShowLines(part9.Poem);
        }

        private static void ShowLines(IEnumerable<string> values)
        {
            foreach (var str in values)
            {
                Console.WriteLine(str);
            }
        }
    }
}
