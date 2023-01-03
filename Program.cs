string ask(string question)
{
    Console.Write(question);
    return Console.ReadLine();
}

int M = int.Parse(ask("Введите количеcтво строк: "));
string[] strings = new string[M];
for (int i = 0; i < strings.Length; i++) strings[i] = ask($"Введите строку №{i + 1}: ");

List<string> output = new List<string>();

for (int i = 0; i < strings.Length; i++)
{
    int len = strings[i].Length;
    if (len <= 3)
    {
        output.Add(strings[i]);
    }
}

Console.WriteLine("[{0}]", string.Join(", ", output));