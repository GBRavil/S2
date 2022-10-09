Console.WriteLine("Введите первое число!");
String s1 = Console.ReadLine();
Console.WriteLine("Введите второе число!");
String s2 = Console.ReadLine();
Number(s1, s2);
void Number (string n1, string n2) {
    int i1 = Convert.ToInt32(n1);
    int i2 = Convert.ToInt32(n2);
    i1 = i1*i1;
    if(i1==i2) {
    Console.WriteLine("Первое число является квадратом второго числа");
    } else {
    Console.WriteLine("Первое число не является квадратом второго числа");
    } 
}