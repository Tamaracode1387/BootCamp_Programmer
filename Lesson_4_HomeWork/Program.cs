// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность 
// (сдвиг - циклический) на |K| элементов вправо, 
// если K – положительное и влево, если отрицательное.
// 	5
// 5 3 7 4 6
// 3
// 7 4 6 5 3

Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
int[] b = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите число: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите число К для сдвига: ");
int k = Convert.ToInt32(Console.ReadLine());
if (k > 0)
{
for (int i = 0; i < k; i++) 
    b[i] = a[n - k + i];     
for (int i = 0; i < n - k; i++)
    b[k + i] = a[i];
for (int i = 0; i < n; i++)
    Console.Write(b[i] + " ");
}
else
{
k = -k;
for (int i = 0; i < k; i++)
    b[n - k + i] = a[i];
for (int i = 0; i < n - k; i++)
    b[i] = a[k + i];
for (int i = 0; i < n; i++)
    Console.Write(b[i] + " ");
}