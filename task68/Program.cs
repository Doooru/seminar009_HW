// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 9
// m = 2, n = 3 -> A(m,n) = 29

// n + 1               при m = 0
// A(m-1,1)            при m > 0, n = 0
// A(m-1,A(m,n-1))     при m > 0, n > 0

int numberM = 2;
int numberN = 4;

int Ackerman (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
        {
            return Ackerman (m - 1, 1);
        }
        else
        {
            return Ackerman(m - 1, Ackerman(m , n - 1));
        }
    }
}

Console.Write(Ackerman(numberM, numberN));