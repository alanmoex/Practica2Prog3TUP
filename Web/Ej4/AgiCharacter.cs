namespace Web.Ej4
{
    public class AgiCharacter : Character
    {
        public AgiCharacter(string name, int str, int agi, int magicPwr) :base(name,str,agi,magicPwr) { }

        public override int CalculateDmg()
        {
            double dmg = (Str / 2) + Agi + (MagicPwr / 2);
            return (int)Math.Round(dmg);
        }
    }
}
