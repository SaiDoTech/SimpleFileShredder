using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleFileShredder
{
    public class FileController
    {
        private List<string> FilesList;
        private List<string> DirList;

        public FileController()
        {
            FilesList = null;
            DirList = null;
        }

        public bool Find(string adr)
        {
            if (Directory.Exists(adr))
            {
                return Collect(adr);
            }
            else if (File.Exists(adr))
            {
                AddFile(adr);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Collect(string adr)
        {
            var FileList = Directory.GetFiles(adr);
            var DirList = Directory.GetDirectories(adr);

            foreach (var file in FileList)
            {
                AddFile(file);
            }

            foreach (var dir in DirList)
            {
                AddDir(dir);
                Collect(dir);
            }

            if (FileList.Length != 0 && DirList.Length != 0)
                return true;
            else
                return false;
        }

        private void AddFile(string adr)
        {
            if (File.Exists(adr))
                AddFile(adr);
        }

        private void AddDir(string adr)
        {
            if (Directory.Exists(adr))
                AddDir(adr);
        }
    }
}
