using System;

namespace BinarySearch
{
    class Program
    {
        public static int BinarySearch(int[] array, int value)
        {
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var middle = (left + right) / 2;
                if (array[middle] < value)
                    left = middle + 1;
                else
                    right = middle;
            }
            if (right < 0 || array[left] != value)
                return -1;
            return left;
        }

        static void Main(string[] args)
        {
            TestElementOfFive();
            TestNegativeNumbers();
            TestNonExistentElement();
            TestRepeatingElement();
            TestEmptyArray();
            TestBigArray();
            Console.ReadKey();
        }

        private static void TestElementOfFive()
        {
            //Тестирование поиска в массиве из 5 чисел
            var numbers = new[] { 1, 3, 7, 9, 11 };
            if (BinarySearch(numbers, 9) != 3)
                Console.WriteLine("! Поиск не нашёл число 9 среди чисел { 1, 3, 7, 9, 11 }");
            else
                Console.WriteLine("Поиск одного элемента в массиве из 5 элементов работает корректно.");
        }

        private static void TestNegativeNumbers()
        {
            //Тестирование поиска в отрицательных числах
            var negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -3) != 2)
                Console.WriteLine("! Поиск не нашёл число -3 среди чисел { -5, -4, -3, -2 }");
            else
                Console.WriteLine("Поиск среди отрицательных чисел работает корректно.");
        }

        private static void TestNonExistentElement()
        {
            //Тестирование поиска отсутствующего элемента
            var negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -1) >= 0)
                Console.WriteLine("! Поиск нашёл число -1 среди чисел { -5, -4, -3, -2 }");
            else
                Console.WriteLine("Поиск отсутствующего элемента работает корректно.");
        }

        private static void TestRepeatingElement()
        {
            //Тестирование поиска элемента, повторяющегося несколько раз
            var numbers = new[] { 1, 3, 3, 4, 4, 4, 5, 8 };
            if (BinarySearch(numbers, 4) != 3)
                Console.WriteLine("! Поиск не нашёл число 4 среди чисел { 1, 3, 3, 4, 4, 4, 5, 8 } или нашел не первое вхождение.");
            else
                Console.WriteLine("Поиск элемента, повторяющегося несколько раз, работает корректно.");
        }

        private static void TestEmptyArray()
        {
            //Тестирование поиска в пустом массиве
            var numbers = new int[0];
            if (BinarySearch(numbers, 1) > 0)
                Console.WriteLine("! Поиск нашёл число 1 в пустом массиве.");
            else
                Console.WriteLine("Поиск элемента в пустом массиве работает корректно.");
        }

        private static void TestBigArray()
        {
            //Тестирование поиска в массиве из 100001 элемента
            var numbers = new int[100001];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i;
            if (BinarySearch(numbers, 78456) != 78456)
                Console.WriteLine("! Поиск не нашёл число 78456 в массиве, состоящих из 100000 первых натуральных чисел и 0.");
            else
                Console.WriteLine("Поиск элемента в массиве из 100001 элемента работает корректно.");
        }
    }
}