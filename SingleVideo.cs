using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhotoSort
{
    class SingleVideo : MediaItem
    {
        //Full path and filename
        private string fileName;
        override public string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
            }
        }

        //DateTaken - EXIF or file data
        private DateTime dateTaken;
        override public DateTime DateTaken
        {
            get
            {
                return this.dateTaken;
            }
            set
            {
                this.dateTaken = value;
            }
        }

        //Date comps
        private int day;
        override public int Day
        {
            get
            {
                return this.DateTaken.Day;
            }
        }

        private int month;
        override public int Month
        {
            get
            {
                return this.DateTaken.Month;
            }
        }

        private int year;
        override public int Year
        {
            get
            {
                return this.DateTaken.Year;
            }
        }

        private int hour;
        override public int Hour
        {
            get
            {
                return this.DateTaken.Hour;
            }
        }

        private int minutes;
        override public int Minutes
        {
            get
            {
                return this.DateTaken.Minute;
            }
        }

        private int seconds;
        override public int Seconds
        {
            get
            {
                return this.DateTaken.Second;
            }
        }

        public SingleVideo(string fileName)
        {
            this.FileName = fileName;
            this.DateTaken = this.getDateTaken(fileName);
        }

        //retrieves the datetime WITHOUT loading the whole image
        override public DateTime getDateTaken(string path)
        {
            //If cannot access EXIF get the file date
                return System.IO.File.GetCreationTime(path);
        }

        
        //Class end
    }
}
