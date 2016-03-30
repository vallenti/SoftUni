using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

public class ScoreboardMain
{
    static void Main()
    {
        var commandExecutor = new ScoreboardCommandExecutor();
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "End")
            {
                break;
            }
            if (command != "")
            {
                string commandResult = commandExecutor.ProcessCommand(command);
                Console.WriteLine(commandResult);
            }
        }
    }
}

public class ScoreboardCommandExecutor
{
    private Scoreboard scoreboard = new Scoreboard();

    public string ProcessCommand(string commandLine)
    {
        var tokens = commandLine.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);
        var command = tokens[0];
        switch (command)
        {
            case "RegisterUser":
                return RegisterUser(tokens[1], tokens[2]);
            case "RegisterGame":
                return RegisterGame(tokens[1], tokens[2]);
            case "AddScore":
                return AddScore(tokens[1], tokens[2], tokens[3], tokens[4],
                    int.Parse(tokens[5]));
            case "ShowScoreboard":
                return ShowScoreboard(tokens[1]);
            case "DeleteGame":
                return DeleteGame(tokens[1], tokens[2]);
            case "ListGamesByPrefix":
                return ListGamesByPrefix(tokens[1]);
            default:
                return "Incorrect command";
        }
    }

    private string RegisterUser(string username, string userPassword)
    {
        if (this.scoreboard.RegisterUser(username, userPassword))
        {
            return "User registered";
        }

        return "Duplicated user";
    }

    private string RegisterGame(string gameName, string gamePassword)
    {
        if (this.scoreboard.RegisterGame(gameName, gamePassword))
        {
            return "Game registered";
        }

        return "Duplicated game";
    }

    private string AddScore(string username, string userPassword,
        string gameName, string gamePassword, int score)
    {
        if (this.scoreboard.AddScore(username, userPassword,
            gameName, gamePassword, score))
        {
            return "Score added";
        }

        return "Cannot add score";
    }

    private string ShowScoreboard(string gameName)
    {
        var scoreboardEntries = this.scoreboard.ShowScoreboard(gameName);
        if (scoreboardEntries == null)
        {
            return "Game not found";
        }

        if (scoreboardEntries.Any())
        {
            var result = new StringBuilder();
            int counter = 0;
            foreach (var entry in scoreboardEntries)
            {
                counter++;
                result.AppendFormat("#{0} {1} {2}",
                    counter, entry.Username, entry.Score);
                result.AppendLine();
            }
            result.Length -= Environment.NewLine.Length;
            return result.ToString();
        }

        return "No score";
    }

    private string DeleteGame(string gameName, string gamePassword)
    {
        if (this.scoreboard.DeleteGame(gameName, gamePassword))
        {
            return "Game deleted";
        }

        return "Cannot delete game";
    }

    private string ListGamesByPrefix(string namePrefix)
    {
        var matchedGames = this.scoreboard.ListGamesByPrefix(namePrefix);
        if (matchedGames.Any())
        {
            return string.Join(", ", matchedGames);
        }

        return "No matches";
    }
}

public class Scoreboard
{
    private Dictionary<string, string> users;
    private Dictionary<string, string> games;
    private OrderedDictionary<string, OrderedBag<ScoreboardEntry>> scoreboard;

    private int maxEntriesToKeep;

    public Scoreboard(int maxEntriesToKeep = 10)
    {
        this.maxEntriesToKeep = maxEntriesToKeep;
        users = new Dictionary<string, string>();
        games = new Dictionary<string, string>();
        scoreboard = new OrderedDictionary<string, OrderedBag<ScoreboardEntry>>((g1, g2) => string.CompareOrdinal(g1, g2));
    }

    public bool RegisterUser(string username, string password)
    {
        if(users.ContainsKey(username))
        {
            return false;
        }

        users.Add(username, password);
        return true;
    }

    public bool RegisterGame(string game, string password)
    {
        if(games.ContainsKey(game))
        {
            return false;
        }

        games.Add(game, password);
        if (!scoreboard.ContainsKey(game))
        {
            scoreboard.Add(game, new OrderedBag<ScoreboardEntry>());
        }
        return true;
    }

    public bool AddScore(string username, string userPassword, 
        string game, string gamePassword, int score)
    {
        if(!users.ContainsKey(username) || !users[username].Equals(userPassword))
        {
            return false;
        }

        if(!games.ContainsKey(game) || !games[game].Equals(gamePassword))
        {
            return false;
        }

        var scoreEntry = new ScoreboardEntry(username, score);
        if(!scoreboard.ContainsKey(game))
        {
            scoreboard.Add(game, new OrderedBag<ScoreboardEntry>());
        }
        scoreboard[game].Add(scoreEntry);
        return true;

    }

    public IEnumerable<ScoreboardEntry> ShowScoreboard(string game)
    {
        if(!scoreboard.ContainsKey(game))
        {
            return null;
        }

        var currentGame = scoreboard[game];
        return currentGame.Take(maxEntriesToKeep);
    }

    public bool DeleteGame(string game, string gamePassword)
    {
        if(!games.ContainsKey(game) || !games[game].Equals(gamePassword))
        {
            return false;
        }

        games.Remove(game);
        scoreboard.Remove(game);
        return true;
    }

    public IEnumerable<string> ListGamesByPrefix(string gameNamePrefix)
    {
        var upperBound = gameNamePrefix + char.MaxValue;
        var gamesWithPrefix = scoreboard.Range(gameNamePrefix, true, upperBound, false);
        return gamesWithPrefix.Take(maxEntriesToKeep).Select(e => e.Key);
    }
}

public class ScoreboardEntry : IComparable<ScoreboardEntry>
{

    public ScoreboardEntry(string username, int score)
    {
        this.Username = username;
        this.Score = score;
    }

    public string Username { get; set; }
    public int Score { get; set; }

    public int CompareTo(ScoreboardEntry other)
    {
        if(this.Score == other.Score)
        {
            return this.Username.CompareTo(other.Username);
        }

        return other.Score.CompareTo(this.Score);
    }
}
