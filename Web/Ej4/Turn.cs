namespace Web.Ej4
{
    public static class Turn
    {
        public static void AttackEachOther(IList<Character> characters)
        {
            foreach (Character character in characters)
            {
                character.Attack();
            }
        }


    }
}
