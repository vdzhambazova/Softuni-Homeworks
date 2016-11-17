using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int numberOfInput = int.Parse(Console.ReadLine());

        List<Song> playlist = new List<Song>();

        for (int i = 0; i < numberOfInput; i++)
        {
            try
            {
                string[] songDetails = Console.ReadLine().Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                string artistName = songDetails[0];
                string songName = songDetails[1];
                string[] length = songDetails[2].Split(new[] {':'});
                int minutes = 0;
                int seconds = 0;
                try
                {
                    minutes = int.Parse(length[0]);
                    seconds = int.Parse(length[1]);
                }
                catch (FormatException)
                {
                    throw new InvalidSongLengthException();
                }

                Song song = new Song(artistName, songName, minutes, seconds);
                playlist.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (InvalidSongException iso)
            {
                Console.WriteLine(iso.Message);
            }
        }

        Console.WriteLine($"Songs added: {playlist.Count}");
        int totalMinutes = playlist.Sum(x => x.Minutes);
        int totalSeconds = playlist.Sum(y => y.Seconds);
        int secondsToPrint = totalSeconds % 60;
        int minutesToPrint = (totalMinutes + totalSeconds / 60) % 60;
        int hours = (totalMinutes + totalSeconds / 60) / 60;
        Console.WriteLine($"Playlist length: {hours}h {(totalMinutes + totalSeconds / 60) % 60}m {secondsToPrint}s");
    }
}

public class Song
{
    private string artistName;
    private string songName;
    private int minutes;
    private int seconds;

    public Song(string artistName, string songName, int minutes, int seconds)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
    }

    public string ArtistName
    {
        get { return this.artistName; }
        set
        {
            if (3 > value.Length || value.Length > 20)
            {
                throw new InvalidArtistNameException();
            }

            this.artistName = value;
        }
    }

    public string SongName
    {
        get { return this.songName; }
        set
        {
            if (3 > value.Length || value.Length > 30)
            {
                throw new InvalidSongNameException();
            }

            this.songName = value;
        }
    }

    public int Minutes
    {
        get { return this.minutes; }
        set
        {
            if (0 > value || value > 14)
            {
                throw new InvalidSongMinutesException();
            }

            this.minutes = value;
        }
    }

    public int Seconds
    {
        get { return this.seconds; }
        set
        {
            if (0 > value || value > 59)
            {
                throw new InvalidSongSecondsException();
            }

            this.seconds = value;
        }
    }
}

public class InvalidSongException : Exception
{
    public const string InvalidSongExceptionMessage = "Invalid song.";

    public InvalidSongException() : base(InvalidSongExceptionMessage)
    {

    }

    public InvalidSongException(string message) : base(message)
    {
    }
}

public class InvalidArtistNameException : InvalidSongException
{
    public const string InvalidArtistNameExceptionMessage = "Song name should be between 3 and 30 symbols.";

    public InvalidArtistNameException() : base(InvalidArtistNameExceptionMessage)
    {
    }
}

public class InvalidSongNameException : InvalidSongException
{
    public const string InvalidSongNameExceptionMessage = "Song name should be between 3 and 30 symbols.";

    public InvalidSongNameException() : base(InvalidSongNameExceptionMessage)
    {
    }
}

public class InvalidSongLengthException : InvalidSongException
{
    public const string InvalidSongLengthExceptionMessage = "Invalid song length.";

    public InvalidSongLengthException(string message) : base(message)
    {
    }

    public InvalidSongLengthException() : base(InvalidSongLengthExceptionMessage)
    {
    }
}

public class InvalidSongMinutesException : InvalidSongLengthException
{
    public const string InvalidSongMinutesExceptionMessage = "Song minutes should be between 0 and 14.";

    public InvalidSongMinutesException() : base(InvalidSongMinutesExceptionMessage)
    {
    }
}

public class InvalidSongSecondsException : InvalidSongLengthException
{
    public const string InvalidSongSecondsExceptionMessage = "Song seconds should be between 0 and 59.";

    public InvalidSongSecondsException() : base(InvalidSongSecondsExceptionMessage)
    {
    }
}


