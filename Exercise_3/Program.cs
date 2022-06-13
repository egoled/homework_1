// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число ");
string StrNumber = Console.ReadLine();
int Num = int.Parse (StrNumber);
if (Num%2==0)
{
    Console.WriteLine ("Число четное");
}
else
{
    Console.WriteLine ("Число нечетное");
};
