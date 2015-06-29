using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoSort
{
    class FileManager
    {
        private string photoMask = ".png|.jpg|.jpeg|.gif|.bmp|.3fr|.ari|.arw|.bay|.crw|.cr2|.cap|.dcs|.dcr|.dng|.drf|.eip|.erf|.fff|.iiq|.k25|.kdc|.mdc|.mef|.mos|.mrw|.nef|.nrw|.obm|.orf|.pef|.ptx|.pxn|.r3d|.raf|.raw|.rwl|.rw2|.rwz|.sr2|.srf|.srw|.tif|.x3f";
        public string PhotoMask
        {
            get
            {
                return this.photoMask;
            }
            set
            {
                this.photoMask = value.ToLower();
            }
        }

        private string videoMask = ".avi|.mov|.flv|.mpeg4|.wmv|.mpeg|.mp4";
        public string VideoMask
        {
            get
            {
                return this.videoMask;
            }
            set
            {
                this.videoMask = value.ToLower();
            }
        }

        private List<MediaItem> mediaList;
        public List<MediaItem> MediaList
        {
            get
            {
                return this.mediaList;
            }
            set
            {
                this.mediaList = value;
            }
        }

        //Where to save the files
        private string photoDestinationFolder;
        public string PhotoDestinationFolder
        {
            get
            {
                return this.photoDestinationFolder;
            }
            set
            {
                this.photoDestinationFolder = value;
            }
        }

        private string videoDestinationFolder;
        public string VideoDestinationFolder
        {
            get
            {
                return this.videoDestinationFolder;
            }
            set
            {
                this.videoDestinationFolder = value;
            }
        }

        //New folder structure
        private string newFolderName;
        public string NewFolderName
        {
            get
            {
                return this.newFolderName;
            }
            set
            {
                this.newFolderName = value;
            }
        }

        private string newFileName;
        public string NewFileName{
            get
            {
                return this.newFileName;
            }
            set
            {
                this.newFileName = value;
            }
        }

        public FileManager () {
            this.mediaList = new List<MediaItem>();
            this.NewFolderName = "[[y]]\\[[m]]\\[[d]]";
            this.NewFileName = "[[h]]_[[min]]_[[s]]";
        }

        public void scanFolder(string path,bool scanVideos = true)
        {
            this.mediaList.AddRange(this.getRecursiveFileList(path, scanVideos));
        }

        private List<MediaItem> getRecursiveFileList(string path, bool scanVideos = true)
        {
            List<MediaItem> buff = new List<MediaItem>();
            
            try
            {
                //Scan files first
                buff.AddRange(this.getFileList(path, scanVideos));
               
                //Scan subdirs
                foreach (string dir in Directory.GetDirectories(path))
                {
                    buff.AddRange(this.getFileList(dir, scanVideos));
                }
            }
            catch (Exception) {
                //Swallow  access exceptions here
                //throw;
            }

            return buff;
        }

        private List<MediaItem> getFileList(string path,bool scanVideos = true)
        {
            List<MediaItem> buff = new List<MediaItem>();
            string[] photoExtensions = this.PhotoMask.Split('|');
            string[] videoExtensions = this.VideoMask.Split('|');

            //Scan them all 
            IEnumerable<string> dir = Directory.EnumerateFiles(path, "*.*");

            //get photo files
            foreach (string file in dir
                                    .Where(f => photoExtensions.Contains(Path.GetExtension(f).ToLower()))
                                    .ToArray()
                    )
            {
                buff.Add(new SingleImage(file));
            }
            
            //get video files
            if (scanVideos)
            {
                foreach (string file in dir
                                    .Where(f => videoExtensions.Contains(Path.GetExtension(f).ToLower()))
                                    .ToArray()
                    )
                {
                    buff.Add(new SingleVideo(file));
                }
            }
            
            return buff;
        }

        public void exportPhotos( Action callback, bool moveFiles = false)
        {
            //All checks here
            if (this.PhotoDestinationFolder == "" || !Directory.Exists(this.photoDestinationFolder))
            {
                MessageBox.Show("Please select destionation folder!","Error");
                return;
            }
            if ( this.MediaList.Count == 0 ) {
                MessageBox.Show("No files to export!", "Error");
                return;
            }
            //Prepare filename and copy/move files
            foreach ( MediaItem singleMedia in this.MediaList){
                this.copySingleImage(singleMedia, moveFiles);
                callback();
            }

            MessageBox.Show("You can now check " + this.PhotoDestinationFolder + " for changes!", "Ready!");
    	}


        private void copySingleImage(MediaItem singleMedia, bool moveFiles)
        {
            string oldFileName = singleMedia.FileName;
            string extension = Path.GetExtension(oldFileName);
            string newFolder = this.PhotoDestinationFolder + "\\" + this.NewFolderName;
            
            //Form the new filename
            newFolder = this.replaceTags(newFolder, singleMedia);
            if (! Directory.Exists(newFolder)){
                Directory.CreateDirectory(newFolder);
            }
            string newName = newFolder + "\\" + this.NewFileName;

            newName = this.replaceTags(newName,singleMedia) + extension;
            //Smart one
            if ( File.Exists(newName) ) {
                long oldFileSize = new FileInfo(oldFileName).Length;
                long newFileSize = new FileInfo(newName).Length;

                DateTime newDateTime = singleMedia.getDateTaken(newName); //damn cheat here
                if ( oldFileSize != newFileSize && singleMedia.DateTaken != newDateTime){
                    //copy with new name
                    newName = this.findNewName(newName);
                    this.copyThem(singleMedia.FileName, newName, moveFiles);
                }
            }
            else
            {
                this.copyThem(singleMedia.FileName, newName,moveFiles);
            }
        }

        private string replaceTags(string original, MediaItem singleMedia)
        {
            return original.Replace("[[y]]", singleMedia.Year.ToString())
                            .Replace("[[m]]", singleMedia.Month.ToString())
                            .Replace("[[d]]", singleMedia.Day.ToString())
                            .Replace("[[h]]", singleMedia.Hour.ToString())
                            .Replace("[[min]]", singleMedia.Minutes.ToString())
                            .Replace("[[s]]", singleMedia.Seconds.ToString());
        }

        private void copyThem(string source, string destination, bool move){
            if (move){
                File.Move(source, destination);
            }
            else
            {
                File.Copy(source,destination);
            }
        }

        private string findNewName(string takenName)
        {
            int counter = 1;
            while (File.Exists(takenName))
            {
                string path = Path.GetDirectoryName( takenName );
                string name = Path.GetFileNameWithoutExtension( takenName );
                string ext = Path.GetExtension( takenName );
                counter ++;
                takenName = path + "\\" + name + "_" + counter.ToString() + ext; 
            }
            return takenName;
        }
        //End of class
    }
}
