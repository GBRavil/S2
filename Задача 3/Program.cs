Console.WriteLine("Задайте номер четверти");
int number = Convert.ToInt32(Console.ReadLine());
Range(number);
void Range (int n) {
    if(n==1) {
        Console.WriteLine("Диапазон первой координатной четверти x > 0 и y > 0");
    } else if(n==2) {
        Console.WriteLine("Диапазон второй коорлинатной четверти x < 0 и y < 0");
    } else if(n==3) {
        Console.WriteLine("Диапазон третьей координатной четверти x > 0 и y < 0");
    } else if(n==4) {
        Console.WriteLine("Диапазон четвертой координатной четверти x < 0 и y > 0");
    }
}