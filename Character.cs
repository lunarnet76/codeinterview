namespace CodingInterview3
{
    public record Character
    {
        public CharacterClassification.ID Id { get; set; }
        public string Name { get; set; }
        public bool IsHero { get; set; }
    }
}
