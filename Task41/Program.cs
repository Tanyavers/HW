// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите числа: ");
string a = Console.ReadLine();
string[] b = a.Split(",");
int c = 0;
int d;
if(a==string.Join(" ", b)){
    b=a.Split(" ");
}
for(int i = 0; i < b.Length; i++){
    if(int.TryParse(b[i],out d) && int.Parse(b[i])>0){
        c++;
    }
}
Console.Write("["+string.Join(", ", b)+"] -> "+c);
