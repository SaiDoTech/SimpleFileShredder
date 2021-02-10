﻿using System;
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
            var dirs = Directory.GetDirectories(adr);
            var files = Directory.GetFiles(adr);

            foreach (var dir in dirs)
            {
                Collect(dir);
            }

            foreach (var file in files)
            {
                AddFile(file);
            }

            if ((FilesList.Count == 0) && (DirList.Count == 0))
                return false;
            else
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
