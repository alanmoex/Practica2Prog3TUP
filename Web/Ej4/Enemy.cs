namespace Web.Ej4
{
    public class Enemy : IMove
    {
        public int Health {  get; set; }
        public int Lvl { get; set; }

        public Enemy(int health, int lvl)
        {
            Health = health;
            Lvl = lvl;
        }

        string IMove.MoveXAxis()
        {
            return "Enemigo moviendose eje x";
        }

        string IMove.MoveYAxis()
        {
            return "Enemigo moviendose eje y";
        }
    }
}
