

//List<string> scores = [];
//Console.WriteLine("Vad heter du?");

//string name = Console.ReadLine();

//Console.WriteLine("Hur många poäng fick du?" + name);

List<string> scores = [];

for (int i = 0; i < 3; i++)
{
    
Console.WriteLine("Name:");
string name = Console.ReadLine();

Console.WriteLine("poäng:");
string points = Console.ReadLine();

scores.Add(name + " " + points);
}

foreach (string score in scores)
{
    Console.WriteLine(score);

}

Console.ReadLine();











