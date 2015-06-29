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
    class SingleImage: MediaItem
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

        public SingleImage(string fileName)
        {
            this.FileName = fileName;
            this.DateTaken = this.getDateTaken(fileName);
        }
                
        //retrieves the datetime WITHOUT loading the whole image
        override public DateTime getDateTaken(string path)
        {
            try
            {
                return getExifDateTaken(path);
            }
            catch
            {
                //If cannot access EXIF get the file date
                return System.IO.File.GetCreationTime(path);
            }       
        }

        private DateTime getExifDateTaken(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                System.Drawing.Imaging.PropertyItem propertyItem = myImage.GetPropertyItem(36867);
                if (propertyItem != null)
                {
                    // Extract the property value as a String. 
                    System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                    string text = encoding.GetString(propertyItem.Value, 0, propertyItem.Len - 1);

                    // Parse the date and time. 
                    System.Globalization.CultureInfo provider = CultureInfo.InvariantCulture;
                    DateTime dateCreated = DateTime.ParseExact(text, "yyyy:MM:d H:m:s", provider);
                    return dateCreated;
                }
                return new DateTime();
            }
        }

        //Class end
    }
}
