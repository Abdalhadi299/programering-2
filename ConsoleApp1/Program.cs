int p1Hp = 100;
int p2Hp = 100;

string p1Name = "Hussien";
string p2Name = "Abdalhadi";

while (p1Hp > 0 || p2Hp > 0)

{
    Console.WriteLine($"{p1Name}: {p1Hp}");
    Console.WriteLine($"{p2Name}: {p2Hp}");
    p2Hp -= Random.Shared.Next(10, 25); // Alex slår Hussien
    p1Hp -= Random.Shared.Next(10, 25); // Calin slår Abdalhadi
    Console.ReadLine();

}
if (p1Hp > 0)
{
    Console.WriteLine($"{p1Name} vann!");
}
else if (p1Hp <= 0 && p2Hp <= 0)
{
    Console.WriteLine("oavgjort!");

}
else
{
    Console.WriteLine($"{p2Name} vann!");
}


Console.ReadLine();

