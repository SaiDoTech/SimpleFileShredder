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

        public bool Find(string adr)
        {
            if (Directory.Exists(adr))
            {
                if (Collect(adr))
                    return true;
                else
                    return false;
            }
            else if (File.Exists(adr))
            {
                AddFile(adr);
                return true;
            }

            return false;
        }

        private bool Collect(string adr)
        {
            return true;
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
