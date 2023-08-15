//Value pattern

string color = "r";

var result = color switch
{
    "r" => "red",
    "b" => "blue",
    "g" => "green",
    _ => "Unknown"
};

Console.WriteLine(result);

//Type pattern

int age = 20;
string name = "Rashmi";
var numbers = new int[] { 1, 2, 3, 4, 5 };
double salary = 20000.00;
List<string> cities = new List<string> {"Colombo", "Kandy", "Galle"};

object CheckType(object obj) => obj switch
{
    int => "Integer Type",
    string => "String Type",
    List<string> => "Generic string List",
    Array => "Array Type",
    _ => "Unknown"
};

Console.WriteLine(CheckType(age));
Console.WriteLine(CheckType(name));
Console.WriteLine(CheckType(numbers));
Console.WriteLine(CheckType(salary));
Console.WriteLine(CheckType(cities));

Console.ReadLine();
