using System;
using Raylib_cs;

namespace slutproject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basen för reylib fönstret
            Raylib.InitWindow(800, 600, "The window maker");
            Raylib.SetExitKey(KeyboardKey.KEY_NULL);
            Raylib.SetTargetFPS(60);

            //Ny instans av spelbar karaktär
            Player player = new Player();
            GameWindow game = new GameWindow();

            //Kod när fönsret för raylib är öppet
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                game.window();
                //game.Draw();
                Raylib.EndDrawing();
            }
        }
    }
}
