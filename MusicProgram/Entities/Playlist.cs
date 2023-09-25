using System;
using System.Text;

namespace MusicProgram.Entities
{
    public class Playlist
    {

        public Guid Id { get; set; }
        private List<Song> Songs{get; set;}

        private Random random;

        public Playlist(Song song)
        {
            Id = Guid.NewGuid();
            random = new();
            Songs = new List<Song>();
            AddSong(song);
        }

        public string GetSongs(){
return string.Join("\n", Songs.Select( x => $"{x.Title} - (x.Composer"));
}


        public void AddSong(Song song)
        {
            if
            (song != null)
            {
                Songs.Add(song);
            }
        }

        public void ShowSongs()
        {
            foreach (Song song in Songs)
                Console.WriteLine($"Title: {song.Title} - {song.Composer}");

        }

        public void ShuffleSongs()
        {
            int count = Songs.Count; //n = 5
           
            while (count > 0)
            {
                count--;
                Song songCount = Songs[count];
               
                Song swapSong = Songs[random.Next(count)];
            }
        }


    }
        

 
}

