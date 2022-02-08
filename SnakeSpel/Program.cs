using SnakeSpel;

class Program 
{ 
    // Adrian Tekin, Alex Hadi, Margarita Jarovaja, Linda Olofsson

    // Har lagt till så att maten har varierande utseende

    /// <summary>
    /// Checks Console to see if a keyboard key has been pressed, if so returns it, otherwise NoName.
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

            // Mät hur lång tid det tog
            double frameTime = Math.Ceiling((1000.0 / frameRate) - (DateTime.Now - before).TotalMilliseconds);
            if (frameTime > 0)
            {
                // Vänta rätt antal millisekunder innan loopens nästa varv
                Thread.Sleep((int)frameTime);
            }
        }
    }

    static void Main(string[] args)
    {
        
        
        Loop();
    }
}
