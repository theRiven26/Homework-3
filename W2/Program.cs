/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
 */
Console.WriteLine("enter point coordinates A: ");
Console.Write("enter coordinate x: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("enter coordinate y: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("enter coordinate z: ");
int zA = int.Parse(Console.ReadLine());

Console.WriteLine("enter point coordinates B: ");
Console.Write("enter coordinate x: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("enter coordinate y: ");
int yB = int.Parse(Console.ReadLine());
Console.Write("enter coordinate z: ");
int zB = int.Parse(Console.ReadLine());


double result = GetDistanceBetweemPoints(xA, yA, zA, xB, yB, zB);
Console.WriteLine(result);

double GetDistanceBetweemPoints(int xA, int yA, int zA, int xB, int yB, int zB)
{
	double x = Math.Pow(xB - xA, 2);
	double y = Math.Pow(yB - yA, 2);
	double z = Math.Pow(zB - zA, 2);
	return Math.Round(Math.Sqrt(x + y + z), 2);
}
