// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Switch Case");
start:
Console.WriteLine("Month Details \t \n");
Console.WriteLine("Enter a Month");
string month = Console.ReadLine();
switch (month)
{
    case "January":
    case "March":
    case "May":
    case "July":
    case "August":
    case "October":
    case "December":
        Console.WriteLine("The month of: " + month + " 31 days");
        break;
    case "April":
    case "June":
    case "September":
    case "November":
        Console.WriteLine("The month of: " + month + " 30 days");
        break;
    default:
        Console.WriteLine("Incorrect Choice");
        goto start;
}   