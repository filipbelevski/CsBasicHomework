using SEDC.BasicOop.Class08.Homework.Domain.Classes;
using System;

namespace SEDC.BasicOop.Class08.Homework.Domain
{
    public class Song
    {
        public Song (string title, int length, Genre genre)
        {
            this.Title = title;
            this.Length = length;
            this.Genre = genre;
        }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Length { get; set; }
        
    }
}
