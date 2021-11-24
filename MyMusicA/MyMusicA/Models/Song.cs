using System;
using System.Collections.Generic;

namespace MyMusicA.Models
{
    public class Song
    {
        public int SongID { get; set; }

        public string SongName { get; set; }

        public string ArtistName { get; set; }

        public string SongUrl { get; set; }

        public string SongRating { get; set; }

        public string Favourite { get; set; }

        public string DateEntered { get; set; }

        public string DateEdited { get; set; }

        public int CategoryID { get; set; }

       //public virtual Category CategoryName { get; set; }
    }
}
