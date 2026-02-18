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
                if(labyrinthe.IsExit())
                    view.AfficherVictoire();
                view.AfficherEntete();
                view.AfficherLabyrinthe(labyrinthe);
                Console.WriteLine("Haut, bas, gauche ou droite (W-A-S-D)");
                char choix;
                while (true)
                {
                    try
                    {
                        choix = Convert.ToChar(Console.ReadLine());
                        if (choix == 'W' || choix == 'S' || choix == 'A' || choix == 'D')
                        break;
                        throw new Exception();
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Touche incorrecte");
                    } 
                }
                if (choix == 'W')
                    labyrinthe.MoveUp();
                else if (choix =='A')
                    labyrinthe.MoveLeft();
                else if (choix == 'S')
                    labyrinthe.MoveDown();
                else 
                    labyrinthe.MoveRight();
            }            
        }
    }
}
