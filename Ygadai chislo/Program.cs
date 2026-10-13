Random random = new Random();
int secretNumber = random.Next(1, 100);

int userGuess = 0;
int atters = 0;

Console.WriteLine("Я загадал число от 0 до 100! Попробуй отгадать!");

while (userGuess != secretNumber)
{
    Console.WriteLine("Ваша догадка!");
    userGuess = Convert.ToInt32(Console.ReadLine());
    atters++;

    if (userGuess < secretNumber)
    {
        Console.WriteLine("Загаданное число больше!");
    }
    else if (userGuess > secretNumber)
    {
        Console.WriteLine("Загаданное число меньше!");
    }

}
Console.WriteLine($"Поздравляю, вы отгадали число {secretNumber}");
Console.WriteLine("Конец программы");
Console.ReadLine();
















