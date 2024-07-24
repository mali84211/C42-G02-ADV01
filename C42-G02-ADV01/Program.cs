using static C42_G02_ADV01.Range_T;

namespace C42_G02_ADV01
{
    internal class Program
    {
        #region 1
        static void Main()
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSortOptimized(array);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }
        static void BubbleSortOptimized(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        #endregion

        #region 2
        public static void Main(string[] args)
        {
            Range<int> intRange = new Range<int>(1, 10);
            Console.WriteLine("Is 5 in range: " + intRange.IsInRange(5)); 
            Console.WriteLine("Length of range: " + intRange.Length());   

            Range<double> doubleRange = new Range<double>(1.5, 10.5);
            Console.WriteLine("Is 7.5 in range: " + doubleRange.IsInRange(7.5)); 
            Console.WriteLine("Length of range: " + doubleRange.Length());
        }
        #endregion
    }
}
