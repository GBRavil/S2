Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
Check(number);
void Check(int n) {
    if (n%10 == n/10000%10 && n/10%10 == n/1000%10) {
        Console.WriteLine("Число прошло проверку на палиндромом");
    } else {
        Console.WriteLine("Число не прошло проверку на палиндромом");
    }
}