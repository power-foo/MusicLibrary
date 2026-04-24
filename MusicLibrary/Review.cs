using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int SongID { get; set; }
        public int UserID { get; set; }
        public int RatingValue { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }
        public string SongName { get; set; }
    }
}
