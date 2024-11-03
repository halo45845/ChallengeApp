using System.Collections.Concurrent;

var name = "Ewa";
var sex = "female";
var age = 30;

if (sex == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if (sex != "female" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (sex != "female" && age == 10)
{
    Console.WriteLine("Chłopiec w wieku 10 lat");
}



