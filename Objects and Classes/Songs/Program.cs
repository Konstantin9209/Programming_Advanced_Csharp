using System;
using System.Collections.Generic;

public class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

    public Song(string typeList, string name, string time)
    {
        TypeList = typeList;
        Name = name;
        Time = time;
    }
}

public class Program
{
    public static void Main()
    {
        List<Song> songs = new List<Song>();

        int numberOfSongs = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfSongs; i++)
        {
            string[] songData = Console.ReadLine().Split('_');
            songs.Add(new Song(songData[0], songData[1], songData[2]));
        }

        string command = Console.ReadLine();

        foreach (var song in songs)
        {
            if (song.TypeList == command || command == "all")
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}
