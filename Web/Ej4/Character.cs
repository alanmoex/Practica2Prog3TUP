namespace Web.Ej4
{
    public abstract class Character : IMove
    {
        public string Name { get; set; }
        public int Str { get; set; }
        public int Agi { get; set; }
        public int MagicPwr { get; set; }

        public Character(string name, int str, int agi, int magicPwr) 
        {
            Name = name;
            Str = str;
            Agi = agi;
            MagicPwr = magicPwr;
        }
        public virtual int CalculateDmg() 
        {   
            return 0;
        }

        public virtual string Attack()
        {
            return $"{Name} hizo {CalculateDmg()} de daño";
        }

        public string MoveXAxis()
        {
            return $"{Name} moviendose eje x";
        }

        public string MoveYAxis()
        {
            return $"{Name} moviendose eje y";
        }
    }
}
