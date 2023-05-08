namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var randomSongs = Console.ReadLine().Split(", ");

            var playlist = new Queue<string>(randomSongs);

            while (true)
            {                
                if (playlist.Any())
                {
                    var command = Console.ReadLine();

                    if (command.StartsWith("Play"))
                    {
                        playlist.Dequeue();
                    }
                    else if (command.StartsWith("Add"))
                    {
                        var song = command.Substring(4);

                        if (playlist.Contains(song) == false)
                        {
                            playlist.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                    }
                    else if (command.StartsWith("Show"))
                    {
                        if (playlist.Any())
                        {
                            Console.WriteLine(string.Join(", ", playlist));
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
            }
        }
    }
}