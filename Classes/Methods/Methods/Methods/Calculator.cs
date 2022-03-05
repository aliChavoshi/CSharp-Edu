namespace Methods
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

    }
}
