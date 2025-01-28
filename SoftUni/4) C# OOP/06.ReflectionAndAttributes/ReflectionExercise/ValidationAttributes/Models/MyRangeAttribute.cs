namespace ValidationAttributes.Models
{
    using System.Reflection;

    public class MyRangeAttribute : MyValidationAttribute
    {
        private int _minValue;
        private int _maxValue;

        public MyRangeAttribute(int minValue, int maxValue) 
        {
            _maxValue = maxValue;
            _minValue = minValue;
        }

        public override bool IsValid(object obj)
        {
            var type = obj.GetType();

            var ctor = type.GetConstructor(new[] { typeof(string), typeof(int)});
            var secondParameter = ctor.GetParameters().TakeLast(1);

           

            if (secondParameter.comp < _minValue)
            {

            }
        }
    }
}
