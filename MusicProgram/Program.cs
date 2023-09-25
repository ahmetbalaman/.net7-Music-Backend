// See https://aka.ms/new-console-template for more information

using MusicProgram.Services;
using MusicProgram.Entities;

Console.WriteLine("Sqotify - Music for Noone");
var song1 = new Song("Requiem K. 626", "W. A. Mozart", "Orchestre national de France", null);
var song2 = new Song("Sonata No.6 in F Major", "L. Beethoven", "Fazil Say", "Warner Music");
var song3 = new Song("Moonlight Sonata", "Ludwig van Beethoven", "Various Artists", "Classical Records");
var song4 = new Song("The four seasons","Antonio Vivaldi", "Chamber Orchestra", "Baroque Productions");
var song5 = new Song("Symphony No. 9","Ludwig van Beethoven", "Philharmonic Orchestra", "Classic Harmony Records");
var playlist1 = new Playlist(song1);
playlist1.AddSong(song2);
playlist1.AddSong(song3);
playlist1.AddSong(song4);
playlist1.AddSong(song5);



NotepadService notepadService = new NotepadService();


notepadService.PlayListToNotepad(playlist1);
Console.WriteLine(playlist1.GetSongs());
playlist1.ShuffleSongs();
Console.WriteLine(playlist1.GetSongs);

Console.ReadLine();