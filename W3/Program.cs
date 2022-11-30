/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
 Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
 */
Console.Write("enter number: ");
int number = int.Parse(Console.ReadLine());
double[] myArr = new double[number];

GetSquaresOfNumbers(myArr, number);

PrintArray(myArr);

void GetSquaresOfNumbers(double[] myArr, int number)
{
	for (int i = 1; i <= number; i++)
	{
		myArr[i - 1] = Math.Pow(i, 3);
	}
}


void PrintArray(double[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine(array[i]);
	}
}