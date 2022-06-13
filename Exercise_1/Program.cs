//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число ");
string FirstNumber = Console.ReadLine(); 
int First = int.Parse(FirstNumber);
Console.WriteLine("Введите второе число ");
string ScndNumber = Console.ReadLine();
int Scnd = int.Parse(ScndNumber);

if (First > Scnd)
{
    Console.WriteLine ("Первое больше " + First);
}
if (First < Scnd)
{
    Console.WriteLine ("Второе больше " + Scnd);
};
if (First == Scnd)
{
    Console.WriteLine ("Числа должны быть разными, попробуйте еще раз =)");
};