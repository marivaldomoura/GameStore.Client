using GameStore.Client.Models;

namespace GameStore.Client;

public static class GameClient
{
    private static readonly List<Game> games = new()
    {
        new Game()
        {
            Id = 1,
            Name = "Street Figth II",
            Genre = "Figthing",
            Price = 19.90M,
            ReleaseDate = new DateTime(1991,2,1)
        },
        new Game()
        {
            Id = 2,
            Name = "Final Fantasy XIV",
            Genre = "Roleplaying",
            Price = 59.90M,
            ReleaseDate = new DateTime(2010,9,30)
        },
        new Game()
        {
            Id = 3,
            Name = "Fifa 23",
            Genre = "Sports",
            Price = 69.90M,
            ReleaseDate = new DateTime(2022,9,27)
        }
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

}