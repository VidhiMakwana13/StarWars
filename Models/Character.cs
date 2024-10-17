namespace StarWarsCharacters.Models
{
    public class Character
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string BirthYear { get; set; }
        public string[] Films { get; set; }
    }

    public class CharacterResponse
    {
        public int Count { get; set; }
        public Character[] Results { get; set; }
    }
}
