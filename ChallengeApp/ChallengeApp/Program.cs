string imię = "Ewa";
string płeć = "kobieta";
var wiek = 17;

if (płeć == "kobieta" && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (wiek == 33 && imię == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (płeć != "kobieta" && wiek < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
     else
{
    Console.WriteLine("Pełnoletnia kobieta");
}