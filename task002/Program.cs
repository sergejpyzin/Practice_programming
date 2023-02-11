Console.Write("Введите номер дня недели: ");
int answer = Convert.ToInt32(Console.ReadLine());
string day = "";

string [] days = new string [] {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
if (answer < 1 || answer > 7) {
    Console.WriteLine("Будьте внимательными. Неправильный номер дня недели.");
} else {
    day = days [answer - 1];
    Console.WriteLine (day);
}