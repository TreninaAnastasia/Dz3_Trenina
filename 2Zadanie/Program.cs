// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number; 
}
int x = Prompt ("Введите координату точки xA ");
int x1 = Prompt ("Введите координату точки xB ");
int y = Prompt ("Введите координату точки yA ");
int y1 = Prompt ("Введите координату точки yB ");
int z = Prompt ("Введите координату точки zA ");
int z1 = Prompt ("Введите координату точки zB ");
int n = 0;
FindSqr ( x, x1, y, y1, z, z1, n);
void FindSqr (int a, int b, int c, int d, int e, int f, double N)
{
    N = Math.Sqrt ((b - a) * (b - a) + (d - c) * (d - c) + (f - e) * (f - e));
    Console.WriteLine($" A ({x}, {y}, {z}); B ({x1}, {y1}, {z1}) -> {N} ");
}