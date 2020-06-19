using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSong.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Popularity { get; set; }
        public double Time { get; set; }
        public double Price { get; set; }
    }
}
