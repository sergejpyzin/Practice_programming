Console.Write ("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = numberB * numberB;

if (result == numberA) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}
