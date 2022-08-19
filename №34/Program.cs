Console.WriteLine ("Введите количество элементов Вашего массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] ar = new int [N];
for (int i = 0; i < N; i++)
{
    ar[i] = new Random().Next(100, 1000);
}
Console.Write("Вот произвольные трехзначные числа из Вашего массива: ");
for (int i = 0; i < N; i++)
{
   Console.Write(ar[i] + " "); 
}
int count = 0;
int j = 0;
while (j<ar.Length)
{
    if ( ar[j] % 2 == 0)
    {
        count++;
        j++;
    }
    else
    {
        j++;
    }
}
Console.Write("Количество четных чисел в Вашем массиве = ");
Console.WriteLine(count);