using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleFileShredder
{
    public class FileController
    {
        private UserController user;

        public FileController(UserController user)
        {
            this.user = user;
        }

        public bool Find(string adr)
        {
            if (Directory.Exists(adr))
            {
                return Collect(adr);
            }
            else if (File.Exists(adr))
            {
                user.AddFile(adr);
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
                user.AddFile(file);
            }

            foreach (var dir in DirList)
            {
                user.AddDir(dir);
                Collect(dir);
            }

            if (FileList.Length != 0 && DirList.Length != 0)
                return true;
            else
                return false;
        }
    }
}
