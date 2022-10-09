int [] week = {1, 2, 3, 4, 5, 6, 7};
Console.WriteLine("Введите номер дня недели");
String str = Console.ReadLine();

// if(number == week[5] || number == week[6]){      
//     Console.WriteLine("Введеный день недели выходной");
// } else if(number > week[6]) {
//     Console.WriteLine("Нет такого дня недели");
// } else {
//     Console.WriteLine("Введеный день недели не выходной");
// }
Weekend(week, str);
void Weekend (int[] w, string s){
    int n = Convert.ToInt32(s);
    if (n == w[5] || n == w[6]) {
        Console.WriteLine("Введеный день недели выходной");
    } else if(n > w[6]) {
        Console.WriteLine("Нет такого дня недели");
    } else {
        Console.WriteLine("Введеный день недели не выходной");
    }    
}