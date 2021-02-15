using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleFileShredder
{
    public class UserController
    {
        private List<string> FilesList = new List<string>();
        private List<string> DirList = new List<string>();

        public UserController()
        {}

        public void AddFile(string adr)
        {
            if (File.Exists(adr))
                FilesList.Add(adr);
        }

        public void AddDir(string adr)
        {
            if (Directory.Exists(adr))
                DirList.Add(adr);
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
    }
}
