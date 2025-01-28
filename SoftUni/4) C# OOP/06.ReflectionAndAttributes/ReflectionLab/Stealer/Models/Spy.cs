namespace Stealer.Models
{
    using System.Text;
    using System.Reflection;

    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fieldsNames)
        {
            var sb = new StringBuilder();

            var currentPath = typeof(Spy).Namespace;
            var fullPath = $"{currentPath}.{className}";

            var targetType = Type.GetType(fullPath);

            sb.AppendLine($"Class under investigation: {targetType}");

            var classInstance = Activator.CreateInstance(targetType);

            var fields = targetType.GetFields(BindingFlags.Instance | BindingFlags.Static |
                BindingFlags.Public | BindingFlags.NonPublic);

            foreach (var field in fields.Where(f => fieldsNames.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            var sb = new StringBuilder();

            var currentPath = typeof(Spy).Namespace;
            var fullPath = $"{currentPath}.{className}";

            var classType = Type.GetType(fullPath);

            var fields = classType.GetFields(
                BindingFlags.Instance |
                BindingFlags.Public);

            var publicMethods = classType.GetMethods(
                BindingFlags.Instance |
                BindingFlags.Public);

            var nonPublicMethods = classType.GetMethods(
                BindingFlags.Instance |
                BindingFlags.NonPublic);

            foreach (var field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (var method in nonPublicMethods.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }

            foreach (var method in publicMethods.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString().Trim();
        }

        public string RevealPrivateMethods(string className)
        {
            var sb = new StringBuilder();

            var currentPath = typeof(Spy).Namespace;
            var fullPath = $"{currentPath}.{className}";

            var classType = Type.GetType(fullPath);

            var classPrivateMethods = classType.GetMethods(
                BindingFlags.Instance |
                BindingFlags.NonPublic);

            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (var privateMethod in classPrivateMethods)
            {
                sb.AppendLine($"{privateMethod.Name}");
            }

            return sb.ToString().Trim();
        }

        public string CollectGettersAndSetters(string className)
        {
            var sb = new StringBuilder();

            var currentPath = typeof(Spy).Namespace;
            var fullPath = $"{currentPath}.{className}";

            var classType = Type.GetType(fullPath);

            var classAllMethods = classType.GetMethods(
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Static);

            foreach (var method in classAllMethods.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (var method in classAllMethods.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}