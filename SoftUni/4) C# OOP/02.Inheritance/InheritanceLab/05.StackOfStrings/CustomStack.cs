namespace _05.StackOfStrings
{
    public class CustomStack : Stack<string>
    {
        public bool IsEmpty()
        {
            var check = this.Count == 0 ? true : false; 
            return check;
        }

        public void AddRange(Stack<string> strings)
        {
            foreach (var item in strings)
            {
                this.Push(item);
            }
        }
    }
}