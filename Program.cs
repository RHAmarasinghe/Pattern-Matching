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
