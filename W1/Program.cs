/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("enter a number: ");
string textRead = Console.ReadLine();
int numberLength = textRead.Length;
bool IsParse = int.TryParse(textRead, out int number);
if (!IsParse || numberLength < 2)
{
	Console.WriteLine("the text entered is not a number or can't be a palendrome");
	return;
}
int[] arrNum = new int[numberLength];
GetArrayOfNumber(arrNum, number);
bool result = IsPalidrome(arrNum);
if (result)
{
	Console.WriteLine("It's a palindrome");
}
else
{
	Console.WriteLine("It's not a palindrome");
}




void GetArrayOfNumber(int[] array, int number)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = number % 10;
		number /= 10;
	}
}

bool IsPalidrome(int[] array)
{
	for (int i = 0; i < array.Length / 2; i++)
	{
		if (arrNum[i] != arrNum[array.Length - i - 1])
		{
			return false;
		}
	}
	return true;
}


