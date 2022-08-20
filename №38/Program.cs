Console.WriteLine ("Введите количество элементов Вашего массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double [] ar = new double [N];
Random r = new Random();
for (int i = 0; i < N; i++)
{
    ar[i] = r.Next (-1000, 1000) / 10.00;
}
Console.Write("Вот произвольные числа, которыми заполнен Ваш массив: ");
for (int i = 0; i < N; i++)
{
   Console.Write(ar[i] + " "); 
}
int j = 0;
double max = ar[j];
while (j<ar.Length)
{
    if (ar[j] > max)
    {
        max = ar[j];
        j++;
    }
    else 
    {
        j++;
    }
}
Console.Write("Максимальный элемент Вашего массива = ");
Console.WriteLine(max);
int k = 0;
double min = ar[k];
while (k<ar.Length)
{
    if (ar[k] < min)
    {
        min = ar[k];
        k++;
    }
    else 
    {
        k++;
    }
}
Console.Write("Минимальный элемент Вашего массива = ");
Console.WriteLine(min);
double dif = max - min;
Console.Write("Разница между максимальным и минимальным элементами Вашего массива = ");
Console.WriteLine(dif);
