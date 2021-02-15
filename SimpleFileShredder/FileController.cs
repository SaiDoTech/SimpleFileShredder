using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleFileShredder
{
    public class FileController
    {
        private List<string> FilesList = new List<string>();
        private List<string> DirList = new List<string>();

        public FileController()
        {
        }

        public List<String> GetFiles()
        {
            return FilesList;
        }

        public void ClearLists()
        {
            FilesList.Clear();
            DirList.Clear();
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
                FilesList.Add(adr);
        }

        private void AddDir(string adr)
        {
            if (Directory.Exists(adr))
                DirList.Add(adr);
        }
    }
}
