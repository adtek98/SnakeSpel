using SnakeSpel;

        //Programmet skapar en spelplan, ett objekt i klassen Player och ett objekt
        //i klassen Food. Vidare har användaren möjlighet att styra objektet (ormen)
        //med hjälp av pilknapparna och ställa in det i önskad riktning. Om ormen 
        //landar på den position där Food-objektet finns, får användaren en poäng 
        //och ett nytt objekt av klassen Food dyker upp på fältet.


class Program 
{
    // Har lagt till så att maten har varierande utseende

    /// <summary>
    /// Kontrollerar konsolen för att se om en tangent på 
    /// tangentbordet har tryckts ned, returnerar den i så fall,
    /// annars NoName.
    /// </summary>
    static ConsoleKey ReadKeyIfExists() => Console.KeyAvailable ? Console.ReadKey(intercept: true).Key : ConsoleKey.NoName;

    /// <summary>
    /// Metoden där spelet initieras och loopen startas.
    /// </summary>
    static void Loop()
    {
        // Initialisera spelet
        const int frameRate = 5;
        GameWorld world = new GameWorld();
        ConsoleRenderer renderer = new ConsoleRenderer(world);      
            
        bool running = true;

        while (running) // Huvudloopen
        {
            // Ställa in starttiden för spelet.
            DateTime before = DateTime.Now;

            // Hantera knapptryckningar från användaren
            ConsoleKey key = ReadKeyIfExists();
            switch (key)
            {
                case ConsoleKey.Q:
                    running = false;
                    break;

                case ConsoleKey.UpArrow:
                    world.player.direction = "Up";
                    break;

                case ConsoleKey.DownArrow:
                    world.player.direction = "Down";
                    break;

                case ConsoleKey.RightArrow:
                    world.player.direction = "Right";
                    break;

                case ConsoleKey.LeftArrow:
                    world.player.direction = "Left";
                    break;
            }

            // Uppdatera världen och rendera om
            renderer.RenderBlank();
            world.Update();
            renderer.Render();

            // Beräkning av speltid
            double frameTime = Math.Ceiling((1000.0 / frameRate) - (DateTime.Now - before).TotalMilliseconds);
            if (frameTime > 0)
            {
                //Antal millisekunder före nästa cirkel i slingan
                Thread.Sleep((int)frameTime);
            }
        }
    }

    static void Main(string[] args)
    {               
        Loop();
    }
}
