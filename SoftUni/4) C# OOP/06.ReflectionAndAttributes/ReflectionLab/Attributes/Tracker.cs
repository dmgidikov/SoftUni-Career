namespace Attributes
{
    using System.Reflection;

    public class Tracker
    {
        public static void PrintMethodsByAuthor()
        {
            var targetClass = typeof(StartUp);

            var allMethods = targetClass.GetMethods(
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Static |
                BindingFlags.Instance);

            foreach (var method in allMethods)
            {
                if (method.CustomAttributes.Any(x => x.AttributeType == typeof(AuthorAttribute)))
                {
                    var attributes = method.GetCustomAttributes(false);

                    foreach (AuthorAttribute attribute in attributes)
                    {
                        Console.WriteLine($"{method.Name} is written by {attribute.Name}");
                    }
                } 
            }
        }
    }
}
