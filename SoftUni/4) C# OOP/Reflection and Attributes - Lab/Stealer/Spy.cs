using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{ 
    public class Spy
    {
        private string @namespace = "Stealer";

        public string StealFieldInfo(string investigatingClass, params string[] requestedFields)
        {
            var classType = Type.GetType($"{this.@namespace}.{investigatingClass}");

            var classFields = classType.GetFields
                (BindingFlags.Instance
                | BindingFlags.Static
                | BindingFlags.NonPublic
                | BindingFlags.Public);

            StringBuilder sb = new StringBuilder();

            var classInstance = Activator.CreateInstance(classType, new object[] { });

            sb.AppendLine($"Class under investigation: {investigatingClass}");

            foreach (var field in classFields.Where(f => requestedFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }

        [Obsolete]
        public string AnalyzeAcessModifiers(string className)
        {
            var classType = Type.GetType($"{this.@namespace}.{className}");

            var classFields = classType.GetFields
                (BindingFlags.Public
                | BindingFlags.Instance
                | BindingFlags.Static);

            var classPublicMethods = classType.GetMethods
                (BindingFlags.Public
                | BindingFlags.Instance);

            var classNonPublicMethods = classType.GetMethods
               (BindingFlags.NonPublic
               | BindingFlags.Instance);

            var sb = new StringBuilder();

            foreach (var field in classFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (var method in classNonPublicMethods.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            foreach (var method in classPublicMethods.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }

            return sb.ToString().Trim();
        }

        public string RevealPrivateMethods(string className)
        {
            var classType = Type.GetType($"{this.@namespace}.{className}");

            var privateMethods = classType.GetMethods
                (BindingFlags.Instance
                | BindingFlags.NonPublic);

            var sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (var method in privateMethods)
            {
                sb.AppendLine(method.Name);
            }

            return sb.ToString().Trim();
        }

        public string GetSettersAndGetters(string className)
        {
            var classType = Type.GetType($"{this.@namespace}.{className}");

            var setters = classType.GetMethods
                (BindingFlags.Public
                | BindingFlags.NonPublic
                | BindingFlags.Instance
                | BindingFlags.Static).Where(x => x.Name.StartsWith("set"));

            var getters = classType.GetMethods
               (BindingFlags.Public
               | BindingFlags.NonPublic
               | BindingFlags.Instance
               | BindingFlags.Static).Where(x => x.Name.StartsWith("get"));

            var sb = new StringBuilder();

            foreach (var method in getters)
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (var method in setters)
            {
                sb.AppendLine($"{method.Name} will set field of {method.ReturnParameter.ParameterType}");
            }

            return sb.ToString().Trim();
        }
    }
}
