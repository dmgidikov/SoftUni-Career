using BaseHero.Core;

namespace BaseHero
{
    public class StartUp
    {
        public static void Main()
        {
            var engine = new Engine();

            try
            {
                engine.Run();
            }
            catch (Exception ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }
    }
}