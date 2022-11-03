// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
string a = Console.ReadLine();
char[] b = a.ToCharArray();
if (b.Length>2){
    string c = a+" -> "+b[2];
    Console.Write(c);
}
else{
    string c = a+" -> "+"Третьей цифры нет";
    Console.Write(c);
}
