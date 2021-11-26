using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace GamesList.Classes
{
    public class Game
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private List<Genre> _genres;
        [XmlIgnore]
        public List<Genre> Genres
        {
            get { return _genres; }
            set { _genres = value; }
        }

        private List<int> _genresIds;
        public List<int> GenresIds
        {
            get
            {
                if (Genres != null && Genres.Count > 0)
                {
                    List<int> ids = new List<int>();
                    foreach (Genre genre in Genres)
                        ids.Add(genre.Id);
                    return ids;
                }
                return _genresIds;
            }
            set { _genresIds = value; }
        }

        private List<GamePlatform> _platforms;
        public List<GamePlatform> Platforms
        {
            get { return _platforms; }
            set { _platforms = value; }
        }

        private List<GameBundle> _bundles;
        public List<GameBundle> Bundles
        {
            get { return _bundles; }
            set { _bundles = value; }
        }

        public Game()
        {
            Genres = new List<Genre>();
            GenresIds = new List<int>();
            Platforms = new List<GamePlatform>();
            Bundles = new List<GameBundle>();
            DefaultStatus = GamePlatform.GameStatus.NotPlayed;
            Date = DateTime.Today;
        }

        public override string ToString()
        {
            return Name;
        }

        private GamePlatform.GameStatus _defaultStatus;
        public GamePlatform.GameStatus DefaultStatus
        {
            get { return _defaultStatus; }
            set { _defaultStatus = value; }
        }

        public GamePlatform.GameStatus Status
        {
            get
            {
                if (Date > DateTime.Today)
                    return GamePlatform.GameStatus.NotYetReleased;
                else if (DefaultStatus == GamePlatform.GameStatus.Completed || Platforms.Exists(p => p.Status == GamePlatform.GameStatus.Completed))
                    return GamePlatform.GameStatus.Completed;
                else if (DefaultStatus == GamePlatform.GameStatus.Finished || Platforms.Exists(p => p.Status == GamePlatform.GameStatus.Finished))
                    return GamePlatform.GameStatus.Finished;
                else if (DefaultStatus == GamePlatform.GameStatus.Watched || Platforms.Exists(p => p.Status == GamePlatform.GameStatus.Watched))
                    return GamePlatform.GameStatus.Watched;
                else if (DefaultStatus == GamePlatform.GameStatus.Playing || Platforms.Exists(p => p.Status == GamePlatform.GameStatus.Playing))
                    return GamePlatform.GameStatus.Playing;
                else if (DefaultStatus == GamePlatform.GameStatus.OnHold || Platforms.Exists(p => p.Status == GamePlatform.GameStatus.OnHold))
                    return GamePlatform.GameStatus.OnHold;
                else if (DefaultStatus == GamePlatform.GameStatus.Dropped || Platforms.Exists(p => p.Status == GamePlatform.GameStatus.Dropped))
                    return GamePlatform.GameStatus.Dropped;
                else if (DefaultStatus == GamePlatform.GameStatus.Skipped || Platforms.Exists(p => p.Status == GamePlatform.GameStatus.Skipped))
                    return GamePlatform.GameStatus.Skipped;
                else if (DefaultStatus == GamePlatform.GameStatus.WaitTranslation || Platforms.Exists(p => p.Status == GamePlatform.GameStatus.WaitTranslation))
                    return GamePlatform.GameStatus.WaitTranslation;
                else if (DefaultStatus == GamePlatform.GameStatus.NotPlayed || Platforms.Exists(p => p.Status == GamePlatform.GameStatus.NotPlayed))
                    return GamePlatform.GameStatus.NotPlayed;
                else
                    return GamePlatform.GameStatus.Unknown;
            }
        }

        public bool Ready
        {
            get
            {
                return (Status == Game.GamePlatform.GameStatus.Finished ||
                    Status == Game.GamePlatform.GameStatus.NotPlayed ||
                    Status == Game.GamePlatform.GameStatus.OnHold ||
                    Status == Game.GamePlatform.GameStatus.Playing) &&
                    Platforms.Exists(p => p.Platform.Have && p.Have && p.Status == Status);
            }
        }

        public bool Started
        {
            get
            {
                return Status == Game.GamePlatform.GameStatus.Playing ||
                       Status == Game.GamePlatform.GameStatus.OnHold ||
                       Status == Game.GamePlatform.GameStatus.Finished;
            }
        }

        public string PlatformsString
        {
            get
            {
                string result = "";

                foreach (GamePlatform platform in Platforms)
                {
                    if (result.Length > 0)
                        result += " ";
                    result += platform.Platform.ShortName;
                }

                return result;
            }
        }

        public Color Color
        {
            get
            {
                return ColorByStatus(Status);
            }
        }

        public bool Have { get { return Platforms.Exists(p => p.Have); } }

        public static int CompareByDate(Game a, Game b)
        {
            if (a.Date == b.Date)
                return string.Compare(a.Name, b.Name);
            return DateTime.Compare(a.Date, b.Date);
        }

        public class GameBundle
        {
            private Bundle _bundle;
            [XmlIgnore]
            public Bundle Bundle
            {
                get { return _bundle; }
                set { _bundle = value; }
            }

            private int _bundleId;
            public int BundleId
            {
                get
                {
                    if (Bundle != null)
                        return Bundle.Id;
                    return _bundleId;
                }
                set { _bundleId = value; }
            }

            private int _number;
            public int Number
            {
                get { return _number; }
                set { _number = value; }
            }
        }

        public class GamePlatform
        {
            private Platform _platform;
            [XmlIgnore]
            public Platform Platform
            {
                get { return _platform; }
                set { _platform = value; }
            }

            private int _platformId;
            public int PlatformId
            {
                get
                {
                    if (Platform != null)
                        return Platform.Id;
                    return _platformId;
                }
                set { _platformId = value; }
            }

            private bool _have;
            public bool Have
            {
                get { return _have; }
                set { _have = value; }
            }

            private GameStatus _status = GameStatus.Unknown;
            [XmlIgnore]
            public GameStatus Status
            {
                get { return _status; }
                set { _status = value; }
            }

            public string GameStatusString
            {
                get { return GameStatusToString(Status); }
                set { Status = StringToGameStatus(value); }
            }


            public static string GameStatusToString(GameStatus existence)
            {
                switch (existence)
                {
                    case GameStatus.NotPlayed: return "Not Played";
                    case GameStatus.Playing: return "Playing";
                    case GameStatus.OnHold: return "On Hold";
                    case GameStatus.Dropped: return "Dropped";
                    case GameStatus.Skipped: return "Skipped";
                    case GameStatus.Finished: return "Finished";
                    case GameStatus.Completed: return "Completed";
                    case GameStatus.WaitTranslation: return "Wait Translation";
                    case GameStatus.Watched: return "Watched";
                    default: return "Unknown";
                }
            }

            public static GameStatus StringToGameStatus(string existence)
            {
                switch (existence)
                {
                    case "Not Played": return GameStatus.NotPlayed;
                    case "Playing": return GameStatus.Playing;
                    case "On Hold": return GameStatus.OnHold;
                    case "Dropped": return GameStatus.Dropped;
                    case "Skipped": return GameStatus.Skipped;
                    case "Finished": return GameStatus.Finished;
                    case "Completed": return GameStatus.Completed;
                    case "Wait Translation": return GameStatus.WaitTranslation;
                    case "Watched": return GameStatus.Watched;
                    default: return GameStatus.Unknown;
                }
            }

            public enum GameStatus
            {
                NotPlayed,
                Playing,
                OnHold,
                Dropped,
                Skipped,
                WaitTranslation,
                Finished,
                Completed,
                Watched,
                NotYetReleased,
                Unknown
            }
        }
        
        public static Color ColorByStatus(GamePlatform.GameStatus status)
        {
            switch (status)
            {
                case GamePlatform.GameStatus.NotPlayed: return Color.PaleGreen;
                case GamePlatform.GameStatus.Playing: return Color.LimeGreen;
                case GamePlatform.GameStatus.OnHold: return Color.Gold;
                case GamePlatform.GameStatus.Dropped: return Color.Crimson;
                case GamePlatform.GameStatus.Skipped: return Color.Silver;
                case GamePlatform.GameStatus.WaitTranslation: return Color.LightGoldenrodYellow;
                case GamePlatform.GameStatus.Finished: return Color.DeepSkyBlue;
                case GamePlatform.GameStatus.Completed: return Color.MediumOrchid;
                case GamePlatform.GameStatus.Watched: return Color.SkyBlue;
                case GamePlatform.GameStatus.NotYetReleased: return Color.LightPink;
                case GamePlatform.GameStatus.Unknown:
                default:
                    return Color.White;
            }
        }
    }

    public class GamesCollection
    {
        private static string fileName = "GamesList.xml";
        private static GamesCollection _gamesCollection;

        private List<Genre> _genres;
        public List<Genre> Genres
        {
            get { return _genres; }
            set { _genres = value; }
        }

        private List<Platform> _platforms;
        public List<Platform> Platforms
        {
            get { return _platforms; }
            set { _platforms = value; }
        }

        private List<Bundle> _bundles;
        public List<Bundle> Bundles
        {
            get { return _bundles; }
            set { _bundles = value; }
        }

        private List<Game> _games;
        public List<Game> Games
        {
            get { return _games; }
            set { _games = value; }
        }

        private GamesCollection()
        {
            Genres = new List<Genre>();
            Platforms = new List<Platform>();
            Bundles = new List<Bundle>();
            Games = new List<Game>();
        }

        public static GamesCollection GetInstance()
        {
            if (_gamesCollection == null)
                _gamesCollection = Load();
            return _gamesCollection;
        }

        public bool Save()
        {
            try
            {
                XmlHelper.SerializeAndSave(fileName, this);
                return Check();
            }
            catch
            {
                return false;
            }
        }

        private bool Check()
        {
            try
            {
                GamesCollection toCheck = fileName.LoadAndDeserialize<GamesCollection>();
                if (toCheck.Games.Count != Games.Count)
                    return false;
                if (toCheck.Bundles.Count != Bundles.Count)
                    return false;
                if (toCheck.Platforms.Count != Platforms.Count)
                    return false;
                if (toCheck.Genres.Count != Genres.Count)
                    return false;
            }
            catch
            {
                return false;
            }
            return true;
        }

        private static GamesCollection Load()
        {
            GamesCollection result;
            try
            {
                result = fileName.LoadAndDeserialize<GamesCollection>();
            }
            catch
            {
                return new GamesCollection();
            }

            foreach (Platform platform in result.Platforms)
                if (platform.ShortName == null || platform.ShortName.Length == 0)
                    platform.ShortName = platform.Name;

            SetGamesGenres(result.Games, result.Genres);
            SetGamesPlatforms(result.Games, result.Platforms);
            SetGamesBundles(result.Games, result.Bundles);

            result.Games.Sort(Game.CompareByDate);
            result.Bundles.Sort(Bundle.CompareByName);
            result.Platforms.Sort(Platform.CompareByName);
            result.Genres.Sort(Genre.CompareByName);

            return result;
        }

        private static void SetGamesGenres(List<Game> games, List<Genre> genres)
        {
            foreach (Game game in games)
                foreach (int gameGenreId in game.GenresIds)
                    foreach (Genre genre in genres)
                        if (genre.Id == gameGenreId)
                        {
                            game.Genres.Add(genre);
                            break;
                        }
        }

        private static void SetGamesPlatforms(List<Game> games, List<Platform> platforms)
        {
            foreach (Game game in games)
                foreach (Game.GamePlatform gamePlatform in game.Platforms)
                    foreach (Platform platform in platforms)
                        if (platform.Id == gamePlatform.PlatformId)
                        {
                            gamePlatform.Platform = platform;
                            break;
                        }
        }

        private static void SetGamesBundles(List<Game> games, List<Bundle> bundles)
        {
            foreach (Game game in games)
                foreach (Game.GameBundle gameBundle in game.Bundles)
                    foreach (Bundle bundle in bundles)
                        if (bundle.Id == gameBundle.BundleId)
                        {
                            gameBundle.Bundle = bundle;
                            break;
                        }
        }

        private int GetNextBundleNumber(Bundle bundle)
        {
            int num = -1;
            foreach (Game game in Games)
                foreach (Game.GameBundle gameBundle in game.Bundles)
                    if (gameBundle.Bundle == bundle)
                    {
                        if (gameBundle.Number > num)
                            num = gameBundle.Number;
                        break;
                    }

            return num + 1;
        }

        public Game.GameBundle GetGameBundle(Bundle bundle)
        {
            return new Game.GameBundle()
            {
                Bundle = bundle,
                Number = GetNextBundleNumber(bundle)
            };
        }

        public List<Game> GetNextGamesInBundle(Bundle bundle)
        {
            List<Bundle.BundleGame> bundleGames = GetBundleGames(bundle);
            List<Game> result = new List<Game>();
            foreach (Bundle.BundleGame bundleGame in bundleGames)
                if (bundleGame.Game.Status != Game.GamePlatform.GameStatus.Completed &&
                    bundleGame.Game.Status != Game.GamePlatform.GameStatus.Dropped &&
                    bundleGame.Game.Status != Game.GamePlatform.GameStatus.Skipped &&
                    bundleGame.Game.Status != Game.GamePlatform.GameStatus.WaitTranslation)
                {
                    result.Add(bundleGame.Game);
                    if (bundleGame.Game.Status != Game.GamePlatform.GameStatus.Finished && bundleGame.Game.Status != Game.GamePlatform.GameStatus.Watched)
                        break;
                }
            return result;
        }

        public bool IsGameNext(Game game)
        {
            foreach (Game.GameBundle bundle in game.Bundles)
                if (!GetNextGamesInBundle(bundle.Bundle).Contains(game))
                    return false;
            return true;
        }

        public List<Bundle.BundleGame> GetBundleGames(Bundle bundle)
        {
            List<Game> gamesOfBundle = Games.FindAll(g => g.Bundles.Exists(b => b.Bundle == bundle));
            List<Bundle.BundleGame> bundleGames = new List<Bundle.BundleGame>();
            foreach (Game g in gamesOfBundle)
                bundleGames.Add(new Bundle.BundleGame()
                {
                    Game = g,
                    Number = g.Bundles.Find(b => b.Bundle == bundle).Number
                });
            bundleGames.Sort(Bundle.BundleGame.CompareByNumber);

            return bundleGames;
        }

        public void Add(Bundle bundle)
        {
            int lastId = -1;
            foreach (Bundle b in Bundles)
                if (b.Id > lastId)
                    lastId = b.Id;

            bundle.Id = lastId + 1;

            Bundles.Add(bundle);
            Bundles.Sort(Bundle.CompareByName);
        }

        public void Add(Platform platform)
        {
            int lastId = -1;
            foreach (Platform p in Platforms)
                if (p.Id > lastId)
                    lastId = p.Id;

            platform.Id = lastId + 1;

            Platforms.Add(platform);
            Platforms.Sort(Platform.CompareByName);
        }

        public void Add(Genre genre)
        {
            int lastId = -1;
            foreach (Genre g in Genres)
                if (g.Id > lastId)
                    lastId = g.Id;

            genre.Id = lastId + 1;

            Genres.Add(genre);
            Genres.Sort(Genre.CompareByName);
        }

        public void Add(Game game)
        {
            Games.Add(game);
            Games.Sort(Game.CompareByDate);
        }

        public void Remove(Game game)
        {
            foreach (Game.GameBundle bundle in game.Bundles)
                foreach (Game bundleGame in Games)
                {
                    Game.GameBundle foundBundle = bundleGame.Bundles.Find(b => b.Bundle == bundle.Bundle);
                    if (foundBundle == null)
                        continue;
                    if (foundBundle.Number > bundle.Number)
                        foundBundle.Number--;
                }
            Games.Remove(game);
        }
    }
}
