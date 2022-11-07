using System;

Console.WriteLine("введите номер дня недели");

int a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1:
    Console.WriteLine(day.MONDAY);
        break;
    case 2:
    Console.WriteLine(day.TUESDAY);
        break;
    case 3:
    Console.WriteLine(day.WEDNESDAY);
        break;
    case 4:
    Console.WriteLine(day.THURSDAY);
        break;
    case 5:
        Console.WriteLine(day.FRIDAY);
        break;
    case 6:
    Console.WriteLine(day.SATURDAY);
        break;
    case 7:
    Console.WriteLine(day.SUNDAY);
        break;
    default:
    Console.WriteLine("такого дня нет");
        break;
}

enum day
{
    MONDAY ,
    TUESDAY ,
    WEDNESDAY ,
    THURSDAY ,
    FRIDAY ,
    SATURDAY,
    SUNDAY
}

