using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    // Tri Le
    public class Song
    {
        public int SongID { get; set; }
        public string SongName { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string AlbumName { get; set; }
        public string AlbumCover { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ReviewText { get; set; }
        public int RatingValue { get; set; }
    }
}
