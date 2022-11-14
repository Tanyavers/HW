// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[,] {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

int n = array.GetLength(0);
int m = array.GetLength(1);
float[] a = new float[m];
for(int i = 0; i<m; i++){
    float b = 0;
    for(int j = 0; j<n; j++){
        b = b+(int)array.GetValue(j,i);
    }
    a[i] = b/n;
}
Console.Write(string.Join("; ", a));
