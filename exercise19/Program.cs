// Программа, которая на вход принимает пятизначное число и проверяет, 
// не является ли оно палиндромом.

Console.Clear();
int[] array = {1, 5, 5, 5, 1 };

if(array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("палиндром!");
}
else
{
    Console.WriteLine("не палиндром!");
}

