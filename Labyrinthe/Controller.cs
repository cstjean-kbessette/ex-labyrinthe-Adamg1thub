using System.Net.Http.Headers;

namespace Labyrinthe
{
    internal class Controller
    {
        private View view;
        private Labyrinthe labyrinthe;
        
        public Controller(Labyrinthe labyrinthe, View view)
        {
            this.view = view;
            this.labyrinthe = labyrinthe;
        }
        public void Run()
        {
            while (true)
            {
                if (labyrinthe.IsExit())
                {
                    view.AfficherVictoire();
                    break;
                }
                view.AfficherEntete();
                view.AfficherLabyrinthe(labyrinthe);
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        labyrinthe.MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        labyrinthe.MoveDown();
                        break;
                    case ConsoleKey.LeftArrow:
                        labyrinthe.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        labyrinthe.MoveRight();
                        break;
                }
            }            
        }
    }
}
