int [] week = {1, 2, 3, 4, 5, 6, 7};
Console.WriteLine("Введите номер дня недели");
String s1 = Console.ReadLine();
int number = Convert.ToInt32(s1);
if(number == week[5] || number == week[6]){      
    Console.WriteLine("Введеный день недели выходной");
} else if(number > week[6]) {
    Console.WriteLine("Нет такого дня недели");
} else {
    Console.WriteLine("Введеный день недели не выходной");
}