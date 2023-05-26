// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (10000 > number || number >= 100000)
{
   Console.WriteLine("Введено не пятизначное число. Попробуй еще раз"); 
}

else if (10000 <= number || number < 100000)
{
    string num = number.ToString();

    if(num[0] == num[4] && num[1] == num[3]){

        Console.WriteLine("Число является полиндромом");
    }
        
    else {
        Console.WriteLine("Число не является полиндромом");
    }
        
}

