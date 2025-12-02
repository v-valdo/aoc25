using tools;

// estrella uno
string filepath = "input.txt";
string[] input = Parser.GetInput(filepath);

int position = 50;
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
Console.WriteLine("estrella numero uno:" + zeroes);

int goodZeroes = 0;
int goodPosition = 50;
int oldPos = 0;

// estrella numeros dosos grandiosos
foreach (var line in input)
{
    int currentMove = int.Parse(line[1..]);
    oldPos = goodPosition;

    bool left = line[0] == 'L';
    bool crossedZero = false;

    if (oldPos == 0)
    {
        if (currentMove >= 100)
        {
            goodZeroes += currentMove / 100;
            crossedZero = true;
        }
    }
    else
    {
        switch (left)
        {
            case true:
                {
                    if (currentMove > oldPos)
                    {
                        goodZeroes++;
                        goodZeroes += (currentMove - oldPos) / 100;
                        crossedZero = true;
                    }
                }
                break;
            case false:
                {
                    if (currentMove > 99 - oldPos)
                    {
                        goodZeroes++;
                        goodZeroes += (currentMove - (100 - oldPos)) / 100;
                        crossedZero = true;
                    }
                }
                break;
        }
    }

    switch (left)
    {
        case true:
            goodPosition -= int.Parse(line[1..]);
            break;
        case false:
            goodPosition += int.Parse(line[1..]);
            break;
    }

    if (goodPosition < 0 || goodPosition > 99)
    {
        goodPosition = ((goodPosition % 100) + 100) % 100;
    }
    if (goodPosition == 0 && !crossedZero) goodZeroes++;

}
WriteLine("STERN ZWEI : " + goodZeroes);

