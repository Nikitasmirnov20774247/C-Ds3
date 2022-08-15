Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string Numberfive = Convert.ToString(num);

if (Numberfive.Length > 5 || Numberfive.Length < 5)
{
    Console.WriteLine("!!Ведённое число не является пятизначным!!");
    return;
}

if (Numberfive[0] == Numberfive[4] || Numberfive[1] == Numberfive[3])
{
    Console.Write($"Введённое число: {num} = Палиндром? - ДА");
}
else
{
    Console.Write($"Введённое число: {num} = Палиндром? - НЕТ");
}