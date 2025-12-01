using tools;

string filepath = "input.txt";
string[] input = Parser.GetInput(filepath);

int position = 50;
int maxPos = 99;
int minPos = 99;
int zeroes = 0;

foreach (var line in input)
{
    switch (line[0])
    {
        case 'L':
            position -= int.Parse(line[1..]);
            break;
        case 'R':
            position += int.Parse(line[1..]);
            break;
    }
    if (position < 0 || position > 99) position = ((position % 100) + 100) % 100;
    if (position == 0) zeroes++;
}
Console.WriteLine(zeroes);
