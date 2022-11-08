// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
string a = Console.ReadLine();
int b = 0;
for(int i = 0; i < a.Length; i++){
    b = b + (int)Char.GetNumericValue(a[i]);
}
Console.Write(a + " -> "+ b);