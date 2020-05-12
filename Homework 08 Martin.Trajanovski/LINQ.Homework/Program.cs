using LINQ.Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Homework
{
    class Program
    {
        public static List<Artist> Artists { get; set; }
        public static List<Album> Albums { get; set; }
        public static List<Song> Songs { get; set; }
        static void Main(string[] args)
        {
            Init();// this method fills the arrays above with data
            
            // - print the mass of the earth on July 1895 XD
            /*
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░░░░░░░░░░░░░░░░░░░░░████████░░░░░░░░░
                ░░███████░░░░░░░░░░███▒▒▒▒▒▒▒▒███░░░░░░
                ░░█▒▒▒▒▒▒█░░░░░░░███▒▒▒▒▒▒▒▒▒▒▒▒███░░░░
                ░░░█▒▒▒▒▒▒█░░░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░
                ░░░░█▒▒▒▒▒█░░░██▒▒▒▒▄██▄▒▒▒▒▄██▄▒▒▒███░
                ░░░░░█▒▒▒█░░░█▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒██
                ░░░█████████████▒▒▒▒▀██▀▒▒▒▒▀██▀▒▒▒▒▒██
                ░░░█▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒██
                ░██▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒██▒▒▒▒▒▒▒▒▒██▒▒▒▒██
                ██▒▒▒███████████▒▒▒▒▒██▒▒▒▒▒▒▒██▒▒▒▒▒██
                █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒███████▒▒▒▒▒▒▒██
                ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░
                ░█▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░░
                ░██▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█░░░░░
                ░░████████████░░░████████████████░░░░░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░▄█████▄░▄███████▄░▄███████▄░██████▄░░
                ░░██▒▒▒▒█░███▒▒▒███░███▒▒▒███░██▒▒▒██░░
                ░░██▒▒▒▒▒░██▒▒▒▒▒██░██▒▒▒▒▒██░██▒▒▒██░░
                ░░██▒▒▒▀█░███▒▒▒███░███▒▒▒███░██▒▒▒██░░
                ░░▀█████▀░▀███████▀░▀███████▀░██████▀░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░▄█████░██▒▒▒▒██▀░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░██▀▒▒▒░██▒▒▒██░░░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░██▒▒▒▒░█████▀░░░░░░░
                ░░░░██▒▒▒▒░██▄▒▄██░██▄▒▒▒░██▒▒▒██░░░░░░
                ░░░░▀█████░▀█████▀░▀█████░██▒▒▒▒██▄░░░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
            */

            // QUERIES!

            // - how many Songs start with the letter 'a' (case insensitive)
            
            List<Song> songsThatStartwitha = Songs.Where(song => song.Name.StartsWith('a')).ToList();
            List<Song> songsThatStartwithA = Songs.Where(song => song.Name.StartsWith('A')).ToList();
            Console.WriteLine($"There are {songsThatStartwitha.Count()} song names that start with 'a', and {songsThatStartwithA.Count()} song names that start with 'A'!");
            Console.WriteLine("_____________________________");

            // - how many artists end with letter 'a' (case insensitive)

            List<Artist> artistsEndingWitha = Artists.Where(artist => artist.FullName.EndsWith('a')).ToList();
            Console.WriteLine($"There are/is {artistsEndingWitha.Count()} artist(s) whose name(s) end(s) with 'a'!");
            Console.WriteLine("_____________________________");

            // - whats the name of the song with longest duration
            int longestSong = Songs.Max(song => song.Duration);
            var longestSongName = Songs.Where(song => song.Duration == longestSong).Select(song => new { song.Name, song.Duration }).SingleOrDefault();
            Console.WriteLine($"Longest Song: Name: {longestSongName.Name} | Duration: {longestSongName.Duration} seconds");
            Console.WriteLine("_____________________________");

            // - whats the total Duration of all Songs

            var totalDuration = Songs.Sum(song => song.Duration);
            Console.WriteLine($"The total duration of all songs is {totalDuration} seconds!");
            Console.WriteLine("_____________________________");

            // - how many albums have Songs longer than 300 seconds

            List<int> albumsWithSongsLOngerThan300 = Songs.Where(song => song.Duration > 300).Select(song => song.AlbumId).ToList();
            List<int> numberOfAlbums = albumsWithSongsLOngerThan300.Distinct().ToList();
            Console.WriteLine($"There are {numberOfAlbums.Count()} albums with songs longer than 300 seconds!");
            Console.WriteLine("_____________________________");

            // - print the names of the artists(separated with "--"), that have more than one album of PopRock genre

            var popRockArtistsIds = Albums.Where(album => album.Genre == Genre.PopRock).Select(id => id.ArtistId).ToList();
            var returnDuplicates = popRockArtistsIds.GroupBy(id => id).Where(id => id.Count() > 1).Select(id => id.Key).ToList();
            List<string> names = new List<string>();
            foreach (var name in Artists)
            {
                foreach (var id in returnDuplicates)
                {
                    if (id == name.Id)
                    {
                        names.Add(name.FullName);
                    }
                }
            }
            List<string> artistWithPopRockAlbums = names.Distinct().ToList();
            Console.WriteLine($"The artists with more than one PopRock album are:");
            artistWithPopRockAlbums.ForEach(band => Console.Write($"{band} == "));
            Console.WriteLine("\n_____________________________");

            // - print the name of the album that has highest Average duration of a song

            Dictionary<string, double> nameAndDuration = new Dictionary<string, double>();
            foreach (var album in Albums)
            {
                double duration = album.Songs.Average(track => track.Duration);
                 nameAndDuration.Add(album.Name, duration);  
            }
            var printResult = nameAndDuration.OrderBy(duration => duration.Key).First();
            Console.WriteLine($"\nThe album { printResult.Key} has the highest average song duration with { printResult.Value} seconds!");
            Console.WriteLine("_____________________________");

            // - how many characters has the song that has the shortest Duration

            var shortestSong = Songs.Min(shortest => shortest.Duration);
            string songName = "";
            var shortestSongname = Songs.Where(shortest => shortest.Duration == shortestSong).Select(song => song.Name).ToList();
            shortestSongname.ForEach(name => songName = name);
            var shortestSongCharacters = Songs.Where(shortest => shortest.Duration == shortestSong).Select(song => song.Name.Length).ToList();
            shortestSongCharacters.ForEach(characters => Console.WriteLine($"The shortest song {songName} has {characters} characters!"));
            Console.WriteLine("_____________________________");

            // - print the name and the genre of the album that has most songs

            List<Album> allAlbums = new List<Album>();
            foreach (var album in Albums)
            {
                
                allAlbums.Add(album);
            }
            var albumWithMostSongs = allAlbums.OrderByDescending(count => count.Songs.Count()).Take(1);
            Console.WriteLine($"The album with the most songs is {albumWithMostSongs.First().Name}. Its genre is {albumWithMostSongs.First().Genre}");
            Console.WriteLine("_____________________________");

            // - print the name of the artist that has most songs

            List<int> idsOfAllSongs = Songs.Select(song => song.AlbumId).ToList();
            List<int> idsOfAllAlbumsArtists = new List<int>();
            List<string> nameOfArtistWithMostSongs = new List<string>();
            foreach (var album in Albums)
            {
                foreach (var id in idsOfAllSongs)
                {
                    if (id == album.Id)
                    {
                       idsOfAllAlbumsArtists.Add(album.ArtistId);
                    }
                }
            }
            var mostSongsByArtist = idsOfAllAlbumsArtists.GroupBy(i => i).OrderByDescending(group => group.Count()).Select(group => group.Key).First();
            foreach (var artist in Artists)
            {
                if (mostSongsByArtist == artist.Id)
                {
                    nameOfArtistWithMostSongs.Add(artist.FullName);
                }
            }
            nameOfArtistWithMostSongs.ForEach(name => Console.WriteLine($"The artist with most songs is {name}!"));
            Console.WriteLine("_____________________________");

            // - print the type of the artist(SoloArtist/Band) that has most albums published before year 2000

            List<int> idsOfArtistWithAlbumsBefore2000 = Albums.Where(album => album.Year > 2000).Select(album => album.ArtistId).ToList();
            List<string> typeOfArtistWithAlbumsBefore200 = new List<string>();
            var mostFrequentArtistId = idsOfArtistWithAlbumsBefore2000.GroupBy(i => i).OrderByDescending(group => group.Count()).Select(group => group.Key).First();
            foreach (var artist in Artists)
            {
                if (mostFrequentArtistId == artist.Id)
                {
                    typeOfArtistWithAlbumsBefore200.Add(artist.ArtistType.ToString());
                }
            }
            typeOfArtistWithAlbumsBefore200.ForEach(type => Console.WriteLine($"The artist with most albums before 200 is a {type}!"));
            Console.WriteLine("_____________________________");

            // - print the average song duration, of the album that has most songs

            double averageSongDuration = 0;
            foreach (var song in albumWithMostSongs)
            {
                averageSongDuration = song.Songs.Average(track => track.Duration);
            }
            Console.WriteLine($"The average song duration of the album with most songs, {albumWithMostSongs.First().Name}, is {averageSongDuration} seconds!");
            Console.WriteLine("_____________________________");

            // Bonus:

            // - print the longest song duration of the album that has least songs

            List<Album> everyAlbum = new List<Album>();
            foreach (var album in Albums)
            {

                everyAlbum.Add(album);
            }
            var albumWithFewestSongs = everyAlbum.OrderBy(count => count.Songs.Count()).ToList().First();
            var longestSongs = albumWithFewestSongs.Songs.OrderByDescending(song => song.Duration).ToList().First();
            Console.WriteLine($"The song with the longest duration is {longestSongs.Name} and it is {longestSongs.Duration} seconds long!");
            Console.WriteLine("_____________________________");

            // - print the name of the album that has most songs that contain letter 'a' in the name

            List<int> idsOfSongsContainingA = new List<int>();
            List<Album> albumWithMostSongsContainingA = new List<Album>();
            idsOfSongsContainingA = Songs.Where(song => song.Name.Contains('a')).Select(song => song.AlbumId).ToList();

            var mostFrequent = idsOfSongsContainingA.GroupBy(i => i).OrderByDescending(group => group.Count()).Select(group => group.Key).First();

            foreach (var album in Albums)
            {
                if (mostFrequent == album.Id)
                {
                    albumWithMostSongsContainingA.Add(album);
                }
            }
            Console.WriteLine($"The album with most songs containg 'a' is {albumWithMostSongsContainingA.First().Name}!");
            Console.WriteLine("_____________________________");

            // - print the name of the artist that has most songs that end with letter 'd'

            List<int> idsOfAlbumsWhoseSongsEndWithD = new List<int>();
            List<int> idsofArtistsWhoseSongsEndWithD = new List<int>();
            List<string> nameOfArtistWithMostSongsEndWithD = new List<string>();
            idsOfAlbumsWhoseSongsEndWithD = Songs.Where(song => song.Name.EndsWith('d')).Select(song => song.AlbumId).ToList();
            foreach (var album in Albums)
            {
                foreach (var id in idsOfAlbumsWhoseSongsEndWithD)
                {
                    if (id == album.Id)
                    {
                        idsofArtistsWhoseSongsEndWithD.Add(album.ArtistId);
                    }
                }
            }
            var mostFrequentArtistID = idsofArtistsWhoseSongsEndWithD.GroupBy(i => i).OrderByDescending(group => group.Count()).Select(group => group.Key).First();
            foreach(var artist in Artists)
            {
                if (mostFrequentArtistId == artist.Id)
                {
                    nameOfArtistWithMostSongsEndWithD.Add(artist.FullName);
                }
            }
            nameOfArtistWithMostSongsEndWithD.ForEach(name => Console.WriteLine($"The arist with most songs ending with 'd' is {name}!"));
            Console.WriteLine("_____________________________");





            // ************ Don't mind the structure, focus on the lists declared on the beginning of Program.cs ****************

            // 3, 2, 1.... GO! :)







            Console.ReadLine();
        }



        #region Data Initialization
        private static void Init()
        {
            InitArtists();
            InitAlbums();
            InitSongs();
            FillAlbums();
            FillArtists();
        }
        private static void FillAlbums()
        {
            foreach (var album in Albums)
            {
                album.Songs = Songs.Where(x => x.AlbumId == album.Id).ToList();
            }
        }
        private static void FillArtists()
        {
            foreach (var artist in Artists)
            {
                artist.Albums = Albums.Where(album => album.ArtistId == artist.Id).ToList();
            }
        }
        private static void InitArtists()
        {
            Artists = new List<Artist>();
            Artists.Add(new Artist(1, "Metallica", ArtistType.Band));
            Artists.Add(new Artist(2, "Iron Maiden", ArtistType.Band));
            Artists.Add(new Artist(3, "Rammstein", ArtistType.Band));
            Artists.Add(new Artist(4, "Coldplay", ArtistType.Band));
            Artists.Add(new Artist(5, "Beyonce", ArtistType.SoloArtist));
        }
        private static void InitAlbums()
        {
            Albums = new List<Album>();
            Albums.Add(new Album(1, 1, "Metallica", Genre.PopRock, 1991));
            Albums.Add(new Album(2, 1, "Ride The Lightning", Genre.PopRock, 1984));
            Albums.Add(new Album(3, 2, "Brave New World", Genre.PopRock, 2000));
            Albums.Add(new Album(4, 2, "Seventh Son of a Seventh Son", Genre.PopRock, 1988));
            Albums.Add(new Album(5, 3, "MUTTER", Genre.PopRock, 2001));
            Albums.Add(new Album(6, 3, "RosenRot", Genre.PopRock, 2005));
            Albums.Add(new Album(7, 4, "Mylo Xyloto", Genre.PopRock, 2011));
            Albums.Add(new Album(8, 5, "Lemonade", Genre.RnB, 2016));
        }
        private static void InitSongs()
        {
            Songs = new List<Song>();

            #region Metallica - Metallica
            Songs.Add(new Song(1, 1, "Enter Sandman", 5 * 60 + 31));
            Songs.Add(new Song(2, 1, "Sad But True", 5 * 60 + 24));
            Songs.Add(new Song(3, 1, "Holier Than Thou", 3 * 60 + 47));
            Songs.Add(new Song(4, 1, "The Unforgiven", 6 * 60 + 27));
            Songs.Add(new Song(5, 1, "Wherever I May Roam", 6 * 60 + 44));
            Songs.Add(new Song(6, 1, "Don't Tread on Me", 4 * 60 + 0));
            Songs.Add(new Song(7, 1, "Through the Never", 4 * 60 + 4));
            Songs.Add(new Song(8, 1, "Nothing Else Matters", 6 * 60 + 28));
            Songs.Add(new Song(9, 1, "Of Wolf and Man", 4 * 60 + 16));
            Songs.Add(new Song(10, 1, "The God That Failed", 5 * 60 + 8));
            Songs.Add(new Song(11, 1, "My Friend of Misery", 6 * 60 + 49));
            Songs.Add(new Song(12, 1, "The Struggle Within", 3 * 60 + 53));
            #endregion

            #region Metallica - ride-the-lightning
            Songs.Add(new Song(13, 2, "Fight Fire with Fire", 4 * 60 + 44));
            Songs.Add(new Song(14, 2, "Ride the Lightning", 6 * 60 + 36));
            Songs.Add(new Song(15, 2, "For Whom the Bell Tolls", 5 * 60 + 9));
            Songs.Add(new Song(16, 2, "Fade to Black", 6 * 60 + 57));
            Songs.Add(new Song(17, 2, "Trapped Under Ice", 4 * 60 + 4));
            Songs.Add(new Song(18, 2, "Escape", 4 * 60 + 23));
            Songs.Add(new Song(19, 2, "Creeping Death", 6 * 60 + 36));
            Songs.Add(new Song(20, 2, "The Call of Ktulu", 8 * 60 + 53));
            #endregion

            #region Iron Maiden - Brave New World
            Songs.Add(new Song(21, 3, "The Wicker Man", 4 * 60 + 35));
            Songs.Add(new Song(22, 3, "Ghost of the Navigator", 6 * 60 + 50));
            Songs.Add(new Song(23, 3, "Brave New World", 6 * 60 + 18));
            Songs.Add(new Song(24, 3, "Blood Brothers", 7 * 60 + 14));
            Songs.Add(new Song(25, 3, "The Mercenary", 4 * 60 + 42));
            Songs.Add(new Song(26, 3, "Dream of Mirrors", 9 * 60 + 21));
            Songs.Add(new Song(27, 3, "The Fallen Angel", 4 * 60 + 0));
            Songs.Add(new Song(28, 3, "The Nomad", 9 * 60 + 5));
            Songs.Add(new Song(29, 3, "Out of the Silent Planet", 6 * 60 + 25));
            Songs.Add(new Song(30, 3, "The Thin Line Between Love and Hate", 8 * 60 + 27));

            #endregion

            #region Iron Maiden - Seventh Son of a Seventh Son
            Songs.Add(new Song(31, 4, "Moonchild", 5 * 60 + 41));
            Songs.Add(new Song(32, 4, "Infinite Dreams", 6 * 60 + 9));
            Songs.Add(new Song(33, 4, "Can I Play with Madness", 3 * 60 + 31));
            Songs.Add(new Song(34, 4, "The Evil That Men Do", 4 * 60 + 34));
            Songs.Add(new Song(35, 4, "Seventh Son of a Seventh Son", 9 * 60 + 53));
            Songs.Add(new Song(36, 4, "The Prophecy", 5 * 60 + 6));
            Songs.Add(new Song(37, 4, "The Clairvoyant", 4 * 60 + 27));
            Songs.Add(new Song(38, 4, "Only the Good Die Young", 4 * 60 + 42));
            #endregion

            #region Rammstein - MUTTER
            Songs.Add(new Song(39, 5, "Mein Herz Brennt", 4 * 60 + 39));
            Songs.Add(new Song(40, 5, "Mein Herz Brennt", 3 * 60 + 36));
            Songs.Add(new Song(41, 5, "Sonne", 4 * 60 + 32));
            Songs.Add(new Song(42, 5, "Ich Will", 3 * 60 + 37));
            Songs.Add(new Song(43, 5, "Feuer Frei!", 3 * 60 + 11));
            Songs.Add(new Song(44, 5, "Mutter", 4 * 60 + 32));
            Songs.Add(new Song(45, 5, "Spieluhr", 4 * 60 + 46));
            Songs.Add(new Song(46, 5, "Zwitter", 4 * 60 + 17));
            Songs.Add(new Song(47, 5, "Rein Raus", 3 * 60 + 9));
            Songs.Add(new Song(48, 5, "Adios", 3 * 60 + 49));
            Songs.Add(new Song(49, 5, "Nebel", 4 * 60 + 54));
            #endregion

            #region Rammstein - Rosenrot
            Songs.Add(new Song(50, 6, "Benzin", 3 * 60 + 46));
            Songs.Add(new Song(51, 6, "Mann Gegen Mann", 3 * 60 + 50));
            Songs.Add(new Song(52, 6, "Rosenrot", 3 * 60 + 54));
            Songs.Add(new Song(53, 6, "Spring", 5 * 60 + 24));
            Songs.Add(new Song(54, 6, "Wo Bist Du", 3 * 60 + 55));
            Songs.Add(new Song(55, 6, "Stirb Nicht Vor Mir(Don't Die Before I Do)", 4 * 60 + 5));
            Songs.Add(new Song(56, 6, "Zerstören", 5 * 60 + 28));
            Songs.Add(new Song(57, 6, "Hilf Mir", 4 * 60 + 43));
            Songs.Add(new Song(58, 6, "Te Quiero Puta!", 3 * 60 + 55));
            Songs.Add(new Song(59, 6, "Feuer und Wasser", 5 * 60 + 17));
            Songs.Add(new Song(60, 6, "Ein Lied", 3 * 60 + 43));
            #endregion

            #region Coldplay - Mylo Xyloto
            Songs.Add(new Song(61, 7, "Mylo Xyloto", 0 * 60 + 43));
            Songs.Add(new Song(62, 7, "Hurts Like Heaven", 4 * 60 + 2));
            Songs.Add(new Song(63, 7, "Paradise", 4 * 60 + 37));
            Songs.Add(new Song(64, 7, "Charlie Brown", 4 * 60 + 45));
            Songs.Add(new Song(65, 7, "Us Against the World", 3 * 60 + 59));
            Songs.Add(new Song(66, 7, "M.M.I.X.", 0 * 60 + 48));
            Songs.Add(new Song(67, 7, "Every Teardrop Is a Waterfall", 4 * 60 + 0));
            Songs.Add(new Song(68, 7, "Major Minus", 3 * 60 + 30));
            Songs.Add(new Song(69, 7, "U.F.O.", 2 * 60 + 17));
            Songs.Add(new Song(70, 7, "Princess of China", 3 * 60 + 59));
            Songs.Add(new Song(71, 7, "Up in Flames", 3 * 60 + 13));
            Songs.Add(new Song(72, 7, "A Hopeful Transmission", 0 * 60 + 33));
            Songs.Add(new Song(73, 7, "Don't Let It Break Your Heart", 3 * 60 + 53));
            Songs.Add(new Song(74, 7, "Up with the Birds", 3 * 60 + 47));
            #endregion

            #region Beyonce - Lemonade
            Songs.Add(new Song(75, 8, "", 3 * 60 + 15));
            Songs.Add(new Song(76, 8, "", 3 * 60 + 41));
            Songs.Add(new Song(77, 8, "", 3 * 60 + 53));
            Songs.Add(new Song(78, 8, "", 3 * 60 + 52));
            Songs.Add(new Song(79, 8, "", 4 * 60 + 20));
            Songs.Add(new Song(80, 8, "", 4 * 60 + 47));
            Songs.Add(new Song(81, 8, "", 3 * 60 + 57));
            Songs.Add(new Song(82, 8, "", 3 * 60 + 2));
            Songs.Add(new Song(83, 8, "", 1 * 60 + 19));
            Songs.Add(new Song(84, 8, "", 4 * 60 + 49));
            Songs.Add(new Song(85, 8, "", 5 * 60 + 21));
            Songs.Add(new Song(86, 8, "", 3 * 60 + 25));

            #endregion

        }
        #endregion

    }
}
