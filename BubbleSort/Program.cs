using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe elementow: ");
            int.TryParse(Console.ReadLine(), out int howManyElements);

            int[] arrayOfEnteredElements = new int[howManyElements];

            for (int i = 0; i < arrayOfEnteredElements.Length; i++)
            {
                Console.WriteLine("Podaj nastepny element: ");
                bool element = int.TryParse(Console.ReadLine(), out int nextElement);
                arrayOfEnteredElements[i] = nextElement;
            }

            for (int j = 0; j < arrayOfEnteredElements.Length; j++)
            {
                for (int i = 0; i < arrayOfEnteredElements.Length -1; i++)
                {
                    if (arrayOfEnteredElements[i] > arrayOfEnteredElements[i+1])
                    {
                        int temporary = arrayOfEnteredElements[i];
                        arrayOfEnteredElements[i] = arrayOfEnteredElements[i+1];
                        arrayOfEnteredElements[i+1] = temporary;
                    }
                }

            }

            for (int i = 0; i < arrayOfEnteredElements.Length; i++)
            {
                Console.Write($"{arrayOfEnteredElements[i]} ");
            }

        }
    }
}
