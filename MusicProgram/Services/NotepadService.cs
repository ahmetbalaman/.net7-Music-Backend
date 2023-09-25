using System;
using MusicProgram.Entities;
namespace MusicProgram.Services
{
	public class NotepadService
	{
		public NotepadService()
		{
		}


        public void PlayListToNotepad(Playlist playlist)
        {
            string directory = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\Playlists";
            string path = Path.Combine(directory, $"{playlist.Id} Playlist.txt");
            if (!File.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
                

        File.WriteAllText(path, playlist?.GetSongs());
        Console.WriteLine("Succesfully write it");
        }
        public void WriteToword()
        {
            //Saving To Microsoft Word...

        }
    }
}

