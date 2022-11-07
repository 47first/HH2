namespace Bebra
{
    public class Game
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Owner { get; set; }
        public int Cost { get; set; }
    }

    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Owner { get; set; }
    }

    public class Genre
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class Launcher
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Company { get; set; }
        public string? Version { get; set; }
    }

    public class Showground
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Owner { get; set; }
        public string? Description { get; set; }
    }
}
