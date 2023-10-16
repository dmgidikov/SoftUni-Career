namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            using var wordsReader = new StreamReader(@"..\..\..\Files\words.txt");
            using var textReader = new StreamReader(@"..\..\..\Files\text.txt");
            using var writer = new StreamWriter(@"..\..\..\Files\output.txt");

            var keyWord = wordsReader.ReadToEnd().ToLower().Split();
            var text = textReader.ReadToEnd().ToLower().Split();
            
            var dict = new Dictionary<string, int>();

            foreach (var word in keyWord)
            {
                if (dict.ContainsKey(word) == false)
                {
                    dict[word] = 0;
                }

                dict[word]++;
            }

            foreach (var word in text)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
            }

            var sortedDict = dict.OrderByDescending(x => x.Value);

            foreach (var word in sortedDict)
            {
               writer.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}