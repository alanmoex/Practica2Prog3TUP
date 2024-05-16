namespace Web.Ej4
{
    public class MagicCharacter : Character
    {
        public MagicCharacter(string name, int str, int agi) : base(name, str, agi, 60) { }

        public MagicCharacter(string name, int str, int agi, int magicPwr) : base(name, str, agi, magicPwr) { }

        public override int CalculateDmg()
        {
            double dmg = Str + Agi + MagicPwr*4;
            return (int)Math.Round(dmg);
        }
        public override string Attack()
        {
            return $"{base.Attack()} gracias a su magia";
        }
    }
}
