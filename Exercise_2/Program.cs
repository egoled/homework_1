// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите первое число > ");
string StringOne = Console.ReadLine ();
int One = int.Parse (StringOne);

Console.WriteLine("Введите второе число > ");
string StringTwo = Console.ReadLine ();
int Two = int.Parse (StringTwo);

Console.WriteLine("Введите третье число > ");
string StringThree = Console.ReadLine ();
int Three = int.Parse (StringThree);
int max = One;
if (max == Two && max == Three &&  Two == Three)
{
    Console.WriteLine("Числа должны быть разными =)");  
};
if (max < Two)
{
    max = Two;
};
if (max < Three)
{
    max = Three;
};
Console.WriteLine ("Самое большое число " +max);