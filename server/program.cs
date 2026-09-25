using System.Runtime.InteropServices;
bool e = false;
while(!e){
    Console.WriteLine("Выберите что надо сделать:");
    Console.WriteLine("1. ФИО");
    Console.WriteLine("2. Группа");
    Console.WriteLine("3. Текущая дата и время");
    Console.WriteLine("4. Выход");
    string c = Console.ReadLine();
    switch (c)
    {
        case "1":
            Console.WriteLine("Бараков Олег Юрьевич");
            break;
        case "2":
            Console.WriteLine("ИСП-241");
            break;
        case "3":
            Console.WriteLine("25.09.2026, 18:14");
            break;
        case "4":
            e = true;
            break;
    }
}
Console.WriteLine("Нажмите любую кнопку");
Console.ReadKey();