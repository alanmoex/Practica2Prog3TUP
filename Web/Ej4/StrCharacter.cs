namespace Web.Ej4
{
    public class StrCharacter: Character
    {
        public StrCharacter(string name, int agi, int magicPwr): base(name, 100, agi, magicPwr) { }

        public override int CalculateDmg()
        {
            double dmg = Str * (Agi / 2) * (MagicPwr / 4);
            return (int)Math.Round(dmg);
        }

    }
}
