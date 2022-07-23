//Задача 25: Напишите цикл, который принимает
//на вход два числа (A и B) и возводит число A в 
// натуральную степень B.

double A, B;
double result = 1;
Console.WriteLine("Введите число A: ");
A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень, в которую нужно возвести число: ");
B = Convert.ToDouble(Console.ReadLine());
while (B > 0)
{ 
   result = result * A; 
   B --;
} 
{
    Console.WriteLine (result);
}

