﻿string[] names = new string[] { "Leo Dzerzhinsky", "Joseph Lenin", "Felix Trotsky", "Vladimir Stalin" };
string[] occupations = new string[] { "cheif guard", "creative director", "icepick boy", "сheif executive" };
string[] salaries = new string[] { "35 000", "45 000", "30 000", "55 000" };

string[,] commandList = new string[8, 2]
{
    {"SeeCrew - ", "выводит досье всех сотрудников."}, //1
    {"AddFile - ", "добавяет к уже существующей базе досье."},//2
    {"RemoveFile - ","удаяет досье под номером, введённым пользователем через пробел после имени комнды."},//3
    {"FindByName - ","находит досье по фамилии и выводит его на экран."}, //4
    {"ShowBelow - ","суммирует все элементы массива на чётных позициях."}, //5
    {"ShowAll- ","показывает все досье с указанной должностью, " 
                                + "введённой пользователем через пробел после имени комнды."}, //6
    {"AverageRate - ","считает среднюю зарплату всех сотрудников"}, //7
    {"exit - ","завершает работу программы."} //8
};

bool atWork = true;
string currentNames = string.Empty;
string currentOccups = string.Empty;
string currentWagers = string.Empty;

while (atWork)
{
    Console.WriteLine($"Введите команду или help: ");
    string userCommand = Console.ReadLine();
    switch (userCommand)
    {
        case "help":
            Help(commandList);
            break;
        case "SeeCrew":
            SeeCrew(names, occupations, salaries);
            break;
        case "AddFile":
            Console.Write("Введите фамилию и имя сотрудника: ");
            string inputName = Console.ReadLine();
            Console.Write("Введите должность сотрудника: ");
            string inputOccup = Console.ReadLine();
            Console.Write("Введите зарплату сотрудника: ");
            string inputSalary = Console.ReadLine();
            break;
        case "exit":
            atWork = false;
            Console.WriteLine("Всего хорошего...");
            break;
        default:
            Console.WriteLine("Команда не распознана...");
            break;
    }
}


/*________________________METHODS__________________________*/

void Help(string[,] commandList)
{
    Console.WriteLine($"Список комманд:");
    for (int i = 0; i < commandList.GetLength(0); i++)
    {
        for (int j = 0; j < commandList.GetLength(1); j++)
        {
            Console.Write($"{commandList[i, j]}  ");
        }
        Console.WriteLine("");
    }
}

void SeeCrew(string[] name, string[] occup, string[] wager)
{
    for (int i = 0; i < name.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {name[i]} - {occup[i]} - {wager[i]}");
    }
    Console.WriteLine();
}


/*_____________ADD FILES & control zone_______start___________*/

string[] AddNames(string[] names, string input)
{
    string[] newName = new string[names.Length + 1];
    for (int i = 0; i < names.Length; i++)
    {
        newName[i] = names[i];
    }
    newName[newName.Length - 1] = input;
    return newName;
}

string[] AddOccup(string[] occup, string input)
{
    string[] newOccup = new string[occup.Length + 1];
    for (int i = 0; i < occup.Length; i++)
    {
        newOccup[i] = occup[i];
    }
    newOccup[newOccup.Length - 1] = input;
    return newOccup;
}

string[] AddSalary(string[] wager, string input)
{
    string[] newWager = new string[wager.Length + 1];
    for (int i = 0; i < wager.Length; i++)
    {
        newWager[i] = wager[i];
    }
    newWager[newWager.Length - 1] = input;
    return newWager;
}

/*_____________ADD FILES & control zone_______end___________*/