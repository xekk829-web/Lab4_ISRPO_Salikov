Console.WriteLine("Привет!");
Console.WriteLine("Меню:");
Console.WriteLine("1. Показать ФИО");
Console.WriteLine("2. Покащать группу");
Console.WriteLine("3. Показать текущую дату и время");
Console.WriteLine("4. Выйти");
Console.Write("Выберите операцию (1-4): ");
string choice = Console.ReadLine();
switch (choice) {
case "1":
    Console.WriteLine("Меня зовут Саликов Аскар Рустамович.");
    break;
case "2":
    Console.WriteLine("Я из группы ИСП-241.");
    break;
case "3":
    DateTime now = DateTime.Now;
    Console.WriteLine($"Сейчас {now:dd.MM.yyyy HH:mm:ss}.");
    break;
case "4":
    Console.WriteLine("До свидания!");
    break;
default:
    Console.WriteLine("Проверьте правильность ввода (1-4).");
    break;
}