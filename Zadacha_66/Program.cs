Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumMN(int M, int N)
{
    int sum = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        sum = M + SumMN(M, N);
        return sum;
    }   
}
 Console.WriteLine("Сумма чисел " + SumMN(M - 1, N));