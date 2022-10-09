Console.WriteLine("Введите первое число!");
String s1 = Console.ReadLine();
int i1 = Convert.ToInt32(s1);
i1 = i1*i1;
Console.WriteLine("Введите второе число!");
String s2 = Console.ReadLine();
int i2 = Convert.ToInt32(s2);
if(i1==i2) {
    Console.WriteLine("Первое число является квадратом второго числа");
} else {
    Console.WriteLine("Первое число не является квадратом второго числа");
} 