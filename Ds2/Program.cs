Console.Write("Введите координату x для точки a: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y для точки a: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z для точки a: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x для точки b: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y для точки b: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z для точки b: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double formula = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
double Distance = Math.Round (formula, 2 );

Console.WriteLine($"Длина отрезка в 3D пространстве = {Distance}");