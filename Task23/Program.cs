// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = 1;

while(number >= num)
{
    int result = num*num*num;
    Console.WriteLine(result);
    num++; 
}
