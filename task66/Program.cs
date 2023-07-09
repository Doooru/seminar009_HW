// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM = 4;
int numberN = 8;

int Summa(int M, int N)
{
if (M == N) return M;
return Summa(M, N - 1) + N;
}

Console.Write(Summa(numberM, numberN));