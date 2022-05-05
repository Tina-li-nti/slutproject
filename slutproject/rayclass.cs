using System;
using Raylib_cs;

namespace slutproject
{



    //Den spelbara karaktären
    public class Player
    {
        Rectangle rect = new Rectangle(400, 300, 40, 40);
        public int hp = 100;

        //Färläggning av karaktären
        public void Draw()
        {
            Raylib.DrawRectangleRec(rect, Color.BLACK);
        }

        //Kod som gör karaktären "rörbar"
        public void Update()
        {

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                rect.y -= 2f;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                rect.y += 2f;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                rect.x -= 2f;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                rect.x += 2f;
            }
        }

    }

    //Bas kod för alla fiender
    public class Enemy
    {
        public Rectangle enemyBasic = new Rectangle(10, 10, 40, 40);
        public int hp = 20;
    }

    //Olika variationer av alla fiender, fienderna är döpta efter deras olika respektive färger och komer bli mer och mer svåra.
    public class Purle : Enemy
    {

        public void Draw()
        {
            Raylib.DrawRectangleRec(enemyBasic, Color.PURPLE);
        }

    }
    public class Blue : Enemy
    {

        public void Draw()
        {
            Raylib.DrawRectangleRec(enemyBasic, Color.BLUE);
        }

    }
    public class Green : Enemy
    {

        public void Draw()
        {
            Raylib.DrawRectangleRec(enemyBasic, Color.GREEN);
        }

    }
    public class Yellow : Enemy
    {

        public void Draw()
        {
            Raylib.DrawRectangleRec(enemyBasic, Color.YELLOW);
        }

    }
    public class Orange : Enemy
    {

        public void Draw()
        {
            Raylib.DrawRectangleRec(enemyBasic, Color.ORANGE);
        }

    }
    public class RED : Enemy
    {

        public void Draw()
        {
            Raylib.DrawRectangleRec(enemyBasic, Color.RED);
        }

    }

    //kod som ska kunna byta mellan en startskärm en pause skärm och själva spelet
    public class GameWindow
    {
        public int gameScreen = 1;
        Player player;
        public void window()
        {

            switch (gameScreen)
            {
                case 1:
                    Raylib.DrawRectangle(0, 0, 800, 600, Color.LIME);
                    Raylib.DrawText("Start Screen", 200, 150, 50, Color.BLACK);
                    Raylib.DrawText("Press ENTER to start", 100, 300, 20, Color.BLACK);
                    Raylib.DrawText("Move the character using WASD", 100, 330, 20, Color.BLACK);
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        player = new Player();
                        gameScreen = 3;
                    }
                    break;
                case 2:
                    Raylib.DrawRectangle(0, 0, 800, 600, Color.LIME);
                    Raylib.DrawText("Game Paused", 200, 150, 50, Color.BLACK);
                    Raylib.DrawText("Press ESC to resume game", 100, 330, 20, Color.BLACK);
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ESCAPE))
                    {
                        gameScreen = 3;
                    }
                    break;
                case 3:
                    Raylib.DrawRectangle(0, 0, 800, 600, Color.WHITE);
                    player.Draw();
                    player.Update();
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ESCAPE))
                    {
                        gameScreen = 2;
                    }
                    break;
            }
        }
       
    }

}