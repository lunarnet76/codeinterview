namespace CodingInterview3
{
    public class CharacterClassification
    {
        public enum ID
        {
            JOHN_SNOW = 583,
            BALOM_GREYJOY = 12
        };

        public CharacterClassification() { }

        public bool IsHero(ID characterId)
        {
            // if it alegiance contains "House Stark of Winterfell" then it's a hero
            //@todo
            return true;
        }

        public bool IsAliasFromCharacter(string alias, ID character)
        {
            // @todo
            return false;
        }
    }
}
