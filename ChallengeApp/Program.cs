// Dzień 5 - Tablice i Listy

List<string> dayOfWeeks = new List<string>
{
    "Poniedziałek",
    "Wtorek",
    "Środa",
    "Czwartek",
    "Piątek",
    "Sobota",
    "Niedziela"
};

for (var i = 0; i < dayOfWeeks.Count; i++)
    Console.WriteLine(dayOfWeeks[i]);

//foreach (var dayOfWeek in dayOfWeeks)