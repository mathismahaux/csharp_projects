int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

int employeeLevel2 = 100;
string employeeName2 = "John Smith";

string title2 = "";

switch (employeeLevel2)
{
    case 100:
    case 200:
        title2 = "Senior Associate";
        break;
    case 300:
        title2 = "Manager";
        break;
    case 400:
        title2 = "Senior Manager";
        break;
    default:
        title2 = "Associate";
        break;
}

Console.WriteLine($"{employeeName2}, {title2}");