using System.Collections;
using AdvC_01;

namespace Ass01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Testing Range<T>...");
            //var intRange = new Range<int>(5, 15);
            //Console.WriteLine($"Is 10 in range? {intRange.IsInRange(10)}"); // True
            //Console.WriteLine($"Is 20 in range? {intRange.IsInRange(20)}"); // False
            //Console.WriteLine($"Range Length: {intRange.Length()}"); // 10

            //var charRange = new Range<char>('a', 'z');
            //Console.WriteLine($"Is 'g' in range? {charRange.IsInRange('g')}"); // True
            //Console.WriteLine(); 
            #endregion

            #region Q2
            //Console.WriteLine("Testing Reverse ArrayList...");
            //ArrayList list = new ArrayList { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Original List: " + string.Join(", ", list.ToArray()));

            //ArrayListReverser.Reverse(list);
            //Console.WriteLine("Reversed List: " + string.Join(", ", list.ToArray()));
            //Console.WriteLine();

            #endregion

            #region Q3
            //Console.WriteLine("Testing GetEvenNumbers...");
            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            //var evenNumbers = ListProcessor.GetEvenNumbers(numbers);

            //Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
            //Console.WriteLine();

            #endregion

            #region Q4
            //Console.WriteLine("Testing FixedSizeList<T>...");
            //var fixedList = new FixedSizeList<string>(3);

            //try
            //{
            //    fixedList.Add("Hello");
            //    fixedList.Add("World");
            //    fixedList.Add("!");
            //    Console.WriteLine(fixedList.Get(0)); // Hello
            //    Console.WriteLine(fixedList.Get(1)); // World

            //    // Adding beyond capacity
            //    fixedList.Add("Overflow");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //try
            //{
            //    // Accessing invalid index
            //    Console.WriteLine(fixedList.Get(5));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //Console.WriteLine();

            #endregion

            #region Q5
            Console.WriteLine("Testing FirstNonRepeatedCharacter...");
            string input = "swiss";
            int index = StringProcessor.FirstNonRepeatedCharacter(input);

            Console.WriteLine(index != -1
                ? $"First non-repeated character is at index {index} ({input[index]})"
                : "No non-repeated character found.");
            Console.WriteLine();

            #endregion

        }
    }
}
