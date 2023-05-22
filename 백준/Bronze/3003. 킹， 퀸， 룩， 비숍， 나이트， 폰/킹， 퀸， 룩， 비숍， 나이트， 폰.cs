string[] stringNumbers = Console.ReadLine().Split(' ');

int[] numbers = new int[stringNumbers.Length];

for (int i = 0; i < stringNumbers.Length; i++)
{
    numbers[i] = int.Parse(stringNumbers[i]);
}

int[] compareNumber = new int[6] { 1, 1, 2, 2, 2, 8 };

int[] answer = new int[6];

for (int i = 0; i < numbers.Length; i++)
{
    answer[i] = compareNumber[i] - numbers[i];
}

foreach(var item in answer)
{
    Console.Write(item + " ");
}