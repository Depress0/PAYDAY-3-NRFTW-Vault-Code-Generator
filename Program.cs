bool incorrectInput = true;
string code = "";
while (incorrectInput){
    Console.WriteLine("Input the code (4):");
    code = Console.ReadLine();
    if (code != null && code != "" && code.Length == 4)
    {
        incorrectInput = false;
    }
}

int a = Convert.ToInt32(code.Substring(0,1));
int b = Convert.ToInt32(code.Substring(1,1));
int c = Convert.ToInt32(code.Substring(2,1));
int d = Convert.ToInt32(code.Substring(3));

Console.WriteLine($"{a}{b}{c}{d}");
Console.WriteLine($"{a}{b}{d}{c}");
Console.WriteLine($"{a}{c}{b}{d}");
Console.WriteLine($"{a}{c}{d}{b}");
Console.WriteLine($"{a}{d}{b}{c}");
Console.WriteLine($"{a}{d}{c}{b}");

Console.WriteLine($"{b}{a}{c}{d}");
Console.WriteLine($"{b}{a}{d}{c}");
Console.WriteLine($"{b}{c}{a}{d}");
Console.WriteLine($"{b}{c}{d}{a}");
Console.WriteLine($"{b}{d}{b}{c}");
Console.WriteLine($"{b}{d}{c}{b}");

Console.WriteLine($"{c}{a}{b}{d}");
Console.WriteLine($"{c}{a}{d}{b}");
Console.WriteLine($"{c}{b}{a}{d}");
Console.WriteLine($"{c}{b}{d}{a}");
Console.WriteLine($"{c}{d}{a}{b}");
Console.WriteLine($"{c}{d}{b}{a}");

Console.WriteLine($"{d}{a}{b}{c}");
Console.WriteLine($"{d}{a}{c}{b}");
Console.WriteLine($"{d}{b}{a}{c}");
Console.WriteLine($"{d}{b}{c}{a}");
Console.WriteLine($"{d}{c}{a}{b}");
Console.WriteLine($"{d}{c}{b}{a}");