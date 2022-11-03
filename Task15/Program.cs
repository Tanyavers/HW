// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите цифру: ");
string a = Console.ReadLine();
int b = int.Parse(a);
if (b==6 || b==7){
    string c = a+" -> Да";
    Console.Write(c);
}
else{
    string c = a+" -> Нет";
    Console.Write(c);
}
