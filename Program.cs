using System;
using System.Collections.Generic;


namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string artist, string song)> goodSongs = new List<(string, string)>();
            HashSet<(string artist, string song)> allSongs = new HashSet<(string, string)>()
            {
                ("Michael Jackson", "Bad"),
                ("NickelBack", "Photograph"),
                ("Stevie Wonder", "Superstition"),
                ("NickelBack", "How You Remind Me"),
                ("NickelBack", "Savin' Me"),
                ("Elvis", "A Little Less Conversation"),
                ("NickelBack", "Too Bad")
            };

            //loop over songs
            foreach ((string artist, string song) songs in allSongs)
            {

                //if songs are not nickelback, add songs to  goodSongs list

                if (songs.artist != "NickelBack")
                {
                    goodSongs.Add(songs);
                }
                Console.WriteLine(songs.artist);
            }
            //loop through goodSongs and print them to the console
            foreach (var item in goodSongs)
            {
                Console.WriteLine(item);
            }

        }

    }

}
