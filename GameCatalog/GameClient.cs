using GameCatalog.Models;

namespace GameCatalog;

public static class GameClient
{
    private static readonly List<Game> games = new()
    {
        new Game()
        {
            Id = 1,
            GameName = "Call of Duty",
            Genre = "First Person Shooter",
            Price = 19.134M,
            ReleaseDate = new DateTime(2000, 03, 24)
        },
        new Game()
        {
            Id = 2,
            GameName = "Legend of Zelda Breath of the Wild",
            Genre = "Adventure",
            Price = 60.00M,
            ReleaseDate = new DateTime(2017, 3, 3)
        }
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        game.Id = games.Max(game => game.Id) + 1;
        games.Add(game);
    }

    public static Game GetGame(int id)
    {
        return games.Find(game => game.Id == id) ?? throw new Exception("Could not find game!");
    }

    public static void UpdateGame(Game updateGame)
    {
        Game existingGame = GetGame(updateGame.Id);
        existingGame.GameName = updateGame.GameName;
        existingGame.Genre = updateGame.Genre;
        existingGame.Price = updateGame.Price;
        existingGame.ReleaseDate = updateGame.ReleaseDate;
    }

    public static void DeleteGame(int id)
    {
        Game game = GetGame(id);
        games.Remove(game);
    }
}