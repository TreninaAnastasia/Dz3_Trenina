// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Prompt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number; 
}
int N = Prompt ("Введите пятизначное число: ");
int Lastnumber = N % 10;
int Firstnumber = N / 10000;
int Secondnumber = N / 1000 % 10;
int Fournumber = N / 10 % 10;
Palindrom ( Lastnumber, Firstnumber, Secondnumber, Fournumber );
void Palindrom ( int a, int b, int c, int d)
{
if ( a == b && c == d )  
{
    Console.WriteLine($" {N} -> да"); 
}
else 
{
    Console.WriteLine($" {N} -> нет");   
}
}