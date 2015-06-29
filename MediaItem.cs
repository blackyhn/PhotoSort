using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSort
{
    abstract class MediaItem
    {
        abstract public string FileName { get; set; }
        abstract public DateTime DateTaken { get; set; }
        abstract public int Day { get; }
        abstract public int Month { get; }
        abstract public int Year { get; }
        abstract public int Hour { get; }
        abstract public int Minutes { get; }
        abstract public int Seconds { get; }

        abstract public DateTime getDateTaken(string path);
    
        //Class end
    }
}
