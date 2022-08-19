Console.WriteLine ("Введите количество элементов Вашего массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] ar = new int [N];
for (int i = 0; i < N; i++)
{
    ar[i] = new Random().Next(-1000, 1000);
}
Console.Write("Вот произвольные числа (в диапозоне от -1000 до +1000) из Вашего массива: ");
for (int i = 0; i < N; i++)
{
   Console.Write(ar[i] + " "); 
}
int sum = 0;
int j = 1;
while (j<ar.Length)
{
    sum = sum + ar[j];
    j = j + 2;
}
Console.Write("Сумма чисел, стоящих на нечетных позициях в Вашем массиве = ");
Console.WriteLine(sum);