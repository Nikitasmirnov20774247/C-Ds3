Console.Write("Введите целое число N больше 1: ");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num > 1)
{
    Console.WriteLine($"Таблица кубов чисел от 1 до {Num}: ");
    for (int i = 0; i < Num; i++)
    {
        Console.Write(Math.Pow(i+1, 3) + ", ");
    }
}
else
{
    Console.WriteLine("!! Введёное число меньше или равно еденице !!");
}