using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.BasicOop.Class08.Homework.Domain.Classes
{
    public class Person
    {
        public Person (string firstName, string lastName, int age, Genre genre)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FavoriteMusicType = genre;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public void GetFavSongs ()
        {
            if(FavoriteSongs.Count == 0)
            {
                Console.WriteLine($"{FirstName} hates music");
            }
            else
            {
                Console.WriteLine($"{FirstName} favorite songs:");

                foreach(Song song in FavoriteSongs)
                {
                    Console.WriteLine($"Title: {song.Title} Genre: {song.Genre} Length: {song.Length}");
                }
            }
        }
    }
}
