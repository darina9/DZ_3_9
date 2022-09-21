Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());


string NatNum (int number1,int number2)
{
    if(number1<=number2) return $"{number1} "+ NatNum(number1+1,number2);
    else return string.Empty;
}
Console.WriteLine(NatNum(M,N));
