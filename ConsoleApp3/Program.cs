piano();
static void piano()
{
    Console.WriteLine("Список белых клавишь: Q, W, E, R, T, Y");
    Console.WriteLine("список чёрных клавишь: A, S, D, F, G");
    Console.WriteLine("Для выбора октавы нажмите: F1 - для первой октавы, F2 - для второй октавы, F3 - для третей октавы");
    Console.WriteLine("Для завершения программы нажмите клавишу Escape");
    Console.WriteLine("Выберите октаву:");
    ConsoleKeyInfo Key = Console.ReadKey();
    Console.WriteLine(Key.Key);
    switch (Key.Key)
    {
        case ConsoleKey.F1:
            FirtsOctave();
            break;
        case ConsoleKey.F2:
            SecondOctave();
            break;
        case ConsoleKey.F3:
            ThirdOctave();
            break;
        case ConsoleKey.Escape:
            Environment.Exit(0);
            break;
    }
}
static void FirtsOctave()
{
    int[] Octave = new int[]
        { 240, 270, 300, 310, 330, 350, 370, 400, 415, 450, 475, 500 };
    Note(Octave);
}
static void SecondOctave()
{
    int[] Octave = new int[]
        { 525, 550, 600, 625, 660, 700, 740, 800, 840, 880, 940, 1000 };
    Note(Octave);

}
static void ThirdOctave()
{
    int[] Octave = new int[]
        { 1050, 1100, 1150, 1200, 1250, 1300, 1400, 1500, 1550, 1650, 1750, 1850 };
    Note(Octave);
}
static void Note(int[] Octave)
{  
    while (true)
    {
        Console.WriteLine("Для возвращения в меню, нажмите клавишу Backspace");
        Console.WriteLine("Для завершения программы нажмите клавишу Escape");
        ConsoleKeyInfo Key = Console.ReadKey();
        Console.Clear();
        if (Key.Key == ConsoleKey.Q)
        {
            MakeSound(Octave[1]); 
        }
        if (Key.Key == ConsoleKey.A)
        {
            MakeSound(Octave[2]);
        }
        if (Key.Key == ConsoleKey.W)
        {
            MakeSound(Octave[3]);
        }
        if (Key.Key == ConsoleKey.S)
        {
            MakeSound(Octave[4]);
        }
        if (Key.Key == ConsoleKey.E)
        {
            MakeSound(Octave[5]);
        }
        if (Key.Key == ConsoleKey.D)
        {
            MakeSound(Octave[6]);
        }
        if (Key.Key == ConsoleKey.R)
        {
            MakeSound(Octave[7]);
        }
        if (Key.Key == ConsoleKey.F)
        {
            MakeSound(Octave[8]);
        }
        if (Key.Key == ConsoleKey.T)
        {
            MakeSound(Octave[9]);
        }
        if (Key.Key == ConsoleKey.G)
        {
            MakeSound(Octave[10]);
        }
        if (Key.Key == ConsoleKey.Y)
        {
            MakeSound(Octave[11]);
        }
        if (Key.Key == ConsoleKey.Backspace)
        {
            piano();   
        }
        if (Key.Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
        
    }
}
static void MakeSound(int frequency)
{
    Console.Beep(frequency, 100);
}